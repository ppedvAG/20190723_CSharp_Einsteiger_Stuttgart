using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_MiniRechner_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MiniRechner
            Console.Write("Bitte gib eine Ganz-Zahl ein: ");
            int intzahl = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte gib eine Kommazahl ein: ");
            double doublezahl = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Integer-Ergebnis: {Convert.ToInt32(intzahl + doublezahl)}");
            Console.WriteLine($"Double-Ergebnis {Convert.ToDouble(intzahl + doublezahl)}");

            int höhereZahl = Math.Max(intzahl, (int)doublezahl);
            int niedZahl = Math.Min(intzahl, (int)doublezahl);

            //Autoformatierung - Zeileneinrückung
            // STRG + K + D
             //Schnellaktionen: STRG + .

            Console.WriteLine($"Division-Ergebnis: {höhereZahl / niedZahl}");

            //if (intzahl > doublezahl)
            //{
            //    Console.WriteLine($"Divisions-Ergebnis: {intzahl / doublezahl}");
            //} else
            //{
            //    Console.WriteLine($"Divisions-Ergebnis: {doublezahl / intzahl}");
            //}

            Console.ReadKey();
            #endregion
        }
    }
}
