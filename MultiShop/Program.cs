using Microsoft.EntityFrameworkCore;
using MultiShop.DAL;

namespace MultiShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("default")));
            var app = builder.Build();


            app.UseStaticFiles();
            app.UseRouting();

            app.MapControllerRoute(
                           name: "areas",
                           pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                         );

            app.MapControllerRoute(
                "default",
                "{Controller=Home}/{Action=Index}/{id?}"
                );


            app.Run();
        }
    }
}