using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeratoren
{
    // Enum-Deklaration im Namespace, um namensraumweit Zugriff zu gewährleisten
    enum Mahlzeit { Frühstück = 1, Mittagessen, Abendessen, Mitternachtsnack };
    class Program
    {
        static void Main(string[] args)
        {
            Mahlzeit aktuelleMahlzeit = Mahlzeit.Mittagessen;
            string einString = "Hallo";

            // Der Wert einer Variablen wird geprüft
            switch (einString)
            {
                case "Hallo":
                    // führe aus
                    Console.WriteLine("Hallo steht in der Variablen");
                    break;
                default:
                    break;
            }


            switch (aktuelleMahlzeit)
            {
                case Mahlzeit.Frühstück:
                    break;

                case Mahlzeit.Mittagessen:
                    break;

                case Mahlzeit.Abendessen:
                    break;
                // Typecasting INT -> Mahlzeit
                case (Mahlzeit)(4):
                    Console.WriteLine("Es gibt einen Mitternachtssnack");
                    break;
                default:
                    break;
            }


            Console.ReadLine();
        }
    }
}
