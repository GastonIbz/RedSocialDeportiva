
#region Realizo importaciones a nivel global para evitar el using en cada pag

// DTO's
global using RedSocialDeportiva.Shared.DTO_Front.LoginAndRegister; // Voy a poder utilziar todos los DTO de LoginAndRegister dentro del CLiente.
global using RedSocialDeportiva.Shared.DTO_Back.User;

// Models
global using RedSocialDeportiva.Client.Pages.LoginAndRegister.Models;

// Services
global using RedSocialDeportiva.Client.Pages.LoginAndRegister.Services;
global using RedSocialDeportiva.Client.Utils.ConsoleJS;

// Store's
global using RedSocialDeportiva.Client.Pages.LoginAndRegister; // Accedemos al Store que tiene dicha pag.


#endregion

using RedSocialDeportiva.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

#region Servicios agregados

builder.Services.AddScoped<LoginAndRegisterStore>();
builder.Services.AddScoped<ConsoleJS>();
builder.Services.AddScoped<UserService>();

#endregion

await builder.Build().RunAsync();
