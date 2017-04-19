using System;
using TestProject.DomainModel.Entities;

namespace TestProject.Data.MappingConfigurations
{
    public class AirportConfiguration : BaseEntityConfiguration<Airport>
    {
        public AirportConfiguration()
        {
            Property(ap => ap.Title).IsRequired();
            Property(ap => ap.AirportCodeIata).IsRequired();
            Property(ap => ap.AirportCodeIcao).IsRequired();
            Property(ap => ap.TimeZoneOffset).IsRequired();

            HasMany(ap => ap.Flights).WithRequired(flight => flight.DepartureAirport).WillCascadeOnDelete(false);

            HasRequired(ap => ap.City).WithMany(city => city.Airports).WillCascadeOnDelete(false);
        }
    }
}
