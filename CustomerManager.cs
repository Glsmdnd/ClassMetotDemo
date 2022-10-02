using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        public int Menu()
        {
            Console.WriteLine("[1] Ekleme");
            Console.WriteLine("[2] Listeleme");
            Console.WriteLine("[3] Silme ");
            int islem = Convert.ToInt16(Console.ReadLine());
            return islem;
        }
        public void Add(Customer customer)
        {
            Console.WriteLine("Tebrikler, Yeni Müşterimiz: " +customer.CustomerName+ " Eklendi");
        }
        public void List(Customer customer)
        {
            Console.WriteLine("-----------");
            
            //Customer[] customers = new Customer[] { customer1, customer2 };
            //foreach (Customer customer in customers)
            {
                Console.WriteLine("Müsteri ID:" + customer.CustomerID);
                Console.WriteLine("Müsteri Adi:" + customer.CustomerName);
                Console.WriteLine("Müsteri Soyadi:" + customer.CustomerSurname);
                Console.WriteLine("Musteri Iban:" + customer.CustomerIban);
                Console.WriteLine("*");
            }
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("-----------");
           
            Console.WriteLine("Tebrikler, Müşterimiz: " + customer.CustomerName + " Silindi");
            Console.WriteLine("*");
        }
    }
}
