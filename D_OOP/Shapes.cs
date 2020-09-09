using System; 

namespace D_OOP
{
    public abstract class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape Created.");
        }
        
        public abstract void Draw();

        public abstract double Area();

        public abstract double Perimeter();
    }

    public class Rectangle : Shape 
    {
        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;

            Console.WriteLine($"Rectangle created.");
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing rectangle...");
        }

        public override double Area()
        {
            return width * height;
        }

        public override double Perimeter()
        {
            return 2 * (width + height);
        }
    }

    public class Triangle : Shape
    {
        private readonly double ab;
        private readonly double bc;
        private readonly double ac;
        
        public Triangle(double ab, double bc, double ac)
        {
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;
            
            Console.WriteLine($"Triangle created.");
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing triangle");
        }

        public override double Area()
        {
            double s = (ab + bc + ac) / 2;
            return Math.Sqrt(s * (s - ab) * (s - bc) * (s - ac));
        }

        public override double Perimeter()
        {
            return (ab + bc + ac) / 2;
        }
    }
}