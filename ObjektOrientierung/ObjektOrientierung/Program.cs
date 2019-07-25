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
            for(int i = 0; i < 3; i++)
            {
                ErzeugePrüfgerät(i);
            }
            // Aufrufen der .EXE-Datei über eine Command-Line .. nach beenden (verlassen der Main-Methode) wird GC aufgerufen!
            // GC.Collect();

            //// Erzeugen einer Objekt-Instanz anhand des Bauplans (Klasse: Prüfgerät)

            //Prüfgerät prüfgerät_TypA = new Prüfgerät();
            //Console.WriteLine($"Das Prüfgerät ist {prüfgerät_TypA.Power}");

            ////Console.WriteLine($"Konstruierung: {prüfgerät_TypS}");
            //prüfgerät_TypA.Hersteller = "Keysight";
            ////Console.WriteLine($"Die Prüfgeräte-ID lautet: {prüfgerät_TypA.Id}");

            //// Erzeugen einer weiteren Objekt-Instanz anhand des Bauplans
            ////Prüfgerät prüfgerät_TypB = new Prüfgerät();
            ////prüfgerät_TypB.Einschalten();

            //// Ausführen der Methode "Einschalten" eines Prüfgerätes
            //prüfgerät_TypA.Einschalten();
            //Console.WriteLine($"Das Prüfgerät ist {prüfgerät_TypA.Power}");
            //// Ausgabe
            //Console.WriteLine(prüfgerät_TypA.ToString());
            //// Prüfgerät
            //prüfgerät_TypA.Ausschalten(3600);
            //Console.WriteLine($"Das Prüfgerät ist nun {prüfgerät_TypA.Power}");

            Console.ReadLine();
        }

        static void ErzeugePrüfgerät(int id)
        {
            Prüfgerät func_PG1 = new Prüfgerät(id);
            Console.WriteLine($"Prüfgerät mit ID {func_PG1.Id} wurde erstellt.");
        }
    }
}
