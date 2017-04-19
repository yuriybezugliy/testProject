using TestProject.DomainModel.Entities;

namespace TestProject.Data.MappingConfigurations
{
    public class PassengerConfiguration : BaseEntityConfiguration<Passenger>
    {
        public PassengerConfiguration()
        {
            Property(p => p.FirstName).IsRequired();
            Property(p => p.LastName).IsRequired();
            Property(p => p.DocumentNumber).IsRequired();
        }
    }
}
