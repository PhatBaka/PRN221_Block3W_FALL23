using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects.Models
{
    public partial class Image
    {
        public Image()
        {
            Accounts = new HashSet<Account>();
            Flowers = new HashSet<Flower>();
        }

        public Guid Id { get; set; }
        public byte[] Data { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Flower> Flowers { get; set; }
    }
}
