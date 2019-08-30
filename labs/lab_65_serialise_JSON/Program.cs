using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace lab_65_serialise_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            var c01 = new Customer(01, "fred", "3 the high st", "NT213B57");
            var c02 = new Customer(01, "fred", "3 the high st", "NT213B57");
            var c03 = new Customer(01, "fred", "3 the high st", "NT213B57");
            var customers = new List<Customer>() { c01, c02, c03 };

            var JSONinstance01 = JsonConvert.SerializeObject(c01);
            File.WriteAllText("data.json", JSONinstance01);

            Console.WriteLine(File.ReadAllText("data.json"));

            var customerListAsJSON = JsonConvert.SerializeObject(customers);
            File.WriteAllText("customers.json", customerListAsJSON);
            Console.WriteLine(File.ReadAllText("customers.json"));

            // send data round world
            // at other end imagine now on different computer
            // read ONE CUSTOMER

            var customerFromJson =
                    JsonConvert.DeserializeObject<Customer>(File.ReadAllText("data.json"));

            Console.WriteLine($"Reconstructed customer : {customerFromJson.CustomerID}" +
                 $"{customerFromJson.CustomerName}{customerFromJson.Address}");
            Console.WriteLine($"NINO is blank !!! {customerFromJson.GetNINO()}");


            Console.WriteLine("\n\n== READ ARRAY OF CUSTOMERS ==\n\n");
            var customerArray =
                JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("customers.json"));
            foreach (var c in customerArray)
            {
                Console.WriteLine($"Reconstructed customer : {c.CustomerID}" +
                                  $"{c.CustomerName}{c.Address}");
            }

        }

    }

    [Serializable]
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public string Address { get; set; }

        [NonSerialized]
        private string NINO;

        // constructor
        public Customer(int customerid, string name, string address, string nino)
        {
            this.CustomerID = customerid;
            this.CustomerName = name;
            this.Address = address;
            this.NINO = nino;
        }

        // GetNINO(){}
        public string GetNINO()
        {
            return this.NINO;
        }

    }



}
