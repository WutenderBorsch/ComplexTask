using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps1
{
    class Category
    {
        public Int32 id { get; set; }
        public string categoryname { get; set; }

        public override string ToString()
        {
            return $"{categoryname}";
        }
    }
}
