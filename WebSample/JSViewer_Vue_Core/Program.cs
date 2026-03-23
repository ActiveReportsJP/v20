using GrapeCity.ActiveReports.Aspnetcore.Viewer;
using System.Text;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddReportViewer()
				.AddMvc(options => options.EnableEndpointRouting = false);


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
	settings.UseFileStore(JSViewerVueCore.Controllers.HomeController.ReportsDirectory);
	settings.UseConfig(Path.Combine(app.Environment.ContentRootPath, "ActiveReports.config"));
	settings.UseCodeBasedSectionReports(typeof(JSViewerCodeReports.DeliveryNote).Assembly, typeof(JSViewerCodeReports.DeliveryNote).Namespace);
});

app.UseAuthorization();
app.UseFileServer();
app.UseHttpsRedirection();
app.UseRouting();
app.UseStaticFiles();

app.UseMvc(routes =>
{
	routes.MapRoute(
		name: "default",
		template: "{controller=Home}/{action=Index}/{id?}");
});

app.MapControllers();

app.Run();