using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {

        static int Square(int x)
        {
            return x * x;
        }

        static int Cube(int x) => x * x * x; 

        static void Main(string[] args)
        {
            Func<int, int> f;
            Func<int, bool> g;
            ///Variable definiert - der kann ich jetzt einen Wert eingeben und bekomme einen int zurück (letzter ist immer Rückgabewert
                              ///  Func<string double...> f;
                              ///  
            f = Square; ///speichert Funktion in Variable;
            g = Cube; /// geht nicht, weil die Funktion einen Integer retour gibt aber die Variable bool;

            Console.WriteLine(Square(5));
            Console.WriteLine(Cube(5));
        }
    }
}

///List<int> a = new List<int>(); Woche 1 anschauen
///

    static double[] Map(double[] xs, Func <double, double> f)
{
    var rs = new double[xs.Length];

    for (var i = 0; i < xs.Length; i++)
        rs[i] = f(xs[i]);

    return rs;
}

static void Main(string[] args)
{
    ///var data = new Dictionary<string, List<HashSet<double>>>();

    double[] xs = new double[] { 0, 10, 20, 30, 40, 50, Math.PI / 2 };
    double[] sines = Map(xs, Math.Sin);
    double[] cosines = Map(xs, Math.Cos);

    for (int i = 0; i < xs.Length; i++)
        Console.WriteLine(§"xs[{i}] = {xs [i]} ... {sines[i]}");


    /*double[] xs = { 10, 20, 30, 40, 50 };
    double[] sines = new double[xs.Length];
    double[] cosines = new double[xs.Length];

    for (int i = 0; i < xs.Length; i++)
        sines[i] = Math.Sin(xs[i]);

    for (int i = 0; i < xs.Length; i++)
        cosines[i] = Math.Cos(xs[i]);

    */

}

///Jetzt gehen wir weiter. Ich will an der Stelle nur meine Daten quadrieren - ich will hier direkt die Funktion hinschreiben
///
static void Main(string[] args)
{
    
    var xs = new double[] { 0, 10, 20, 30, 40, 50, Math.PI / 2 }; //4
    var sines = Map(xs, Math.Sin);
     var cosines = Map(xs, Math.Cos);
    var asd = Map(xs, (double x) => x * x); //beim ersten x steht doublex
    //noch mehr vereinfacht: var asd = Map(xs, x => x * x);

    for (int i = 0; i < xs.Length; i++)
        Console.WriteLine(§"xs[{i}] = {xs [i]} ... {sines[i]}");
    //--------------------------------------------------------------------------------------

    //get bringt mir ein field mit einem Namen und gibt mir den Inhalt zurück
    class Person
{
    public string Name { get; }
    public DateTime DateOfBirth { get; }
    public bool HasBirthday
    {
        get //ist das aktuelle Datum gleich dem Monat des Geburtstags?
        {
            return DateTime.Now.Month == DateOfBirth.Month
                && DateTime.Now.Day == DateOfBirth.Day;
        }
    }

    // Constructor.
    public Person(string name, DateTime dateOfBirth)
    {
        Name = name;
        DateOfBirth = dateOfBirth;
    }
}

// Customer is derived from Person.
// It has a Name, a DateOfBirth and a HasBirthday property.
// Additionally to the inherited properties, it also has a CustomerId.
class Customer : Person
{
    public int CustomerId { get; }

    // Customer constructor calls inherited Person constructor via ': base(...)' ...
    public Customer(string name, DateTime dateOfBirth, int customerId)
        : base(name, dateOfBirth)
    {
        // ... and initializes remaining members not inherited from base class
        CustomerId = customerId;
    }
}
