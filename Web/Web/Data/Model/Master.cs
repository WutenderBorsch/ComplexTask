using System;
using System.Collections.Generic;

#nullable disable

namespace Web
{
    public partial class Master
    {
        public Master()
        {
            Messages = new HashSet<Message>();
            Product1s = new HashSet<Product1>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public long Phone { get; set; }
        public DateTime DateOfReg { get; set; }
        public DateTime DateOdBirth { get; set; }
        public string DescriptionOfActivities { get; set; }
        public string Nickname { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Product1> Product1s { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
