using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;

namespace lab_69_XML_from_Northwind
{
    class Program
    {
        static void Main(string[] args)
        {
            // product list
            List<Product> products = new List<Product>();           // from Northwind
            Products productsFromXML = new Products();              // from XML, deserialize

            using (var db = new Northwind())
            {
                // select all products; fill our list
                products = db.Products.ToList();
            }

            // find first product  (use Entity and .FirstOrDefault  or Take(1)
            var product = products.FirstOrDefault();
            // print to screen
            Console.WriteLine($"{product.ProductID}, {product.ProductName}, {product.CategoryID}, {product.UnitPrice}");
            
            // output to XML
            Console.WriteLine("\n\nSingle XML Product\n\n");
            var XMLProduct = new XElement("Product",
                new XElement("ProductID",product.ProductID),
                new XElement("ProductName", product.ProductName),
                new XElement("CategoryID", product.CategoryID),
                new XElement("UnitPrice", product.UnitPrice)
                );
            Console.WriteLine(XMLProduct);


            Console.WriteLine("\n\nFirst 5 Products\n\n");
            // use LINQ syntax to get this job done

            var XMLProducts = new XElement("Products",
                from p in products.Take(5)
                select new XElement("Product",
                    new XElement("ProductID", p.ProductID),
                    new XElement("ProductName", p.ProductName),
                    new XElement("CategoryID", p.CategoryID),
                    new XElement("UnitPrice", p.UnitPrice)
            ));

            // save
            XMLProducts.Save("Products.xml");
            // print
            Console.WriteLine(XMLProducts);


            // Send our Products XML list across the world to our supplier 



            // At the other side of world, now deserialise file back into C# Products

            // streamread into memory first, then deserialize



            using (var reader = new StreamReader("Products.xml"))
            {
                // now deserialize the stream
                var serializer = new XmlSerializer(typeof(Products));
                productsFromXML = (Products)serializer.Deserialize(reader);
            }


            productsFromXML.ProductList.ForEach(p => Console.WriteLine($"{p.ProductID}{p.ProductName}{p.UnitPrice}"));









        }
    }

    [XmlRoot("Products")]
    public class Products
    {
        [XmlElement("Product")]
        public List<Product> ProductList { get; set; }
    }




    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public Category()
        {
            this.Products = new List<Product>();
        }
    }



    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? CategoryID { get; set; }
   //     public virtual Category Category { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; } = 0;
        public short? UnitsInStock { get; set; } = 0;
        public short? UnitsOnOrder { get; set; } = 0;
        public short? ReorderLevel { get; set; } = 0;
        public bool Discontinued { get; set; } = false;
    }




    public class Northwind : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;" +
                   "Initial Catalog=Northwind;" + "Integrated Security = true;" +
                   "MultipleActiveResultSets=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            // define a one-to-many relationship
            //modelBuilder.Entity<Category>()
            //    .HasMany(c => c.Products)
            //    .WithOne(p => p.Category);

            modelBuilder.Entity<Product>()
                .Property(c => c.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            //modelBuilder.Entity<Product>()
            //    .HasOne(p => p.Category)
            //    .WithMany(c => c.Products);

        }
    }
}




