using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Coursework2.Client;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor;



Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTU0MDA2QDMxMzkyZTM0MmUzMGowMmJRb0hsbnpERHE0ZTZ0eDI2OStVdllFRDRZWUFCalFLTGNvWHd5eU09");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
//builder.Services.AddRazorPages();
//builder.Services.AddServerSideBlazor();

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddSyncfusionBlazor();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

