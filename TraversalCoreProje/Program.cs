using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Serilog;
using Serilog.Core;
using Traversal.Business.Container;
using Traversal.DataAccess.Concrete;
using Traversal.Entities.Concrete;
using TraversalCoreProje.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProje.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<GetAllDestinationQueryHandler>();

Logger log = new LoggerConfiguration()
             .MinimumLevel.Information()
             .WriteTo.Seq("http://localhost:5341/")
             .Enrich.FromLogContext()
             .CreateLogger();

builder.Host.UseSerilog(log);

builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>()
       .AddEntityFrameworkStores<Context>()
       .AddErrorDescriber<CustomIdentityValidator>();

builder.Services.AddHttpClient();

builder.Services.AddControllersWithViews();

builder.Services.ContainerDependencies();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.CustomValidator();

builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
                 .RequireAuthenticatedUser()
                 .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();