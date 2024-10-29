using Microsoft.EntityFrameworkCore;
using PizzeriaApp.Data;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PizzeriaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PizzeriaContext")));
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<PizzeriaContext>();
// abilitare le pagine di autenticazione di Identity
builder.Services.AddRazorPages(); 
// Add services to the container.
builder.Services.AddControllersWithViews();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//  per attivare correttamente le pagine di Identity
app.MapRazorPages();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
