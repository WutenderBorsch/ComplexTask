using System;
using System.Collections.Generic;

#nullable disable

namespace Web
{
    public partial class Message
    {
        public int Id { get; set; }
        public int IdAdmin { get; set; }
        public int IdMaster { get; set; }
        public string Theme { get; set; }
        public DateTime DateTime { get; set; }
        public string Content { get; set; }

        public virtual AdminMain IdAdminNavigation { get; set; }
        public virtual Master IdMasterNavigation { get; set; }
    }
}
