using System.Linq;
using System.Threading.Tasks;
using Core.Enums;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedDefaultUserAsync(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            var defaultRoles = new[] {Roles.User, Roles.ShopAdministrator, Roles.SystemAdministrator};

            if (!roleManager.Roles.Any())
            {
                foreach (var role in defaultRoles)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            var administrator = new ApplicationUser {UserName = "system@localhost", Email = "system@localhost"};
            var shopAdministrator = new ApplicationUser {UserName = "shopAdmin@localhost", Email = "shopAdmin@localhost"};
            var user = new ApplicationUser {UserName = "user@localhost", Email = "user@localhost"};

            if (userManager.Users.All(u => u.UserName != administrator.UserName))
            {
                await userManager.CreateAsync(administrator, "Password1");
                await userManager.AddToRolesAsync(administrator, new[] {Roles.SystemAdministrator});
            }
            
            if (userManager.Users.All(u => u.UserName != shopAdministrator.UserName))
            {
                await userManager.CreateAsync(shopAdministrator, "Password1");
                await userManager.AddToRolesAsync(shopAdministrator, new[] {Roles.ShopAdministrator});
            }
            
            if (userManager.Users.All(u => u.UserName != user.UserName))
            {
                await userManager.CreateAsync(user, "Password1");
                await userManager.AddToRolesAsync(user, new[] {Roles.User});
            }
        }
    }
}