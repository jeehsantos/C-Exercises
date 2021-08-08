using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    class Product
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Desc { get; set; }
        public int Quantity { get; set; }

        public Product(int id, string brand, string desc, int quantity)
        {
            Id = id;
            Brand = brand;
            Desc = desc;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return "Id: "
                    + Id
                    + " , Brand: "
                    + Brand
                    + ", Description "
                    + Desc
                    + ", Qty: "
                    + Quantity;
        }
    }
}
