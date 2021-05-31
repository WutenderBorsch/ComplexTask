﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web
{
    public partial class Order
    {
        public Order()
        {
            Baskets = new HashSet<Basket1>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal CostOrder { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
        public int IdDeliveryType { get; set; }
        public string IdUser { get; set; }

        public virtual DeliveryType IdDeliveryTypeNavigation { get; set; }
        public virtual ICollection<Basket1> Baskets { get; set; }
    }
}
