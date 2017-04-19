using System.Data.Entity.ModelConfiguration;
using TestProject.DomainModel.Entities.Identity;

namespace TestProject.Data.MappingConfigurations
{
    public class ApplicationRoleConfiguration : EntityTypeConfiguration<ApplicationRole>
    {
        public ApplicationRoleConfiguration()
        {
            Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("ApplicationRoles");
            });
            HasKey(r => r.Id);
        }
    }
}
