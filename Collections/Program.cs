using System;
using System.Collections.Generic; //List sınıfını çalıştırabilmek için tepeye "using System.Collections.Generic" eklenmelidir

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //[] arrayler oluşturulan sınırlar içerisinde çalışır, 4 eleman varsa 5 eleman yazdıramazsın ya da 5. elemanı ekleyemezsin, dizileri genişletemiyoruz   
            //koleksiyonlar arraylerden farklı olarak değerlerini kaybetmezler, sınırları yoktur

            List<string> isimler = new List<string> { "engin", "murat", "kerem", "halil" }; 
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler.Add("ilker");
            Console.WriteLine(isimler[4]);
            
        }

    }
}
