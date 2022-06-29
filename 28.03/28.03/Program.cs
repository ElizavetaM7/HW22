using System;

namespace _28._03
{
    class Program
    {
        static void Main(string[] args)
        {
            var warehause = new Warehause(20);
            var tv = new Product(1, "LG 42''", 48000);
            warehause.Add(tv);

            var freezer = new Product(2, "Stinol 8542", 35000);
            warehause.Add(freezer);

            var oven = new Product(3, "Samsung 2411", 7000);
            warehause.Add(oven);

            foreach (var product in warehause)
                PrintProduct(product);
            Console.ReadKey();
        }
        static void PrintProduct(Product p)
        {
            Console.WriteLine($"{p.Name} Цена {p.Price}");

        }
    }
}
