using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using PlayersDemo.Data;
using PlayersDemo.Services.Holidays;
using PlayersDemo.Services.LocalStorage;
using PlayersDemo.Services.Settings;
using PlayersDemo.Shared;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddDbContextFactory<PlayersDbContext>(
    opt => opt.UseSqlServer(
        "Data Source=(localDb)\\MSSQLLocalDb;Initial Catalog=PlayersManagerDb"));  // appsettings.json

builder.Services.AddScoped<StateManager>();
builder.Services.AddTransient<ILocalStorageService, LocalStorageService>();
builder.Services.AddSingleton<IUserSettingsService, UserSettingsService>();

builder.Services.AddSingleton<IHolidaysApiService, HolidaysApiService>();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
