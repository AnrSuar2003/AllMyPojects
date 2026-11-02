using BlazorAppAi.Components;
using BlazorAppAi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.AI;
using OllamaSharp;
using System;

var builder = WebApplication.CreateBuilder(args);


var httpClient = new HttpClient
{
    Timeout = TimeSpan.FromMinutes(2) // 120 segundos
};

// Add services to the container
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Ollama chat client
IChatClient chatClient = new OllamaApiClient(
    new Uri("http://localhost:11434"), // URL local de Ollama
    "phi3:mini"                        // Modelo que quieres usar
);

builder.Services.AddChatClient(chatClient)
       .UseFunctionInvocation()
       .UseLogging();


builder.Services.AddDbContext<DbContextPost>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
