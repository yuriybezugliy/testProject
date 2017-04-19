using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TestProject.DomainModel.Entities;

namespace TestProject.Data.MappingConfigurations
{
    public abstract class BaseEntityConfiguration<TEntityType> : EntityTypeConfiguration<TEntityType> 
        where TEntityType : BaseEntity
    {
        protected BaseEntityConfiguration()
        {
            Property(be => be.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
