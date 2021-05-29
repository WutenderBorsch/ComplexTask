using System;
using System.Collections.Generic;

#nullable disable

namespace Web
{
    public partial class Client
    {
        public Client()
        {
            Baskets = new HashSet<Basket>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Phone { get; set; }
        public DateTime DateOfReg { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
