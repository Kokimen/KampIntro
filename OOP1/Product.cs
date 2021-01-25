using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{ //bir kodun altında "...." varsa ve kare bir kutu içerisinde ise bu snippet bir koddur, hazır kodlar demektir tab-tab yapılabilir
    class Product
    { //kodların okunulabilirliği için özellik sıralamasına dikkat et
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        //CRUD - Create, Read, Update, Delete
    }
}
