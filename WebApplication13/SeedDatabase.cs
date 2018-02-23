using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using WebApplication13.Constants;
using WebApplication13.Data;

namespace WebApplication13
{
    public static class SeedDatabase
    {
        public static IWebHost SeedData(this IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var context = services.GetRequiredService<ApplicationDbContext>();
                context.Database.EnsureCreated();
                if (!context.Roles.Any())
                {
                    context.Roles.Add(new ApplicationRole { Id = RoleIds.Admin, Name = "Admin", NormalizedName = "ADMIN" });
                    context.Roles.Add(new ApplicationRole { Id = RoleIds.NormalUser, Name = "Normal User", NormalizedName = "NORMAL USER" });
                    context.SaveChanges();
                }

                return host;
            }
        }

    }
}
