using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise23.Entities
{
    class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return "Id: "
                   + Id
                   + " Name: "
                   + Name
                   + " Price $ "
                   + Price.ToString("F2")
                   + " Category: "
                   + Category.Tier.ToString(); ;
        }
    }
}
