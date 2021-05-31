using System;
using System.Collections.Generic;

#nullable disable

namespace Web
{
    public partial class Admin
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
    }
}
