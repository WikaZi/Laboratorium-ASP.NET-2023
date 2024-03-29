using Laboratorium_3___App.Models;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Data;

namespace Laboratorium_3___App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
                        var connectionString = builder.Configuration.GetConnectionString("AppDbCConnection") ?? throw new InvalidOperationException("Connection string 'AppDbCConnection' not found.");

            // Add services to the container.

            builder.Services.AddDbContext<Data.AppDbContext>();
            builder.Services.AddSingleton<IContactService, MemoryContactService>();
            builder.Services.AddSingleton<IDateTimeProvider, CurrentDateTimeProviderServices>();
            builder.Services.AddSingleton<IComputerService, MemoryComputerService>();
           


            //builder.Services.AddDefaultIdentity<IdentityUser>()
            //    .AddRoles<IdentityRole>()
            //    .AddEntityFrameworkStores<AppDbContext>();
            builder.Services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AppDbC>();

            builder.Services.AddRazorPages();
            builder.Services.AddSession();
            builder.Services.AddControllersWithViews();
            builder.Services.AddTransient<IContactService, EFContactService>();
            builder.Services.AddDbContext<Data.AppDbContext>();
            builder.Services.AddDbContext<Data.AppDbC>();
            builder.Services.AddTransient<IComputerService, EFComputerService>();
            //builder.Services.AddTransient<ISoftwareService, EFSoftwareService>();
            builder.Services.AddMemoryCache();




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
            app.UseMiddleware<LastVisitCookie>();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();
            app.MapRazorPages();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}