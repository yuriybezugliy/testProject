using TestProject.DomainModel.Entities;

namespace TestProject.Data.MappingConfigurations
{
    public class CountryConfiguration : BaseEntityConfiguration<Country>
    {
        public CountryConfiguration()
        {
            Property(country => country.Name).IsRequired();
        }
    }
}
