using System.IO;
using Microsoft.Owin;
using Owin;
using System.Web.Routing;
using GrapeCity.ActiveReports.Aspnet.Viewer;
using System.Reflection;
using System.Web.Hosting;
using System;

[assembly: OwinStartup(typeof(CORS.Server.Startup))]

namespace CORS.Server
{
    public class Startup
    {
        private static readonly string CurrentDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)?.Replace("file:\\", "");
        public static readonly DirectoryInfo ReportsDirectory = new DirectoryInfo(Path.Combine(CurrentDir, "Reports"));

        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();

            app.UseReportViewer(settings =>
            {
                settings.UseFileStore(ReportsDirectory);
                settings.UseConfig(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ActiveReports.config"));
                settings.UseCodeBasedSectionReports(typeof(JSViewerCodeReports.DeliveryNote).Assembly, typeof(JSViewerCodeReports.DeliveryNote).Namespace);
            });

            RouteTable.Routes.RouteExistingFiles = true;
        }
    }
}
