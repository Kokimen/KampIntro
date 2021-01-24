using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Info = "Red";
            product1.Stock = 1000;

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 25;
            product2.Info = "Diyarbakır";
            product2.Stock= 1000;

            Product[] products = new Product[] { product1, product2 };
            //type safe - tip güvenli
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Info);
                Console.WriteLine("---------");
            }

            Console.WriteLine("-----Metodlar-----");

            //instance, örnek
            //encapsulation, her şeyi bir kapsül içerisine almak
            sepetManager sepetmanager = new sepetManager();
            sepetmanager.Add(product1); //metod çağırma
            sepetmanager.Add(product2);
        }
    }
}
