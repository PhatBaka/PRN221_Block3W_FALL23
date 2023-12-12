using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects.Models
{
    public partial class Category
    {
        public Category()
        {
            Flowers = new HashSet<Flower>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Flower> Flowers { get; set; }
    }
}
