using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace JSViewer_MVC.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		[Route("")]
		[Route("index")]
		public ActionResult Index()
		{
			return Resource("index.html");
		}

		[HttpGet]
		[Route("{file}")]
		public ActionResult Resource(string file)
		{
			string filePath = Path.Combine(HttpRuntime.AppDomainAppPath, "wwwroot", file);
			if (!System.IO.File.Exists(filePath))
				return new HttpNotFoundResult();

			if (Path.GetExtension(file) == ".html")
				return new ContentResult() { Content = System.IO.File.ReadAllText(filePath), ContentType = "text/html" };

			var resFile = System.IO.File.ReadAllBytes(filePath);

			if (Path.GetExtension(file) == ".ico")
				return new FileContentResult(resFile, "image/x-icon") { FileDownloadName = file };

			return new FileContentResult(resFile, GetMimeType(file)) { FileDownloadName = file };
		}

		[HttpGet]
		[Route("reports")]
		public ActionResult Reports()
		{
			var rdlReportsList = GetFileStoreReports(new[] { ".rdl", ".rdlx", ".rdlx-master" });
			var rdlDocsList = new HashSet<string>(GetFileStoreReports(new[] { ".rdlx-snap" }).Select(doc => Path.GetFileNameWithoutExtension(doc)), StringComparer.InvariantCultureIgnoreCase);
			var rpxReportsList = GetFileStoreReports(new[] { ".rpx" });
			var rpxDocsList = new HashSet<string>(GetFileStoreReports(new[] { ".rdf" }).Select(doc => Path.GetFileNameWithoutExtension(doc)), StringComparer.InvariantCultureIgnoreCase);

			var codeBasedReportsList = GetCodeBasedReports(typeof(JSViewerCodeReports.DeliveryNote).Assembly);

			var allReports = rdlReportsList.Select(report => new ReportDescriptor(report, rdlDocsList.Contains(Path.GetFileNameWithoutExtension(report)), Path.GetFileNameWithoutExtension(report) + ".rdlx-snap")).Union(
							 rpxReportsList.Select(report => new ReportDescriptor(report, rpxDocsList.Contains(Path.GetFileNameWithoutExtension(report)), Path.GetFileNameWithoutExtension(report) + ".rdf")).Union(
							 codeBasedReportsList.Select(report => new ReportDescriptor(report, false, "")))
 				).OrderBy(rd => rd.name);

			return new JsonResult
			{
				Data = allReports.ToArray(),
				JsonRequestBehavior = JsonRequestBehavior.AllowGet
			};
		}

		/// <summary>
		/// Gets the MIME type from the file extension
		/// </summary>
		/// <param name="fileName">File name</param>
		/// <returns>MIME type</returns>
		private static string GetMimeType(string fileName)
		{
			if (fileName.EndsWith(".css"))
				return "text/css";

			if (fileName.EndsWith(".js"))
				return "text/javascript";

			return "text/html";
		}

		/// <summary>
		/// Gets report names from folder
		/// </summary>
		/// <returns>Report names</returns>
		private static string[] GetFileStoreReports(string[] validExtensions)
		{
			return Startup.ReportsDirectory
				.EnumerateFiles("*.*")
				.Select(x => x.Name)
				.Where(x => validExtensions.Any(x.EndsWith))
				.ToArray();
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

		public struct ReportDescriptor
		{
			public ReportDescriptor(string name, bool hasSnapshot, string snapshotName)
			{
				this.name = name;
				this.hasSnapshot = hasSnapshot;
				this.snapshotName = snapshotName;
			}

			public string name { get; }
			public bool hasSnapshot { get; }
			public string snapshotName { get; }
		}
	}
}