using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.Name = "Masa";
            product1.Price = 500;
            product1.Stock = 3;

            //parantez yok dikkat, direk köşeli parantez
            Product product2 = new Product {Id=2, CategoryId=5, Stock=5, Name="Kalem",Price=35};
            //yukarıdaki alt alta yazılan, bu şekilde de yazılabilir

            //PascalCase   //camelCase    //case sensitive, büyük küçük harf duyarlılık
            ProductManager productManager = new ProductManager(); //instance creation, örnek oluşturma
            productManager.Add(product1);  //ne ekleyeceğim, parametre ver! class kısmında belirt
                                           //product1 burada değerini bellek adresinden alır yani referans numarası vardır, adresteki değer değişir

            
            //int, double, bool bunlar değer tip - değeri verir işi biter
            //diziler, class, abstract class, interface bunlar referans tip - değer bellekte adreslenir
        }
    }
}
