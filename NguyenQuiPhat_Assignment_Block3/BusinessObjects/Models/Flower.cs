using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects.Models
{
    public partial class Flower
    {
        public Flower()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public Guid CategoryId { get; set; }
        public Guid SupplierId { get; set; }
        public double Discount { get; set; }
        public Guid? ImagaId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Image Imaga { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
