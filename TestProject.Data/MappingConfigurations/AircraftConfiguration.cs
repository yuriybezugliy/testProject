using TestProject.DomainModel.Entities;

namespace TestProject.Data.MappingConfigurations
{
    public class AircraftConfiguration : BaseEntityConfiguration<Aircraft>
    {
        public AircraftConfiguration()
        {
            ToTable(nameof(Aircraft) + "s");
            Property(ac => ac.Model).IsRequired();
        }
    }
}
