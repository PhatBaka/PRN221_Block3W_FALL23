using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects.Models
{
    public partial class OrderDetail
    {
        public Guid OrderId { get; set; }
        public Guid FlowerId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public decimal? Discount { get; set; }

        public virtual Flower Flower { get; set; }
        public virtual Order Order { get; set; }
    }
}
