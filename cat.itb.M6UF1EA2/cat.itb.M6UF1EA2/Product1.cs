using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cat.itb.M6UF1EA2
{
    public class Product1
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string Picture { get; set; }
        public string[] Categories { get; set; }
    }
    public class Product2
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string Picture { get; set; }
        public Categoria[] Categories { get; set; }
    }
    public class Categoria
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
