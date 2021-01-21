using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not reapeat yourself - kendini tekrarlama
            //değer tutucu, alias

            string kategoriEtiketi = "Kategoriler";
            int ogrSayi = 10;
            double faizOrani = 1.4;
            bool sistemeGiris = true;
            double dolarDun = 7.3;
            double dolarBugun = 7.4;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGiris == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
 