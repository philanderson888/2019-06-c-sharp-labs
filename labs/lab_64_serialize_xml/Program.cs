using System;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace lab_64_serialize_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            var c01 = new Customer(01, "fred", "3 the high st", "NT213B57");

            // XML Serialise into FILE STREAM 
            var formatter = new SoapFormatter();

            using (var filestream = new FileStream("data.xml",FileMode.Create,
                FileAccess.Write,FileShare.None))
            {
                // send data to file stream
                formatter.Serialize(filestream, c01);
            }

            Console.WriteLine(File.ReadAllText("data.xml"));


            // imagine on another computer : can we reconstruct instance???

            Customer customerFromXML;

            using (var streamreader = File.OpenRead("data.xml"))
            {
                // deserialize back into instance of class
                customerFromXML = formatter.Deserialize(streamreader) as Customer;
            }


            Console.WriteLine($"Reconstructed customer : {customerFromXML.CustomerID}" +
                $"{customerFromXML.CustomerName}{customerFromXML.Address}");
            Console.WriteLine($"NINO is blank !!! {customerFromXML.GetNINO()}");



            
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
