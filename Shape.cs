// Eric Sällström .NET23

using static GrunderOOPLabb5.Program;

namespace GrunderOOPLabb5
{
    // Jag har skapat en abstrakt basklass ("Shape")
    // som de övriga underklasserna ärver ifrån.
    // Den är deklarerad som abstrakt eftersom
    // det skall ej gå att skapa ett objekt enbart
    // av klassen "Shape".
    internal abstract class Shape
    {
        // "Name" tar emot en stringvariabel från alla
        // objekt som skapas. Variabeln går ej att ändra
        // efter instansieringen eftersom set är private.
        public string Name { get; private set; }

        // "Pi" är satt till protected så att alla
        // underklasser kommer åt den, men klasser/objekt som
        // inte ärver från Shape kommer således inte åt den.
        // Nyckelordet const används eftersom värdet av "Pi"
        // bör ej förändras/modifieras.
        protected const double Pi = Math.PI;

        // En protected konstruktor som alla 
        // underklasser måste implementera.
        protected Shape(string name)
        {
            // Inkapsling av värdet från "name" när det 
            // tilldelas "Name"
            Name = name;
        }

        // Abstrakt metod utan kropp som måste implementeras i
        // underklasserna. Metoden skall returnera ett objekts area.
        public abstract double GetArea();

        // Abstrakt metod där alla beräkningar av ett objekt skrivs till Console.
        public abstract void PrintCalculations();
    }
}