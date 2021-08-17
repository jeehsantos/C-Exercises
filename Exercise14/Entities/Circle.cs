using Exercise14.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
        }

        public Circle(Color color, double radius) : base (color)
        {
            Radius = radius;
        }

        public override double area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
