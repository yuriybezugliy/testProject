using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration;

namespace TestProject.Data.MappingConfigurations
{
    public class ApplicationUserLoginConfiguration : EntityTypeConfiguration<IdentityUserLogin>
    {
        public ApplicationUserLoginConfiguration()
        {
            HasKey(l => l.UserId);
        }
    }
}
