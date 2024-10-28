using Microsoft.OpenApi.Models;


var appName = "Standard Calculator Api";
var appVersion = "v1";
var appDescription = "Standard calculator Api using ASP.NET";

var openApiContact = new OpenApiContact
{
    Name = "Leandro Freires",
    Url = new Uri("https://github.com/Dev-Leandro-Freires")
};

var openApiInfo = new OpenApiInfo
{
    Title = appName,
    Version = appVersion,
    Description = appDescription,
    Contact = openApiContact
};

var swaggerUrn = $"/swagger/{appVersion}/swagger.json";


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen( options => {options.SwaggerDoc(appVersion, openApiInfo);} );


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(options => options.SwaggerEndpoint(swaggerUrn, $"{appName} - {appVersion}"));

app.UseHttpsRedirection();

app.MapControllers();

app.Run();


