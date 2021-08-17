using Exercise14.Entities.Enum;
 
namespace Exercise14.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape()
        {
        }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract  double area();
    }
}
