using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Razor;
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
builder.Services.AddScoped<GetDestinationByIdQueryHandler>();
builder.Services.AddScoped<CreateDestinationCommandHandler>();
builder.Services.AddScoped<RemoveDestinationCommandHandler>();
builder.Services.AddScoped<UpdateDestinationCommandHandler>();

builder.Services.AddMediatR(typeof(Program));

Logger log = new LoggerConfiguration()
             .MinimumLevel.Information()
             .WriteTo.Seq("http://localhost:5341/")
             .Enrich.FromLogContext()
             .CreateLogger();

builder.Host.UseSerilog(log);

builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>()
       .AddEntityFrameworkStores<Context>()
       .AddErrorDescriber<CustomIdentityValidator>()
       .AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider);

builder.Services.AddHttpClient();

builder.Services.AddControllersWithViews();

builder.Services.ContainerDependencies();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.CustomValidator();

builder.Services.AddLocalization(opt =>
{
    opt.ResourcesPath = "Resources";
});

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[] { "tr", "en", "fr" };
    options.SetDefaultCulture(supportedCultures[0]);
    options.AddSupportedCultures(supportedCultures);
    options.AddSupportedUICultures(supportedCultures);
});


builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
                 .RequireAuthenticatedUser()
                 .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login/SignIn/";
});

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

//var supportedCultures = new[] { "en", "fr", "es", "gr", "tr", "de" };
//var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(supportedCultures[0]).AddSupportedCultures(supportedCultures).AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

});

app.Run();