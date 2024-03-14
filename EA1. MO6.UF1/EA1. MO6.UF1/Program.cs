using System;
using EA1._MO6.UF1;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EA1.MO6.UF1
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.
            string path = @"D:\C#\EA1_test\FitxersJSON\FitxersJSON\products1.json";
            using (StreamReader jsonStream = File.OpenText(path))
            {
                string line;
                while ((line = jsonStream.ReadLine()) != null)
                {
                    Product product = JsonConvert.DeserializeObject<Product>(line);
                    string json = JsonConvert.SerializeObject(product);
                    Console.WriteLine(json);
                }              
            }

            //3. 

            Product product1 = new Product
            {
                Name = "Producte1",
                Price = 10,
                Stock = 100,
                Pickture = "producte1.jpg",
                Categories = new string[] { "categoria1", "categoria2" }
            };
            Product product2 = new Product
            {
                Name = "Producte2",
                Price = 20,
                Stock = 200,
                Pickture = "producte2.jpg",
                Categories = new string[] { "categoria1", "categoria3" }
            };
            Product product3 = new Product
            {
                Name = "Producte3",
                Price = 30,
                Stock = 300,
                Pickture = "producte3.jpg",
                Categories = new string[] { "categoria2", "categoria3" }
            };
            Product product4 = new Product
            {
                Name = "Producte4",
                Price = 40,
                Stock = 400,
                Pickture = "producte4.jpg",
                Categories = new string[] { "categoria1", "categoria2", "categoria3" }
            };
            Product product5 = new Product
            {
                Name = "Producte5",
                Price = 50,
                Stock = 500,
                Pickture = "producte5.jpg",
                Categories = new string[] { "categoria1", "categoria2", "categoria3" }
            };
            Product[] products = new Product[] { product1, product2, product3, product4, product5 };
            using (StreamWriter si = new StreamWriter(path, true))

            {
                for (int i = 0; i < products.Length; i++)
                {
                    string json = JsonConvert.SerializeObject(products[i]);
                    si.WriteLine(json);

                }
            }

            //2.
            string path2 = @"D:\C#\EA1_test\FitxersJSON\FitxersJSON\products2.json";
            using (StreamReader jsonStream = File.OpenText(path))
            {
                string line;
                while ((line = jsonStream.ReadLine()) != null)
                {
                    Product product = JsonConvert.DeserializeObject<Product>(line);
                    string json = JsonConvert.SerializeObject(product);
                    Console.WriteLine(json);
                }
            }

            //3. 

            Product2 product6 = new Product2
            {
                Name = "Producte1",
                Price = 10,
                Stock = 100,
                Pickture = "producte1.jpg",
                Assignatura = new Assignatura { Id = 1, Nom = "categoria1" }
            };
            Product2 product7 = new Product2
            {
                Name = "Producte2",
                Price = 20,
                Stock = 200,
                Pickture = "producte2.jpg",
                Assignatura = new Assignatura { Id = 2, Nom = "categoria2" }
            };
            Product2 product8 = new Product2
            {
                Name = "Producte3",
                Price = 30,
                Stock = 300,
                Pickture = "producte3.jpg",
                Assignatura = new Assignatura { Id = 3, Nom = "categoria3" }
            };
            Product2 product9 = new Product2
            {
                Name = "Producte4",
                Price = 40,
                Stock = 400,
                Pickture = "producte4.jpg",
                Assignatura = new Assignatura { Id = 4, Nom = "categoria4" }
            };
            Product2 product10 = new Product2
            {
                Name = "Producte5",
                Price = 50,
                Stock = 500,
                Pickture = "producte5.jpg",
                Assignatura = new Assignatura { Id = 5, Nom = "categoria5" }
            };
            Product[] products2 = new Product[] { product1, product2, product3, product4, product5 };
            using (StreamWriter si = new StreamWriter(path2, true))

            {
                for (int i = 0; i < products2.Length; i++)
                {
                    string json = JsonConvert.SerializeObject(products2[i]);
                    si.WriteLine(json);

                }
            }
        }
    }
}

