using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerID = 01;
            customer1.CustomerName = "Engin";
            customer1.CustomerSurname = "Demirog";
            customer1.CustomerIban = "00254874";

            Customer customer2 = new Customer();
            customer2.CustomerID = 02;
            customer2.CustomerName = "Gül";
            customer2.CustomerSurname = "Döndü";
            customer2.CustomerIban = "00999874";
            Customer[] customers = new Customer[] { customer1, customer2 };
            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("Menu ");
            int islem=customerManager.Menu();
            
            if (islem==1)
                {
                Console.WriteLine("Müşteri Ekleme");
                customerManager.Add(customer1);
                customerManager.Add(customer2);
                }
            else if(islem==2)
            {   
                Console.WriteLine("Müşteri Listeleme");
                customerManager.List(customer1);
                customerManager.List(customer2);
            }

            else
            {
                Console.WriteLine("Müşteri Silme");
                customerManager.Delete(customer1);
                customerManager.Delete(customer2);
            }

        }
    }
}
