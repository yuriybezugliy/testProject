using System.Collections.Generic;

namespace TestProject.DomainModel.Entities
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
