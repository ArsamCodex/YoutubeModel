using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using YoutubeModel.Data;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AplcationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AplcationDbContext") ?? throw new InvalidOperationException("Connection string 'BoxRegistrationSysContext' not found.")));




builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();



builder.Services.AddScoped<IServiceEmployee, ServiceEmployeImp>();

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
