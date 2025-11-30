using System;
using System.Linq;
using System.Xml.Linq;

namespace CRUDLinqXML
{
    internal class Program
    {
        // Change this path if needed
        private const string XmlPath = "D:\\NET\\8_LINQ_Web_Architecture\\code\\assignment\\CRUDLinqXML\\CRUDLinqXML\\products.xml";
        static void Main(string[] args)
        {
            // Load the XML file
            XDocument doc = XDocument.Load(XmlPath);

            Console.WriteLine("Product names based on id_____________");

            // READ ALL
            PrintAllProductNames(doc);

            // --- EXAMPLES OF CRUD OPERATIONS ---

            // ADD a new product
            AddProduct(doc, "06", "Product6", 4000, "INR");

            // UPDATE product name & price by id
            UpdateProduct(doc, "02", "Product2_New", 1800);

            // DELETE product by id
            DeleteProduct(doc, "5");

            // READ one product by id
            Console.WriteLine("\nSingle product with id = 03:");
            ReadOneProductById(doc, "03");

            // Save back to the file (optional)
            doc.Save(XmlPath);

            Console.WriteLine("\nFinal product list:");
            PrintAllProductNames(doc);

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }

        // READ ALL: show names (like sample output)
        private static void PrintAllProductNames(XDocument doc)
        {
            var products =
                from p in doc.Descendants("Product")
                select new
                {
                    Id = (string)p.Attribute("id"),
                    Name = (string)p.Element("name")
                };

            foreach (var p in products)
            {
                Console.WriteLine(p.Name);
            }
        }

        // ADD: add new <Product> element
        private static void AddProduct(XDocument doc, string id, string name, decimal price, string currency)
        {
            XElement newProduct =
                new XElement("Product",
                    new XAttribute("id", id),
                    new XElement("name", name),
                    new XElement("price",
                        new XAttribute("currency", currency),
                        price.ToString())
                );

            doc.Root.Add(newProduct);
        }

        // DELETE: remove product with matching id
        private static void DeleteProduct(XDocument doc, string id)
        {
            var product =
                (from p in doc.Descendants("Product")
                 where (string)p.Attribute("id") == id
                 select p).FirstOrDefault();

            if (product != null)
            {
                product.Remove();
            }
        }

        // UPDATE: change name and price for product with given id
        private static void UpdateProduct(XDocument doc, string id, string newName, decimal newPrice)
        {
            var product =
                (from p in doc.Descendants("Product")
                 where (string)p.Attribute("id") == id
                 select p).FirstOrDefault();

            if (product != null)
            {
                product.Element("name")!.Value = newName;
                product.Element("price")!.Value = newPrice.ToString();
            }
        }

        // READ ONE: print a single product by id
        private static void ReadOneProductById(XDocument doc, string id)
        {
            var product =
                (from p in doc.Descendants("Product")
                 where (string)p.Attribute("id") == id
                 select p).FirstOrDefault();

            if (product != null)
            {
                string name = (string)product.Element("name");
                string price = (string)product.Element("price");
                string currency = (string)product.Element("price")?.Attribute("currency");

                Console.WriteLine($"Id = {id}, Name = {name}, Price = {price} {currency}");
            }
            else
            {
                Console.WriteLine($"Product with id = {id} not found.");
            }
        }


    }
}
