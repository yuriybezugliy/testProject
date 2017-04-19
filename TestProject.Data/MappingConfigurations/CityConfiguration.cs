using TestProject.DomainModel.Entities;

namespace TestProject.Data.MappingConfigurations
{
    public class CityConfiguration : BaseEntityConfiguration<City>
    {
        public CityConfiguration()
        {
            Property(city => city.Name).IsRequired();

            HasRequired(city => city.Country).WithMany(country => country.Cities).WillCascadeOnDelete(false);
        }
    }
}
