using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory
{
    public static class ProductDB
    {
        const string path = "products.txt"; // assumes it will be located 
                                            //in the bin\debug folder of this app

        public static void SaveProducts(List<Product> productList)
        {
            using (FileStream fs = new FileStream(path,FileMode.Create,FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Product p in productList)
                    {
                        sw.WriteLine(p.ToCSV());
                    }
                }// closes sw and recycles
            }// closes fs and recycles
        }
    public static List<Product> ReadProducts()
        {
            List<Product> products = new List<Product>(); // create empty list
            Product p; // read products
            string line; // next line from file
            string[] fields; // line broken into fields

            using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while(!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        fields = line.Split(','); // split string at the commas
                        p = new Product(); // create new product and fill with data
                        p.Name = fields[0];
                        p.Price = Convert.ToDecimal(fields[1]);
                        p.Qty = Convert.ToInt32(fields[2]);
                        products.Add(p); // add prodcut to the list
                    }


                }// closes sr and recycles
            }// closes the fs and recycles





            return products;

        }
    
    
    }
}
