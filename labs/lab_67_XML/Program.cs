using System;
using System.Xml.Linq;
using System.IO;
using System.Linq;

namespace lab_67_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nFirst XML Example\n\n");
            var xml01 = new XElement("testData", 1);
            Console.WriteLine(xml01);


            Console.WriteLine("\n\nAdd A Sub-Element\n\n");
            var xml02 = new XElement("XMLRoot",
                    new XElement("XMLData",100)
                );
            Console.WriteLine(xml02);


            Console.WriteLine("\nSave As File\n");
            var xml03 = new XElement("XMLRoot",
                    new XElement("XMLData", 100),
                    new XElement("XMLData", 200),
                    new XElement("XMLData", 300),
                    new XElement("XMLData", 400)
                );
            Console.WriteLine(xml03);

            // write to XML document
            var doc03 = new XDocument(xml03);
            doc03.Save("doc03.xml");

            Console.WriteLine(File.ReadAllText("doc03.xml"));

            // Element is the <TAG>
            // Attribute is VALUE INSIDE TAG
            // <TAG item=500>
            Console.WriteLine("\n04 - Add Attributes\n");
            var xml04 = new XElement("XMLRoot",
                    new XElement("XMLData",new XAttribute("height",300), 100),
                    new XElement("XMLData", new XAttribute("height", 400), 200),
                    new XElement("XMLData", new XAttribute("height", 500), 300),
                    new XElement("XMLData", new XAttribute("height", 600), 400)
                );
            Console.WriteLine(xml04);

            // Think of your data in Database table
            // XMLRoot is name of Table
            // XAttribute is the name of a field with the value
            // XMLData is indivdiual entry in database 



            // XML Revision
            // Create 'Products' root XML
            // Have 2 'Product' items
            // Populate with ProductID, ProductName, CategoryID, UnitPrice
            Console.WriteLine("\n\nProducts\n\n");
            var products = new XElement("Products",
                    new XElement("Product",
                        new XElement("ProductID",01),
                        new XElement("ProductName","cherries"),
                        new XElement("CategoryID",2),
                        new XElement("UnitPrice",10.35)
                    ),
                     new XElement("Product",
                        new XElement("ProductID", 02),
                        new XElement("ProductName", "strawberries"),
                        new XElement("CategoryID", 3),
                        new XElement("UnitPrice", 50.00)
                    )
                );
            Console.WriteLine(products);





            Console.WriteLine("\n\nUsing descendants with elements\n\n");

            var productsXML = products.Descendants("Product").Select(node => new {
                ProductID = node.Element("ProductID").Value,
                ProductName = node.Element("ProductName").Value,
                CategoryID = node.Element("CategoryID").Value,
                UnitPrice = node.Element("UnitPrice").Value

            });
            
            foreach(var p in productsXML)
            {
                Console.WriteLine($"{p.ProductID}{p.ProductName}");
            }
            
            
            
            /*
             
             
 <Products>
  <Product>
    <ProductID>1</ProductID>
    <ProductName>cherries</ProductName>
    <CategoryID>2</CategoryID>
    <UnitPrice>10.35</UnitPrice>
  </Product>
  <Product>
    <ProductID>2</ProductID>
    <ProductName>strawberries</ProductName>
    <CategoryID>3</CategoryID>
    <UnitPrice>50..0</UnitPrice>
  </Product>
</Products>
             
             */




            Console.WriteLine("==============");

            var testXML = new XElement("XMLRoot",
        new XElement("XMLData", new XAttribute("height", 300), 100),
        new XElement("XMLData", new XAttribute("height", 400), 200),
        new XElement("XMLData", new XAttribute("height", 500), 300),
        new XElement("XMLData", new XAttribute("height", 600), 400)
    );
            testXML.Save("testXML.xml");

            // XML Descendants
            XDocument doc = XDocument.Load("testXML.xml");



            foreach ( var element in doc.Descendants("XMLRoot"))
            {
                foreach (var subelement in element.Descendants("XMLData"))
                {
                    Console.WriteLine($"XMLData : value is {subelement.Value}");

                    Console.WriteLine($"XMLData attribute height has value " +
                        $"{subelement.Attribute("height").Value}\n");

                }
            }


        }
    }
}
