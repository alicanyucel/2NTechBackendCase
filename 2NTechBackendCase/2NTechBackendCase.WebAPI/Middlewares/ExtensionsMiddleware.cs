using _2NTechBackendCase.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace _2NTechBackendCase.WebAPI.Middlewares
{
    public static class ExtensionsMiddleware
    {
        public static void CreateFirstUser(WebApplication app)
        {
            using (var scoped = app.Services.CreateScope())
            {
                var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

                if (!userManager.Users.Any(p => p.UserName == "admin"))
                {
                    AppUser user = new()
                    {
                        UserName = "admin",
                        Email = "admin@admin.com",
                        FirstName = "Ali Can",
                        LastName = "YÜcel",
                        EmailConfirmed = true
                    };
                    // token almak için auth contreller swaggerdan calıştırarak username="admin" password=1 yazmanız yeterli olacaktır

                    userManager.CreateAsync(user, "1").Wait();
                }
            }
        }
    }
}
