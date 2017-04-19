using System;
using TestProject.DomainModel.Entities;

namespace TestProject.Data.MappingConfigurations
{
    public class OrderConfiguration : BaseEntityConfiguration<Order>
    {
        public OrderConfiguration()
        {
            HasMany(order => order.Tickets).WithRequired(ticket => ticket.Order).WillCascadeOnDelete(true);
            HasRequired(order => order.User).WithMany(user => user.Orders);
        }
    }
}
