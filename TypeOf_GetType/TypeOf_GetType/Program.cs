using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace TypeOf_GetType
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug fahrrad = new Fahrrad();

            // nicht möglich
            // Fahrrad fahrrad = new Fahrzeug();

            Console.WriteLine($"{(fahrrad.GetType()).GetType()}");

            Console.WriteLine($"{(typeof(Fahrrad)).GetType()}");

            Console.WriteLine($"{fahrrad.GetType() == typeof(Fahrrad)}");
            Console.WriteLine($"{fahrrad.GetType() == typeof(Fahrzeug)}");
            Console.WriteLine($"{Environment.NewLine}");

            Console.WriteLine($"{fahrrad is Fahrrad}"); // true
            Console.WriteLine($"{fahrrad is Fahrzeug}"); // true

            Console.ReadLine();
        }
    }
}
