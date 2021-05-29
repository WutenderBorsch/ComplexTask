using System;
using System.Collections.Generic;

#nullable disable

namespace Web
{
    public partial class Category
    {
        public Category()
        {
            Product1s = new HashSet<Product1>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Categoryname { get; set; }

        public virtual ICollection<Product1> Product1s { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
