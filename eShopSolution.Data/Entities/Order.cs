using eShopSolution.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string ShipName { get; set; }
        public string ShipPhoneNumber { get; set; }
        public string Address { get; set; }
        public string ShipEmail { get; set; }
        public OrderStatus Status { get; set; }
    }
}
