// Eric Sällström .NET23

namespace GrunderOOPLabb5
{
    // Klassen "Circle" är en underklass till klassen "Shape".
    internal class Circle : Shape
    {
        // Ett fält som är deklarerat som public men 
        // där "set" är private eftersom objektets radie
        // inte ska kunna ändras efter instansiering.
        // Dock kan användaren fortfarande komma åt
        // värdet.
        public double Radius { get; private set; }

        // Konstruktor som ärver "name"-variabeln av klassen "Shape" plus
        // att en radie måste matas in vid skapandet av objektet.
        public Circle(string name, double radius) : base(name)
        {
            // Inkapsling sker här genom att värdet från "radius"
            // tilldelas fält-variabeln "Radius".
            Radius = radius;
        }

        // Metod som returnerar en cirkels omkrets.
        public double GetCircumference()
        {
            double circumference = 2 * Pi * Radius;
            return circumference;
        }

        // Metod som returnerar en cirkels diameter.
        public double GetDiameter()
        {
            double diameter = 2 * Radius;
            return diameter;
        }

        // Överskuggad metod som är ärvd från basklassen
        // "Shape" och returnerar en cirkels area.
        public override double GetArea()
        {
            double area = Math.Pow(Radius, 2) * Pi;
            return area;
        }

        // Metod som skriver ut beräkningarna gjorda utifrån 
        // cirkelns radie. Kollar även om radien är mindre än
        // eller lika med 0 och skriver isf ut ett felmeddelande.
        // Decimalerna har kortats ner till 1 (genom :N1) för mer
        // överskådliga beräkningar.
        public override void PrintCalculations()
        {
            if (Radius <= 0)
            {
                Console.WriteLine($"# ERROR" +
                                $"\n-----------------------------" +
                                $"\n* Calculations uncompleted." +
                                $"\n* Radius of {Name.ToUpper()} cannot" +
                                $"\n* be less than or equal to 0." +
                                $"\n-----------------------------" +
                                $"\n-----------------------------");
            }
            else
            {
                Console.WriteLine($"# {Name.ToUpper()}" +
                                $"\n-----------------------------" +
                                $"\n* Radius: {Radius:N1} cm" +
                                $"\n* Area: {GetArea():N1} cm²" +
                                $"\n* Diameter: {GetDiameter():N1} cm" +
                                $"\n* Circumference: {GetCircumference():N1} cm" +
                                $"\n-----------------------------" +
                                $"\n-----------------------------");
            }
        }
    }
}