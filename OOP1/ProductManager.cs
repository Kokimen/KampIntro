using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //bu bir operasyondur, product ile ilgili operasyonları içerir
    {
        public void Add(Product product) //bana bir tane product ver, sen bana bir şey gönder ben onu product ismiyle tutayım
        {
            Console.WriteLine(product.Name+ " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.Name + " güncellendi.");
        }
















        //void anahtar kelimesi ne işe yarar? void olarak belirtilen metotlar emir kipinde git şunu yap demektir
        public int Topla(int sayi1, int sayi2) //topluyor işlemini yapıyor, bu işlem sonucunda toplam kullanılabilir, değer program akışında bana lazım
        {
            return sayi1 + sayi2; //değer program akışında bize tekrardan lazım olacak ise return kullanırız, değeri geri döndürür bir değişken içinde saklar
                                  //ve gerektiği zaman üzerinde başka bir işlem yapabilmek için atama yaptığımız değişkeni kullanabiliriz
        }


        public void Topla2(int sayi1, int sayi2) //topluyor işlemini yapıyor, bu işlem sonucunda toplam kullanılamaz, değer program akışında bana lazım değil
        {
            Console.WriteLine(sayi1+sayi2);
        }

    }
}
