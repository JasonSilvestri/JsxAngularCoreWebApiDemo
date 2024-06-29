using System.Reflection;
using Microsoft.OpenApi.Models;
using JsxClassLibrary;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Original out-of-the-box Swagger settings
// builder.Services.AddSwaggerGen();

// Modified Swagger settings for custom jSX Web API Demos
builder.Services.AddSwaggerGen(options =>
{

    options.SwaggerDoc(JsxConstants.AppCards.AppSwaggerCards.SwagVersion, new OpenApiInfo
    {
        Version = JsxConstants.AppCards.AppSwaggerCards.JsxAngular.SwagDoc.SwagVersion,
        Title = JsxConstants.AppCards.AppSwaggerCards.JsxAngular.SwagDoc.Title,
        Description = JsxConstants.AppCards.AppSwaggerCards.JsxAngular.SwagDoc.Description,
        TermsOfService = new Uri(JsxConstants.AppCards.AppSwaggerCards.JsxAngular.SwagDoc.TermsOfService),
        Contact = new OpenApiContact
        {
            Name = JsxConstants.AppCards.AppSwaggerCards.JsxAngular.Contact.Name,
            Email = JsxConstants.AppCards.AppSwaggerCards.JsxAngular.Contact.Email,
            Url = new Uri(JsxConstants.AppCards.AppSwaggerCards.JsxAngular.Contact.PrimaryUrl)
        },
        License = new OpenApiLicense
        {
            Name = JsxConstants.AppCards.AppSwaggerCards.JsxAngular.License.Mit.Name,
            Url = new Uri(JsxConstants.AppCards.AppSwaggerCards.JsxAngular.License.Mit.Url)
        }
        
    });

});

var app = builder.Build();

app.UseDefaultFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

    // Original out-of-the-box Swagger settings
    // app.UseSwagger();
    // app.UseSwaggerUI();

    // Modified Swagger settings for custom jSX Web API Demos
    app.UseSwagger(options =>
    {
        options.SerializeAsV2 = true;
    });

    app.UseSwaggerUI(options => // UseSwaggerUI is called only in Development.
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", JsxConstants.AppCards.AppSwaggerCards.JsxAngular.SwagDoc.SwagVersion);
        // This next line is recommended, but actually produces a white, blank page
        // options.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
