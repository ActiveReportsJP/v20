using GrapeCity.ActiveReports.Aspnetcore.Viewer;
using JSViewer_React_Hooks.Server.Controllers;
using System.Reflection;
using System.Text;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

string resourcesDirectoryName = "Reports";

var options = new WebApplicationOptions
{
    Args = args,
    ContentRootPath = AppContext.BaseDirectory,
    WebRootPath = resourcesDirectoryName
};

var builder = WebApplication.CreateBuilder(options);

// Add services to the container.

builder.Services
    .AddReportViewer()
    .AddControllersWithViews();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
}

app.UseReportViewer(settings =>
{
    settings.UseConfig(Path.Combine(app.Environment.ContentRootPath, "ActiveReports.config"));
    settings.UseFileStore(ReportsController.ReportsDirectory);
    settings.UseCodeBasedSectionReports(typeof(JSViewerCodeReports.DeliveryNote).Assembly, typeof(JSViewerCodeReports.DeliveryNote).Namespace);
});

app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("/index.html");

app.Run();
