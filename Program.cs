using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MVC1.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton(typeof(ProductService), typeof(ProductService));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.Configure<RazorViewEngineOptions>(Options =>
{

    //{0} ten action
    //{1} ten controller
    //{2} -> ten Area
    // Myview/Controller/Action.cshtml
    Options.ViewLocationFormats.Add("MyView/{1}/{0}" + RazorViewEngine.ViewExtension);

});

//builder.Services.AddSingleton(typeof(ProductService));
//builder.Services.AddSingleton<ProductService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
