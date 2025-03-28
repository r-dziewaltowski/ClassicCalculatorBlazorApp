using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ClassicCalculatorBlazorApp;
using ClassicCalculator;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Logging.AddConfiguration(builder.Configuration.GetSection("Logging"));

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<ICalculator>(sp =>
{
    var logger = sp.GetRequiredService<ILogger<Calculator>>();
    return new Calculator(displayLength: 14, logger);
});

var host = builder.Build();

var logger = host.Services.GetRequiredService<ILogger<Program>>();
logger.LogInformation("App starting...");

// Global exception handling
AppDomain.CurrentDomain.UnhandledException += (sender, eventArgs) =>
{
    var exception = eventArgs.ExceptionObject as Exception;
    logger.LogError(exception, "Unhandled exception occurred.");
};

await host.RunAsync();
