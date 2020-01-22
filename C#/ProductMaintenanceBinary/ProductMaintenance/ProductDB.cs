using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProductMaintenance
{
    public class ProductDB
	{
		//private const string dir = @"C:\C# 2015\Files\";
		//private const string path = dir + "Products.dat";
		private const string path = "Products.dat";

		public static List<Product> GetProducts()
		{
			// if the directory doesn't exist, create it
			//if (!Directory.Exists(dir))
			//	Directory.CreateDirectory(dir);
			List<Product> products = new List<Product>();
			// create the file stream object for the input stream
			using(FileStream fs =new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
			{
				BinaryFormatter bf = new BinaryFormatter();
				if (fs.Length != 0)
				{
					products = (List<Product>)bf.Deserialize(fs);	
				}
			} //closes input stream
			return products;
		}

		public static void SaveProducts(List<Product> products)
		{
			// create the file stream object
			using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
			{
				BinaryFormatter bf = new BinaryFormatter();
				bf.Serialize(fs, products); // whole list gets serialize at one time			
			}
		}// close the output stream
	}
}
