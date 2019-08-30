using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07_entity_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers;

            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
            }

            foreach(var c in customers)
            {
                Console.WriteLine($"{c.CustomerID,-10}{c.ContactName,-30}{c.City,-20}");
            }
        }
    }
}
