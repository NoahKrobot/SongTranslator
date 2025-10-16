using SongTranslator.Components;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Microsoft.AspNetCore.DataProtection.KeyManagement;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//var youtubeConfiguration = builder.Configuration.Get("YouTube"); 
var youtubeConfiguration = builder.Configuration.GetSection("YouTube");
var apiKey = youtubeConfiguration["ApiKey"];
var appName = youtubeConfiguration["ApplicationName"];

builder.Services.AddRazorPages();
//private readonly IConfiguration Configuration;
//var apiKey = Configuration["YouTube:ApiKey"];

builder.Services.AddSingleton(new YouTubeService(new BaseClientService.Initializer()
{
    ApiKey = apiKey,
    ApplicationName = appName,
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
