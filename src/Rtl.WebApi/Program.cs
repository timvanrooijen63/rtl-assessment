using Microsoft.Extensions.Configuration;
using Rtl.WebApi.Models.Configuration;
using Rtl.WebApi.Services;
using Serilog;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//LoadSettings
var settings = builder.Configuration.GetSection("Settings").Get<Settings>();
builder.Services.AddSingleton(settings);

//Add logging services
var logger = new LoggerConfiguration()
  .ReadFrom.Configuration(builder.Configuration)
  .Enrich.FromLogContext()
  .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

//
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var elasticClientSettings = new Nest.ConnectionSettings(new Uri(settings.ElasticConnection))
    .DefaultFieldNameInferrer(p => p);

elasticClientSettings.EnableDebugMode();
elasticClientSettings.DisableDirectStreaming();
elasticClientSettings.EnableDebugMode();


builder.Services.AddTransient(x => new Nest.ElasticClient(elasticClientSettings));

builder.Services.AddTransient<IShowService, ShowService>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly(), Assembly.GetAssembly(typeof(IShowService)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
