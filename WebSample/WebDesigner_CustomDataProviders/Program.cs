using C1.AdoNet.OData;
using GrapeCity.ActiveReports.Aspnetcore.Designer;
using GrapeCity.ActiveReports.Aspnetcore.Viewer;
using GrapeCity.ActiveReports.Configuration;
using GrapeCity.ActiveReports.Web.Designer;
using System.Data.SQLite;
using System.Text;
using WebDesignerCustomDataProviders;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

DirectoryInfo ResourcesRootDirectory =
    new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "resources" + Path.DirectorySeparatorChar));

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddReportViewer()
                .AddReportDesigner()
                .AddMvc(options => options.EnableEndpointRouting = false)
                .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);


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

app.UseReportDesigner(config =>
{
    config.UseFileStore(ResourcesRootDirectory, null, FileStoreOptions.NestedFoldersLookup);
    config.UseDataProviders(
    [
        new DataProviderInfo("SQLITE",
            typeof(SQLiteFactory).AssemblyQualifiedName,
            null),
		new DataProviderInfo("ODATA",
			typeof(C1ODataProviderFactory).AssemblyQualifiedName,
			typeof(C1ODataConnectionAdapter).AssemblyQualifiedName)
    ]);
    config.OmitViewerConfiguration = true;
    config.UseConfig(Path.Combine(app.Environment.ContentRootPath, "ActiveReports.config"));
});

app.UseReportViewer(config =>
{
    config.UseFileStore(ResourcesRootDirectory);
    config.UseDataProviders(
    [
		new DataProviderInfo("SQLITE",
			typeof(SQLiteFactory).AssemblyQualifiedName,
			null),
		new DataProviderInfo("ODATA",
			typeof(C1ODataProviderFactory).AssemblyQualifiedName,
			typeof(C1ODataConnectionAdapter).AssemblyQualifiedName)
	]);
    config.UseConfig(Path.Combine(app.Environment.ContentRootPath, "ActiveReports.config"));
});
app.UseFileServer();
app.UseMvc();
app.Run();