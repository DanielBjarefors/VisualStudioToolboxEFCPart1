using System;
using System.Collections.Generic;

namespace VisualStudioToolboxEFCPart1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public int CustomerId { get; set; }
       
        public Customer Customer { get; set; }
        public ICollection<ProductionOrder> ProductionOrders { get; set; }

    }
}