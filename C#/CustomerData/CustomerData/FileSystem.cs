using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RateCalc_PowerCo
{
    public class FileSystem
    {
        const string path = "customers.txt"; // located in bin/Debug folder
        /// <summary>
        /// ReadCustomers is called to read information stored in a file 
        /// </summary>
        /// <returns> a list of customer entities</returns>
        public static List<Customer> ReadCustomers()
        {
            //List<Customer> custList = new Customer();
            List<Customer> custList = new List<Customer>();
            
            string line; // next line from the file
            string[] fields; // line broken into fields
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate,
                                                 FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    
                    while (!sr.EndOfStream)// while there is still unread data
                    {
                        
                        line = sr.ReadLine();
                        fields = line.Split(',');// split where the commas are
                        //Create corresponding Customer entity based on the 'Type'
                       if(Convert.ToChar(fields[2]) == 'R')
                        {
                            Residential c = new Residential();
                            c.Name = fields[0];
                            c.AccountType = Convert.ToChar(fields[2]);
                            c.ChargeAmount = Convert.ToDecimal(fields[3]);
                            c.AccountNumber = Convert.ToInt32(fields[1]);
                            custList.Add(c); // add it to the list
                        }
                        else if(Convert.ToChar(fields[2]) == 'C'){
                            Commercial c = new Commercial();
                            c.Name = fields[0];
                            c.AccountNumber = Convert.ToInt32(fields[1]);
                            c.AccountType = Convert.ToChar(fields[2]);
                            c.ChargeAmount = Convert.ToDecimal(fields[3]);
                            custList.Add(c); // add it to the list
                        }
                        else if (Convert.ToChar(fields[2]) == 'I')
                        {
                            Industrial c = new Industrial();
                            c.Name = fields[0];
                            c.AccountNumber = Convert.ToInt32( fields[1]);
                            c.AccountType = Convert.ToChar(fields[2]);
                            c.ChargeAmount = Convert.ToDecimal(fields[3]);
                            custList.Add(c); // add it to the list
                        }
                        
                    }
                } // closes sr and recycles
            } // closes fs and recycles
            return custList; // returns the list of customers read from disk
        }
        /// <summary>
        /// Used to save customer information to a file for subsequent retrieval
        /// </summary>
        /// <param name="custList">List of Customer enities</param>
        public static void SaveCustomers(List<Customer> custList)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create,
                                                FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Customer c in custList)
                    {
                        sw.WriteLine(c.ToCSV());
                    }
                } // closes the sw and recyles
            }// closes the fs and recycles
        }
    }
}
