
#region Realizo importaciones a nivel global para evitar el using en cada pag

// DTO's
global using RedSocialDeportiva.Shared.DTO_Front.LoginAndRegister; // Voy a poder utilziar todos los DTO de LoginAndRegister dentro del CLiente.
global using RedSocialDeportiva.Shared.DTO_Back.User;

// Models
global using RedSocialDeportiva.Client.Models;

// Services
global using RedSocialDeportiva.Client.Pages.LoginAndRegister.Services;

// Utils
global using RedSocialDeportiva.Client.Utils.ConsoleJS;

// Store's
global using RedSocialDeportiva.Client.StoreGlobal;
global using RedSocialDeportiva.Client.Pages.LoginAndRegister.Store; // Accedemos al Store que tiene dicha pag.

// Adapters
global using RedSocialDeportiva.Client.Pages.LoginAndRegister.Adapters;

#endregion

using RedSocialDeportiva.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

#region Servicios agregados

// Store's
builder.Services.AddScoped<Store>();
builder.Services.AddScoped<LoginAndRegisterStore>();

// Services
builder.Services.AddScoped<LoginAndRegisterService>();

// Utils
builder.Services.AddScoped<ConsoleJS>();

// Adapters
builder.Services.AddScoped<UserAdapter>();

#endregion

await builder.Build().RunAsync();
