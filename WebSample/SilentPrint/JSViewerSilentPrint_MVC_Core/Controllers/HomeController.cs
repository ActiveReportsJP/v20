using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace JSViewer_MVCCore.Controllers
{
	[Route("/")]
	public class HomeController : Controller
	{
		private static readonly string CurrentDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? System.String.Empty;
		public static readonly DirectoryInfo ReportsDirectory = new DirectoryInfo(Path.Combine(CurrentDir, "Reports"));

		[HttpGet("reports")]
		public ActionResult Reports()
		{
			var rdlReportsList = GetFileStoreReports(new[] { ".rdl", ".rdlx", ".rdlx-master" });
			var rdlDocsList = GetFileStoreReports(new[] { ".rdlx-snap" }).Select(doc => Path.GetFileNameWithoutExtension(doc)).ToHashSet(StringComparer.InvariantCultureIgnoreCase);
			var rpxReportsList = GetFileStoreReports(new[] { ".rpx" });
			var rpxDocsList = GetFileStoreReports(new[] { ".rdf" }).Select(doc => Path.GetFileNameWithoutExtension(doc)).ToHashSet(StringComparer.InvariantCultureIgnoreCase);

			var allReports = rdlReportsList.Select(report => new ReportDescriptor(report, rdlDocsList.Contains(Path.GetFileNameWithoutExtension(report)), Path.GetFileNameWithoutExtension(report) + ".rdlx-snap")).Union(
							 rpxReportsList.Select(report => new ReportDescriptor(report, rpxDocsList.Contains(Path.GetFileNameWithoutExtension(report)), Path.GetFileNameWithoutExtension(report) + ".rdf"))
				).OrderBy(rd => rd.Name);

			return new JsonResult(allReports.ToArray());
		}

		/// <summary>
		/// Gets report names from folder
		/// </summary>
		/// <returns>Report names</returns>
		private string[] GetFileStoreReports(string[] validExtensions)
		{
			return ReportsDirectory
				.EnumerateFiles("*.*")
				.Select(x => x.Name)
				.Where(x => validExtensions.Any(x.EndsWith))
				.ToArray();
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
}