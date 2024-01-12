using BusinessLayer.Abstract;
using BusinessLayer.Concreate;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Traversal.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Authorize iþlemleri 
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<Context>();

builder.Services.AddScoped<ICommentService, CommentManager>();
builder.Services.AddScoped<ICommentDal, EfCommentDal>();

builder.Services.AddScoped<IDestinationService, DestinationManager>();
builder.Services.AddScoped<IDestinationDal, EfDestinationDal>();

builder.Services.AddScoped<IAppUserService, AppUserManager>();
builder.Services.AddScoped<IAppUserDal, EfAppUserDal>();

builder.Services.AddScoped<IReservationService, ReservationManager>();
builder.Services.AddScoped<IReservationDal, EfReservationDal>();

builder.Services.AddScoped<IGuideService, GuideManager>();
builder.Services.AddScoped<IGuideDal, EfGuideDal>();

builder.Services.AddScoped<IContactUsService, ContactUsManager>();
builder.Services.AddScoped<IContactUsDal, EfContactUsDal>();


builder.Services.AddLogging(x =>
{
    x.ClearProviders();
    x.SetMinimumLevel(LogLevel.Debug);
    x.AddDebug();
});

builder.Services.AddMvc(Config =>
{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();
    Config.Filters.Add(new AuthorizeFilter(policy));
});
//Authorize iþlemleri Son
builder.Services.AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404","?code={0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");




app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
