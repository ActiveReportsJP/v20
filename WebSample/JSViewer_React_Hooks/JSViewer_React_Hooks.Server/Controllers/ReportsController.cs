using Microsoft.AspNetCore.Mvc;
using System.Reflection;


namespace JSViewer_React_Hooks.Server.Controllers
{
    [Route("[controller]")]
    public class ReportsController : Controller
    {
        private static readonly string CurrentDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty;

        private static readonly HashSet<string> RdlReportExtensions = [".rdl", ".rdlx", ".rdlx-master"];
        private static readonly string RdlReportSnapshotExtension = ".rdlx-snap";

        private static readonly HashSet<string> RpxReportExtensions = [".rpx"];
        private static readonly string RpxReportSnapshotExtension = ".rdf";

        public static readonly DirectoryInfo ReportsDirectory = new(Path.Combine(CurrentDir, "Reports"));

        [HttpGet("")]
        public ActionResult Reports()
        {
            var reports = GetFileStoreReports(RdlReportExtensions, RdlReportSnapshotExtension);

            reports = reports.Union(GetFileStoreReports(RpxReportExtensions, RpxReportSnapshotExtension));

            reports = reports.Union(GetCodeBasedReports(typeof(JSViewerCodeReports.DeliveryNote).Assembly));

            return new JsonResult(reports.OrderBy(rd => rd.Name).ToArray());
        }

        /// <summary>
        /// Gets report descriptors from folder by report extensions
        /// </summary>
        /// <returns>Report names</returns>
        private static IEnumerable<ReportDescriptor> GetFileStoreReports(HashSet<string> reportExtensions, string snapshotExtension)
        {
            HashSet<string> snapshots = string.IsNullOrWhiteSpace(snapshotExtension)
                ? []
                : [.. ReportsDirectory
                .EnumerateFiles($"*.{snapshotExtension.TrimStart('.')}")
                .Where(x => x.Name.EndsWith(snapshotExtension))
                .Select(x => x.Name)];

            return ReportsDirectory
                .EnumerateFiles("*.*")
                .Where(x => reportExtensions.Contains(Path.GetExtension(x.Name)))
                .Select(x =>
                {
                    var snapshotName = string.IsNullOrWhiteSpace(snapshotExtension) ? "" : Path.ChangeExtension(x.Name, snapshotExtension);

                    return new ReportDescriptor(
                        x.Name, 
                        hasSnapshot: !string.IsNullOrWhiteSpace(snapshotName) && snapshots.Contains(snapshotName), 
                        snapshotName);
                });
        }

        /// <summary>
        /// Gets report descriptors from assembly with code based reports
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<ReportDescriptor> GetCodeBasedReports(Assembly assembly)
        {
            Type sectionReportClass = typeof(GrapeCity.ActiveReports.SectionReport);

            return assembly.GetTypes()
                .Where(t => t.IsClass && t.IsSubclassOf(sectionReportClass))
                .Select(t => new ReportDescriptor(t.Name, false, ""));
        }

        public struct ReportDescriptor(string name, bool hasSnapshot, string snapshotName)
        {
            public string Name { get; } = name;
            public bool HasSnapshot { get; } = hasSnapshot;
            public string SnapshotName { get; } = snapshotName;
            public bool UseSnapshot { get; } = hasSnapshot;
        }
    }
}
