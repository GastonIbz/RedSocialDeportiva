
#region Realizo importaciones a nivel global para evitar el using en cada pag

global using RedSocialDeportiva.Shared.DTO_Front.LoginAndRegister; // Voy a poder utilziar todos los DTO de LoginAndRegister dentro del CLiente.
global using RedSocialDeportiva.Client.Pages.LoginAndRegister; // Accedemos al Store que tiene dicha pag.

#endregion

using RedSocialDeportiva.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<LoginAndRegisterStore>();

await builder.Build().RunAsync();
