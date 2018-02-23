using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using WebApplication13.Constants;
using WebApplication13.Data;

namespace WebApplication13.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public IndexModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task OnGetAsync()
        {
            if (User.Identity.Name != null)
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);

                var role1 = new ApplicationUserRole
                {
                    CompanyId = 1,
                    RoleId = RoleIds.Admin,
                    UserId = user.Id
                };
                _context.Add(role1);

                var role2 = new ApplicationUserRole
                {
                    CompanyId = 2,
                    RoleId = RoleIds.Admin,
                    UserId = user.Id
                };
                _context.Add(role2);
                await _context.SaveChangesAsync();
            }
        }
    }
}
