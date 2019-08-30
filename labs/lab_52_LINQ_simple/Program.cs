using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_52_LINQ_simple
{
    class Program
    {
        static List<Customer> customers;
       

        static void Main(string[] args)
        {


            using (var db = new NorthwindEntities()) {

                Console.WriteLine("\n\nSelect Customers And Their Orders\n\n");
                var output6 = 
                    from customer in db.Customers
                    join order in db.Orders 
                    on customer.CustomerID equals order.CustomerID
                    select new 
                    {
                        Name = customer.ContactName,
                        OrderID = order.OrderID,
                        OrderDate = order.OrderDate
                    };
                output6.ToList().ForEach(c => Console.WriteLine($"{c.Name,-25}{c.OrderID,-15}" +
                    $"{c.OrderDate}"));
            }
        }

        static void PrintCustomers(List<Customer> customers)
        {
            foreach(var c in customers)
            {
                Console.WriteLine($"{c.CustomerID,-10}{c.ContactName,-30}{c.City}");
            }
        }
    }
}
