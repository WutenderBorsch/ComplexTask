using System;
using System.Collections.Generic;

#nullable disable

namespace Web
{
    public partial class AdminMain
    {
        public AdminMain()
        {
            Messages = new HashSet<Message>();
        }

        public int Id { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Fio { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
