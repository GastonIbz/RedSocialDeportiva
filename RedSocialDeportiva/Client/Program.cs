
#region Realizo importaciones a nivel global para evitar el using en cada pag
global using RedSocialDeportiva.Shared.DTO_Front.LoginAndRegister; // Voy a poder utilziar todos los DTO de LoginAndRegister dentro del CLiente.
#endregion

using RedSocialDeportiva.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
