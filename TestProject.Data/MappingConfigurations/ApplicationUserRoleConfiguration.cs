using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration;

namespace TestProject.Data.MappingConfigurations
{
    public class ApplicationUserRoleConfiguration : EntityTypeConfiguration<IdentityUserRole>
    {
        public ApplicationUserRoleConfiguration()
        {
            HasKey(r => new { r.RoleId, r.UserId });
        }
    }
}
