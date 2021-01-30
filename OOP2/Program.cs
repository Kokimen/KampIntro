using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 1;
            customer1.No = "12345";
            customer1.Name = "Engin";
            customer1.SurName = "Demiroğ";
            customer1.TcNo = "123456789";


            //Kodlama.IO
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.No = "54321";
            customer2.CompanyName = "Kodlama.IO";
            customer2.FeeNo = "1234567890";

            Customer customer3 = new RealCustomer(); //inheritance'dan dolayı tüm classları tutabiliyor
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
