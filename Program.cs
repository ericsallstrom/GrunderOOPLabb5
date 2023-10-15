// Eric Sällström .NET23

using System.Globalization;

namespace GrunderOOPLabb5
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            // De olika objekten, skapat utifrån respektive underklass, 
            // läggs in i listan "shapes" direkt vid instansiering.           
            List<Shape> shapes = new()
            {
                new Circle(name: "Circle A", radius: 5),
                new Circle(name: "Circle B", radius: 6),
                new Triangle(name: "Triangle C", baseWidth: 7, height: 4),
                new Triangle(name: "Triangle D", baseWidth: 9, height: 11),
                new Sphere(name: "Sphere E", radius: 4),
                new Sphere(name: "Sphere D", radius: 3)
            };

            // Med hjälp av en foreach-loop skrivs uträkningar 
            // för respektive objekt ut till Console.
            foreach (Shape shape in shapes)
            {
                shape.PrintCalculations();
            }
        }
    }
}