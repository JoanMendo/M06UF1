using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA1._MO6.UF1
{
    
   

    public class Assignatura
    {
        public int Id { get; set; }
        public String Nom { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int Stock { get; set; }

        public string Pickture { get; set; }

        public string[] Categories { get; set; }

    }
    public class Product2
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int Stock { get; set; }

        public string Pickture { get; set; }

        public Assignatura Assignatura { get; set; }
    }
}
