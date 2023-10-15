// Eric Sällström .NET23

namespace GrunderOOPLabb5
{
    // Klassen "Sphere" är en underklass till klassen "Shape"
    internal class Sphere : Shape
    {
        // Ett fält som är deklarerat som public men 
        // där "set" är private eftersom objektets radie
        // inte ska kunna ändras efter instansiering.
        // Dock kan användaren fortfarande komma åt värdet.
        public double Radius { get; private set; }

        // Konstruktor som ärver "name"-variabeln men tvingar också
        // användaren, vid instansieringen av objektet, att mata
        // in klotets radie. 
        public Sphere(string name, double radius) : base(name)
        {
            // Inkapsling sker här genom att värdet från "radius"
            // tilldelas fält-variabeln "Radius".
            Radius = radius;
        }

        // Metod som returnerar ett klots volym.
        public double GetVolume()
        {
            double volume = (4 * Pi * Math.Pow(Radius, 3)) / 3;
            return volume;
        }

        // Metod som returnerar ett klots omkrets.
        public double GetCircumference()
        {
            double circumference = 2 * Pi * Radius;
            return circumference;
        }

        // Metod som returnerar ett klots diameter.
        public double GetDiameter()
        {
            double diameter = 2 * Radius;
            return diameter;
        }

        // Överskuggad metod som returnerar ett klots area.
        public override double GetArea()
        {
            double area = 4 * Pi * Math.Pow(Radius, 2);
            return area;
        }

        // Överksuggad metod som skriver ut beräkningarna gjorda utifrån 
        // klotets radie. Kollar även om radien är mindre än
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
                                $"\n* Volume: {GetVolume():N1} cm³" +
                                $"\n* Diameter: {GetDiameter():N1} cm" +
                                $"\n* Circumference: {GetCircumference():N1} cm" +
                                $"\n-----------------------------" +
                                $"\n-----------------------------");
            }
        }
    }
}