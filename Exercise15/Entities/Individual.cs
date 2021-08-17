using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15.Entities
{
    class Individual : Person
    {
        public double Expeditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double annualIncome, double expeditures) : base(name, annualIncome)
        {
            Expeditures = expeditures;
        }

        public override double payTaxes()
        {
            double value = 0.0;
            if(AnnualIncome > 20000.00)
            {
                if(Expeditures > 0.0)
                {
                    value = (AnnualIncome * 0.25) - (Expeditures * 0.50);
                }
                else
                {
                    value = AnnualIncome * 0.25;
                }
            }
            else
            {
                if (Expeditures > 0.0)
                {
                    value = (AnnualIncome * 0.15) + (Expeditures * 0.50);
                }
                else
                {
                    value = AnnualIncome * 0.15;
                }
            }
            return value;
        }
    }
}
