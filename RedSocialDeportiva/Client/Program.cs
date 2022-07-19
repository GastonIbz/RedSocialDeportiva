/* Importo los modelos de manera global*/
//global using RedSocialDeportiva.Client.Pages.LoginAndRegister.Models; /* No me tomaba todas las clases */
global using System.Text.RegularExpressions;
/* Importo los modelos de manera global*/

using RedSocialDeportiva.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
