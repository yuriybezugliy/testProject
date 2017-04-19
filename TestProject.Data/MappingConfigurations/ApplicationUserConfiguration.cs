using System.Data.Entity.ModelConfiguration;
using TestProject.DomainModel.Entities.Identity;

namespace TestProject.Data.MappingConfigurations
{
    public class ApplicationUserConfiguration : EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserConfiguration()
        {
            Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("ApplicationUsers");
            });

            Property(u => u.FirstName).IsRequired();
            Property(u => u.LastName).IsRequired();
        }
    }
}
