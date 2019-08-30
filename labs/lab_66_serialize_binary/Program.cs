using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace lab_66_serialize_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var c01 = new Customer(01, "fred", "4 the high st", "NT213B57");
            var c02 = new Customer(02, "bob", "5 the high st", "NT213B57");
            var c03 = new Customer(03, "pat", "6 the high st", "NT213B57");
            var customers = new List<Customer>() { c01, c02, c03 };

            // performs the serialization
            var binaryformatter = new BinaryFormatter();

            // stream serialized data - to a File in this case but could be web or RAM (Memory)
            using (var binarystream = new FileStream("data.bin",FileMode.Create,FileAccess.Write,
                FileShare.None))
            {
                // write data to file
                binaryformatter.Serialize(binarystream, customers);
            }

            Console.WriteLine(File.ReadAllText("data.bin"));


            // send data across world and de-serialize at the other end
            var customersFromBinary = new List<Customer>();
            using (var reader = File.OpenRead("data.bin"))
            {
                customersFromBinary = binaryformatter.Deserialize(reader) as List<Customer>;
            }

            // iterate and print out
            foreach (var c in customersFromBinary)
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
