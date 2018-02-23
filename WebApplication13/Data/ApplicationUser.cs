using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace WebApplication13.Data
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<ApplicationUserRole> Roles { get; set; } = new List<ApplicationUserRole>();
    }
}
