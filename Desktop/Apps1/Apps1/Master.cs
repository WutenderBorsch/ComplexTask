using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps1
{
    class Master
    {
        public Int32 Id { get; set; }
        public string Nickname { get; set; }

        public override string ToString()
        {
            return $"{Nickname}";
        }
    }
}
