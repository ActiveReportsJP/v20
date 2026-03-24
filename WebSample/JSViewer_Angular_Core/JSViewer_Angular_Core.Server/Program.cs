using GrapeCity.ActiveReports.Aspnetcore.Viewer;
using System.Reflection;
using System.Text;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

string resourcesDirectoryName = "Reports";
DirectoryInfo ReportsDirectory = new(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty, resourcesDirectoryName));

var options = new WebApplicationOptions
{
	Args = args,
	ContentRootPath = AppContext.BaseDirectory,
	WebRootPath = resourcesDirectoryName
};

var builder = WebApplication.CreateBuilder(options);

// Add services to the container.
builder.Services.AddReportViewer()
                .AddControllersWithViews();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

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
    settings.UseFileStore(ReportsDirectory);
    settings.UseConfig(Path.Combine(app.Environment.ContentRootPath, "ActiveReports.config"));
    settings.UseCodeBasedSectionReports(typeof(JSViewerCodeReports.DeliveryNote).Assembly, typeof(JSViewerCodeReports.DeliveryNote).Namespace);
});

app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();