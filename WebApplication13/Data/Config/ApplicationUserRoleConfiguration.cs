using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication13.Data.Config
{
    public class ApplicationUserRoleConfiguration : IEntityTypeConfiguration<ApplicationUserRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserRole> builder)
        {
            builder.HasKey(r => r.Id);

            builder.ToTable("UserRoles");
        }
    }
}
