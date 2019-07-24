using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werkzeuge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erzeugen einer Objekt-Instanz anhand des Bauplans (Klasse: Prüfgerät)
            Prüfgerät prüfgerät_TypA = new Prüfgerät();
            prüfgerät_TypA.Hersteller = "Keysight";

            // Erzeugen einer weiteren Objekt-Instanz anhand des Bauplans
            Prüfgerät prüfgerät_TypB = new Prüfgerät();
            // Ausführen der Methode "Einschalten" eines Prüfgerätes
            prüfgerät_TypA.Einschalten();

            prüfgerät_TypB.Einschalten();

            // Ausgabe
            Console.WriteLine(prüfgerät_TypA.ToString());

            Console.ReadLine();
        }
    }
}
