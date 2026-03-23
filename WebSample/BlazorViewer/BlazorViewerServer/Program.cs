using BlazorViewerServer.Data;
using GrapeCity.ActiveReports.Aspnetcore.Viewer;
using System.Reflection;
using System.Text;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

DirectoryInfo ReportsDirectory = new(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? String.Empty, "Reports"));

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<ReportsService>();
builder.Services.AddServerSideBlazor();
builder.Services.AddRazorPages();


var app = builder.Build();

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
    settings.UseFileStore(ReportsDirectory);
    settings.UseConfig(Path.Combine(app.Environment.ContentRootPath, "ActiveReports.config"));

    settings.UseCodeBasedSectionReports(typeof(JSViewerCodeReports.DeliveryNote).Assembly, typeof(JSViewerCodeReports.DeliveryNote).Namespace);
});

app.UseRouting();
app.UseStaticFiles();

app.MapFallbackToPage("/_Host");
app.MapBlazorHub();

app.Run();