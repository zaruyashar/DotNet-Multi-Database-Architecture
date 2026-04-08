using DatabaseMastery.TransportMongoDb.Services.HowItWorkServices;
using Microsoft.Extensions.Options;
using System.Reflection;
using TransportationMongoDB.Services.AboutServices;
using TransportationMongoDB.Services.BrandServices;
using TransportationMongoDB.Services.GetInTouchService;
using TransportationMongoDB.Services.OfferServices;
using TransportationMongoDB.Services.SliderServices;
using TransportationMongoDB.Settings;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ISliderService, SliderService>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<IOfferService, OfferService>();
builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<IGetInTouchService, GetInTouchService>();
builder.Services.AddScoped<IHowItWorkService, HowItWorkService>();


builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddMaps(typeof(Program).Assembly);
});


builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));
builder.Services.AddScoped<IDatabaseSettings>(sp =>
{
    return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});


builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
