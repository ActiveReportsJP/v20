using GrapeCity.ActiveReports.Aspnetcore.Designer;
using GrapeCity.ActiveReports.Aspnetcore.Viewer;
using GrapeCity.ActiveReports.Web.Designer;
using System.Text;

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
    config.UseConfig(Path.Combine(app.Environment.ContentRootPath, "ActiveReports.config"));
});

app.UseFileServer();
app.UseMvc();
app.Run();