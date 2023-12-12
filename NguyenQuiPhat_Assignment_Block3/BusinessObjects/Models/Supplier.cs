using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Flowers = new HashSet<Flower>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Flower> Flowers { get; set; }
    }
}
