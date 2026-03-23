using System.Reflection;

namespace BlazorViewerServer.Data
{
	public sealed class ReportDescriptor
	{
		public ReportDescriptor(string name, bool hasSnapshot, string snapshotName)
		{
			Name = name;
			HasSnapshot = hasSnapshot;
			SnapshotName = snapshotName;
			UseSnapshot = hasSnapshot;
		}

		public string Name { get; }
		public bool HasSnapshot { get; }
		public string SnapshotName { get; }
		public bool UseSnapshot { get; set; }
		public string GetReportName() => UseSnapshot ? SnapshotName : Name;
	}

	public class ReportsService
	{
		private static readonly string CurrentDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? String.Empty;
		public static readonly DirectoryInfo ReportsDirectory = new(Path.Combine(CurrentDir, "Reports"));

		public IEnumerable<ReportDescriptor> GetReports()
		{
			var rdlReportsList = GetFileStoreReports([".rdl", ".rdlx", ".rdlx-master"]);
			var rdlDocsList = GetFileStoreReports([".rdlx-snap"]).Select(doc => Path.GetFileNameWithoutExtension(doc)).ToHashSet(StringComparer.InvariantCultureIgnoreCase);
			var rpxReportsList = GetFileStoreReports([".rpx"]);
			var rpxDocsList = GetFileStoreReports([".rdf"]).Select(doc => Path.GetFileNameWithoutExtension(doc)).ToHashSet(StringComparer.InvariantCultureIgnoreCase);

			var codeBasedReportsList = GetCodeBasedReports(typeof(JSViewerCodeReports.DeliveryNote).Assembly);

			var allReports = rdlReportsList.Select(report => new ReportDescriptor(report, rdlDocsList.Contains(Path.GetFileNameWithoutExtension(report)), Path.GetFileNameWithoutExtension(report) + ".rdlx-snap")).Union(
							 rpxReportsList.Select(report => new ReportDescriptor(report, rpxDocsList.Contains(Path.GetFileNameWithoutExtension(report)), Path.GetFileNameWithoutExtension(report) + ".rdf")).Union(
							 codeBasedReportsList.Select(report => new ReportDescriptor(report, false, "")))
				).OrderBy(rd => rd.Name);

			return allReports;
		}

		/// <summary>
		/// Gets report names from folder
		/// </summary>
		/// <returns>Report names</returns>
		private static string[] GetFileStoreReports(string[] validExtensions)
		{
			return [.. ReportsDirectory
				.EnumerateFiles("*.*")
				.Select(x => x.Name)
				.Where(x => validExtensions.Any(x.EndsWith))];
		}

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

	}
}
