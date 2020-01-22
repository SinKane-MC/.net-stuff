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
            using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate,
                                        FileAccess.Read))
            {
                XmlSerializer x = new XmlSerializer(products.GetType());
                if(fs.Length > 0) // there is data
                {
                    products = (List<Product>)x.Deserialize(fs);
                }
            }
            return products;
        }

        public static void SaveProducts(List<Product> products)
        {
            using(FileStream fs = new FileStream(path, FileMode.Create, 
                                            FileAccess.Write))
            {
                XmlSerializer x = new XmlSerializer(products.GetType());
                x.Serialize(fs, products);
            }// closes file stream          
        }

    } // class
}// namespace
