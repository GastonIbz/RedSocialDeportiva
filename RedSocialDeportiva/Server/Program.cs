
#region Realizo importaciones a nivel global para evitar el using en cada pag

global using RedSocialDeportiva.Shared.DTO_Back;
global using Microsoft.EntityFrameworkCore;
global using RedSocial.BD.Data;
global using RedSocial.BD.Data.Entidades;

#endregion


using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddSignalR()
    .AddJsonProtocol(options => {
        options.PayloadSerializerOptions.PropertyNamingPolicy = null;
    });
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var conn = builder.Configuration.GetConnectionString("con");

builder.Services.AddDbContext<BDContext>(opciones => opciones.UseSqlServer(conn));



builder.Services.AddSwaggerGen(config =>
{
    config.SwaggerDoc("v1", new OpenApiInfo { 
        Title = "Usuario", Version = "v2",
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(config => {
    config.SwaggerEndpoint(
        "/swagger/v1/swagger.json",
        "Usuario v2");
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
