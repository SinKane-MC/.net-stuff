using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProductMaintenance
{
    public class ProductDB
	{
		private const string path = "Products.dat";

		public static List<Product> GetProducts()
		{
			// create the array list
			List<Product> products = new List<Product>();

			using (FileStream fs =
				new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
			{
				BinaryFormatter bf = new BinaryFormatter();
				if(fs.Length != 0)// there is data
				{
					products = (List<Product>)bf.Deserialize(fs);
				}
			} // closes file stream
			return products;
		}

		public static void SaveProducts(List<Product> products)
		{
			// create the file stream object
			using (FileStream fs = new FileStream(path, FileMode.Create,
				FileAccess.Write))
			{
				BinaryFormatter bf = new BinaryFormatter();
				bf.Serialize(fs, products); // whole list!
			} // closes file stream
	   }
	}
}
