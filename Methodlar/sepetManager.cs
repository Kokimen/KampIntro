using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class sepetManager
    //manager, access, controller vb. şeyler operasyon tutar
    {
        //naming convention, kodun okunabilirliğini artıran yazma teknikleri
        public void Add(Product product) //bir yerde parantez görürsen bil ki bir metod çalışıyor
        {
            Console.WriteLine("Ürününüz Sepete Eklendi : " + product.Name);
            Console.WriteLine("Tahsis Edilecek Tutar : " + product.Price);
            Console.WriteLine("Ürün Bilgisi : " + product.Info);
        }
        
    }
}
