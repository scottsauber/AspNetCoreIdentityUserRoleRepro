using Microsoft.AspNetCore.Identity;

namespace WebApplication13.Data
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public long Id { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
