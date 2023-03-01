using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using Projekt.Models;
using Projekt.Repositories.Absract;
using Projekt.Repositories.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<AppDbContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();


builder.Services.ConfigureApplicationCookie(options => options.LoginPath = "/UserAuthentication/Login");

builder.Services.AddScoped<IUserAuthenticationService, UserAuthenticationService>();

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

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

app.MapControllerRoute("MovieDetails", "{controller=MovieDetails}/{action=Index}/{movieId?}");
app.MapControllerRoute("MovieTickets", "{controller=Tickets}/{action=SelectTickets}/{screenTimeId?}/{movieId?}");
app.MapControllerRoute("BuyTickets", "{controller=Tickets}/{action=BuyTickets}/{selectedSeats?}/{userEmail?}/{movieName?}/{screenDateTime?}");
app.MapControllerRoute("RegistrationForm", "{controller=UserAuthentication}/{action=RegisterForm}");
app.MapControllerRoute("CancelReservation", "{controller=Tickets}/{action=CancelReservation}/{UserEmail?}/{ReservationId}");

app.Run();
