using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace JSViewerVueCore.Controllers;

[Route("/")]
public class HomeController : Controller
{
	private static readonly string CurrentDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? System.String.Empty;
	public static readonly DirectoryInfo ReportsDirectory = new(Path.Combine(CurrentDir, "Reports"));

	[HttpGet("reports")]
	public ActionResult Reports()
	{
		var files = ReportsDirectory.GetFiles();
		var rdlReportsList = GetFileStoreReports(files, ".rdl", ".rdlx", ".rdlx-master");
		var rdlDocsList = GetFileStoreReports(files, ".rdlx-snap")
			.Select(doc => Path.GetFileNameWithoutExtension(doc))
			.ToHashSet(StringComparer.InvariantCultureIgnoreCase);

		var rpxReportsList = GetFileStoreReports(files, ".rpx");
		var rpxDocsList = GetFileStoreReports(files, ".rdf")
			.Select(doc => Path.GetFileNameWithoutExtension(doc))
			.ToHashSet(StringComparer.InvariantCultureIgnoreCase);

		var codeBasedReportsList = GetCodeBasedReports(typeof(JSViewerCodeReports.DeliveryNote).Assembly);

		var allReports = rdlReportsList.Select(report => CreateReportDescriptor(report, rdlDocsList, ".rdlx-snap"))
			.Union(rpxReportsList.Select(report => CreateReportDescriptor(report, rpxDocsList, ".rdf"))
			.Union(codeBasedReportsList.Select(report => CreateReportDescriptor(report))))
			.OrderBy(rd => rd.Name);

		return new JsonResult(allReports.ToArray());
	}

	private static ReportDescriptor CreateReportDescriptor(string report, HashSet<string>? docsList = null, string extension = "")
	{
		string reportName = Path.GetFileNameWithoutExtension(report);
		return new ReportDescriptor(report, docsList?.Contains(reportName) ?? false, $"{reportName}{extension}");
	}

	/// <summary>
	/// Gets report names from the specified file list.
	/// </summary>
	/// <returns>Report names</returns>
	private static IEnumerable<string> GetFileStoreReports(FileInfo[] files, params string[] validExtensions) =>
		files.Select(x => x.Name).Where(x => validExtensions.Any(x.EndsWith));

	/// <summary>
	/// Gets report names from assembly with code based reports
	/// </summary>
	/// <returns></returns>
	private static IEnumerable<string> GetCodeBasedReports(Assembly assembly)
	{
		Type sectionReportClass = typeof(GrapeCity.ActiveReports.SectionReport);

		return assembly.GetTypes()
			.Where(t => t.IsClass && t.IsSubclassOf(sectionReportClass))
			.Select(t => t.Name);
	}

	public struct ReportDescriptor
	{
		public ReportDescriptor(string name, bool hasSnapshot, string snapshotName)
		{
			Name = name;
			HasSnapshot = hasSnapshot;
			SnapshotName = snapshotName;
		}

		public string Name { get; }
		public bool HasSnapshot { get; }
		public string SnapshotName { get; }
	}
}