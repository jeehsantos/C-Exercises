using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            return Name + " $"+totalPrice().ToString("F2") + $"(Customs fee: $ {CustomsFee.ToString("F2")} )";

        }

        public double totalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
