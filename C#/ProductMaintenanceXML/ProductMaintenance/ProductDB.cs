using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ProductMaintenance
{
    public class ProductDB
    {
        //private const string path = @"C:\C# 2015\Files\Products.xml";
        private const string path = @"..\..\Products2.xml";  // this uses the project file

        public static List<Product> GetProducts()
        {
            // create the list
            List<Product> products = new List<Product>();

            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            // create the XmlReader object
            XmlReader xmlIn = XmlReader.Create(path, settings);

            // read past all nodes to the first Product node
            if (xmlIn.ReadToDescendant("Product")) // reads up to first Product element
            {
                // create one Product object for each Product node
                do
                {
                    Product product = new Product();
                    product.Code = xmlIn["Code"]; // reads attribute of Product
                    xmlIn.ReadStartElement("Product"); // finish reading opening tag
                    product.Description = 
                        xmlIn.ReadElementContentAsString(); // reads child element
                    product.Price = 
                        xmlIn.ReadElementContentAsDecimal(); // reads child element
                    products.Add(product); // add to the list
                }
                while(xmlIn.ReadToNextSibling("Product")); // reads up to opening tag for next product if exists
            }

            // close the XmlReader object
            xmlIn.Close();

            return products;
        }

        public static void SaveProducts(List<Product> products)
        {
            using( FileStream fs = new FileStream(path,FileMode.Create, FileAccess.Write))
            {
                XmlSerializer x = new XmlSerializer(products.GetType());
            }


            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            // create the XmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(path, settings);
            
            // write the start of the document
            xmlOut.WriteStartDocument(); // first line
            xmlOut.WriteStartElement("Products"); // opening tag of the root element

            // write each Product object to the xml file
            foreach (Product product in products)
            {
                xmlOut.WriteStartElement("Product"); // opening tag
                xmlOut.WriteAttributeString("Code", 
                    product.Code); // write attribute
                xmlOut.WriteElementString("Description", // child element
                    product.Description);
                xmlOut.WriteElementString("Price", // child element
                    Convert.ToString(product.Price));
                xmlOut.WriteEndElement();// closing tag
            }

            // write the end tag for the root element
            xmlOut.WriteEndElement();

            // close the XmlWriter object
            xmlOut.Close();
        }
    }
}
