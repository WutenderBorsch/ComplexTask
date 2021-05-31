using System;
using System.Collections.Generic;

#nullable disable

namespace Web
{
    public partial class Client
    {
        public int Id { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public long Phone { get; set; }
        public DateTime DateOfReg { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
