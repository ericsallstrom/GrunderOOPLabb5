// Eric Sällström .NET23

namespace GrunderOOPLabb5
{
    // Klassen "Triangle" är en underklass till klassen "Shape"
    internal class Triangle : Shape
    {
        // Två publika fält med private "set" då värdet ej bör
        // ändras efter instansiering, men användaren kan fortfarande
        // komma åt de enskilda värdena. Fälten tilldelas triangelns
        // respektive bas och höjd.
        public double BaseWidth { get; private set; }
        public double Height { get; private set; }

        // Konstruktor som innehåller den ärvda "name"-variabeln från "Shape"-klassen,
        // plus att en bas och höjd måste matas in när ett triangel-objekt skapas.
        public Triangle(string name, double baseWidth, double height) : base(name)
        {
            // Inkapsling sker här genom att värdet från "baseWidth"
            // och "height" tilldelas till fält-variablerna
            // "BaseWidth" och "Height".
            BaseWidth = baseWidth;
            Height = height;
        }

        // Metod som returnerar en triangels hypotenusa.
        public double GetHypotenuse()
        {
            double sum = Math.Pow(BaseWidth, 2) + Math.Pow(Height, 2);
            double hypotenuse = Math.Sqrt(sum);
            return hypotenuse;
        }

        // Metod som returnerar en triangels omkrets.
        public double GetCircumference()
        {
            double hypotenuse = GetHypotenuse();
            double circumference = BaseWidth + Height + hypotenuse;
            return circumference;
        }

        // Metod som returnerar en triangels area.
        // Överskuggar metoden från basklassen Shape.
        public override double GetArea()
        {
            double area = 0.5 * BaseWidth * Height;
            return area;
        }

        // Överksuggad metod som skriver ut beräkningarna gjorda utifrån 
        // triangels två sidor. Kollar även om någon av sidorna är mindre
        // än eller lika med 0 och skriver isf ut ett felmeddelande.
        // Decimalerna har kortats ner till 1 (genom :N1) för mer
        // överskådliga beräkningar.
        public override void PrintCalculations()
        {
            if (BaseWidth <= 0 || Height <= 0)
            {
                Console.WriteLine($"# ERROR" +
                                $"\n-----------------------------" +
                                $"\n* Calculations uncompleted." +
                                $"\n* Neither base or height of " +
                                $"\n* {Name.ToUpper()} cannot be" +
                                $"\n* less than or equal to 0." +
                                $"\n-----------------------------" +
                                $"\n-----------------------------");
            }
            else
            {
                Console.WriteLine($"# {Name.ToUpper()}" +
                                $"\n-----------------------------" +
                                $"\n* Base: {BaseWidth:N1} cm" +
                                $"\n* Height: {Height:N1} cm" +
                                $"\n* Area: {GetArea():N1} cm²" +
                                $"\n* Circumference: {GetCircumference():N1} cm" +
                                $"\n-----------------------------" +
                                $"\n-----------------------------");
            }
        }
    }
}