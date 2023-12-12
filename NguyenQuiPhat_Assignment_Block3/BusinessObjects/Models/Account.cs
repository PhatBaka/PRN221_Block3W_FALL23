using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects.Models
{
    public partial class Account
    {
        public Account()
        {
            OrderCustomers = new HashSet<Order>();
            OrderStaffs = new HashSet<Order>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public Guid RoleId { get; set; }
        public Guid? ImageId { get; set; }

        public virtual Image Image { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Order> OrderCustomers { get; set; }
        public virtual ICollection<Order> OrderStaffs { get; set; }
    }
}
