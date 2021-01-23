using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Salih";
            customer1.LastName = "Kamaş";
            customer1.TcNo = "11111111111";



            //Corporate
            //Kodlama.io

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.VergiNo = "2222222222";


            Customer customer3 = new IndividualCustomer();
            Customer customer5 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
