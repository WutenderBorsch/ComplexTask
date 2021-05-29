using System;
using System.Collections.Generic;

#nullable disable

namespace Web
{
    public partial class Basket
    {
        public int Id { get; set; }
        public int IdOrder { get; set; }
        public int IdProduct { get; set; }
        public int IdClient { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual Order IdOrderNavigation { get; set; }
        public virtual Product IdProductNavigation { get; set; }
    }
}
