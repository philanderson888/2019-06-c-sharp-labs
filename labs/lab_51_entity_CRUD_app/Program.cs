using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectDumper;

namespace lab_51_entity_CRUD_app
{
    class Program
    {

        static List<Customer> customers;
        static Customer customer;
        static Customer customerUpdate;
        

        static void Main(string[] args)
        {
            using (var db=new NorthwindEntities())
            {
                customers = db.Customers.ToList();
               
            }

            foreach(var c in customers)
            {
                Console.WriteLine($"{c.CustomerID,-10}{c.ContactName,-20}{c.CompanyName,-30}{c.City,-20}{c.Country} ");

            }


            Console.WriteLine("\n\nAdding New Customer\n================\n\n");


            // new customer
            var newCustomer1 = new Customer()
            {
                ContactName = "phil anderson",
                CompanyName = "Sparta",
                ContactTitle = "Sir",
                CustomerID = "ANDET",
                Country = "Scotland",
                City = "Edinburgh"
            };

            var newCustomer2 = new Customer()
            {
                ContactName = "phil anderson",
                CompanyName = "Sparta",
                ContactTitle = "Sir",
                CustomerID = "ANDEU",
                Country = "Scotland",
                City = "Edinburgh"
            };



            // add to db
            using (var db = new NorthwindEntities())
            {
               // db.Customers.Add(newCustomer1);
               // db.Customers.Add(newCustomer2);
              // int affected =  db.SaveChanges();
                // Console.WriteLine($"added { affected } records");
            }



            Console.WriteLine("\n\nNow update one customer\n\n");

            using (var db = new NorthwindEntities())
            {
                customerUpdate = db.Customers.Find("ANDEU");
                customerUpdate.City = "Madrid";
                int affected = db.SaveChanges();
                Console.WriteLine($"{affected} records updated");
            }
            using (var db = new NorthwindEntities())
            {
                foreach (var c in db.Customers)
                {
                    Console.WriteLine($"{c.CustomerID,-10}{c.ContactName,-20}{c.CompanyName,-30}{c.City,-20}{c.Country} ");
                }
            }




            Console.WriteLine($"\n\nDeleting One Record {customerUpdate.CustomerID}\n\n");

            using(var db = new NorthwindEntities())
            {
                var deleteCustomer = new Customer();
                deleteCustomer = db.Customers.Find("ANDEU");
                db.Customers.Remove(deleteCustomer);
                int affected = db.SaveChanges();
                Console.WriteLine($"{affected} record deleted : {deleteCustomer}");
            }
            


        }
    }
}
