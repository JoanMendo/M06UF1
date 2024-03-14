using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using cat.itb.M6UF1EA2;
using System.IO;

namespace JoanMendo;


class Program
{
    static void Main(string[] args)
    {
        Product1();
    }

    public static void Product1()
    {
        string path = @"D:\C#\cat.itb.M6UF1EA2\FitxersJSON\FitxersJSON\products1.json";
        string tempPath = Path.GetTempFileName();

        using (StreamWriter w = new StreamWriter(tempPath)) 
        using (StreamReader r = File.OpenText(path))
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Product1 product = JsonConvert.DeserializeObject<Product1>(line);
                if (product.Price > 600) //Exercici 1
                    Console.WriteLine(product.Name);
                
                if (product.Stock > 100) //Exercici 4
                    Console.WriteLine(product.Name +  " Borrat per tenir massa Stock");
                else if (product.Name == "iPhone 8") //Exercici 2
                {
                    product.Categories = new string[] { $"{product.Categories?[0]}", $"{product.Categories?[1]}", "superSmarthphone" };
                    
                    Console.WriteLine($"Categories de {product.Name}:");
                    Console.WriteLine();
                    foreach (string item in product.Categories)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine();
                    string newLine = JsonConvert.SerializeObject(product);
                    w.WriteLine(newLine);                   
                }
                
                else if (product.Name == "MacBook") // Exercici 3
                {
                    product.Stock = 5;
                    string newLine = JsonConvert.SerializeObject(product);
                    w.WriteLine(newLine);
                }
                else
                {
                    w.WriteLine(line);
                }

            }
           

        }
        File.Delete(path);
        File.Move(tempPath, path);


    }

    public static void Product2()
    {
        string path2 = @"D:\C#\cat.itb.M6UF1EA2\FitxersJSON\FitxersJSON\products2.json";
        string tempPath = Path.GetTempFileName();

        using (StreamWriter w = new StreamWriter(tempPath))
        using (StreamReader r = File.OpenText(path2))
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Product2 product = JsonConvert.DeserializeObject<Product2>(line);
                

                if (product.Name == "iPhone 8") //Exercici 5
                {
                    product.Categories = new Categoria[] { $"{product.Categories}" } ;

      
                    string newLine = JsonConvert.SerializeObject(product);
                    w.WriteLine(newLine);
                }

                

            }


        }
        File.Delete(path2);
        File.Move(tempPath, path2);

    }
}
