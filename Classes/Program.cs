using System;

namespace Classes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Düzce";
            customer.Id = 1;
            customer.FirstName = "Sevgi";
            customer.LastName = "Atasever";
 
            Customer customer2 = new Customer
            {
                Id = 2, City = "Düzce", FirstName = "Neslihan", LastName = "Atasever"
            };
            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
    }
}