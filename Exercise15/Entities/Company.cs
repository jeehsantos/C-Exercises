
namespace Exercise15.Entities
{
    class Company : Person
    {
        public int Employees { get; set; }

        public Company()
        {
        }

        public Company(string name, double annualIncome, int employees) : base(name, annualIncome)
        {
            Employees = employees;
        }

        public override double payTaxes()
        {
            double value = 0.0;
            if(Employees > 10)
            {
                value = AnnualIncome * 0.14;
            }
            else
            {
                value = AnnualIncome * 0.16;
            }

            return value;
        }

    }
}
