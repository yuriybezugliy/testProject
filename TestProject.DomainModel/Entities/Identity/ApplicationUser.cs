using System;
using System.Collections.Generic;
using TestProject.DomainModel.Entities.Enums;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TestProject.DomainModel.Entities.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Sex? Sex { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
