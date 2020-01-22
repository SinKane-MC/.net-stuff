using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Order class with auto-implented attributes for Order entities
/// DateTime atrributes are Nullable
/// </summary>
namespace Lab4
{
    public class Order
    {
        public int OrderID { get; set; }

        public string CustomerID { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }


    }
}
