using System;
using TestProject.DomainModel.Entities.Enums;

namespace TestProject.DomainModel.Entities
{
    public class Passenger : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string DocumentNumber { get; set; }

        public AgeCategory AgeCategory { get; set; }

        public Sex Sex { get; set; }
    }
}
