using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysUndSchleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays & Schleifen
            //int[] zahlen = new int[] { 10, 20, 30, 40, 50 };
            //int[,] zahlen2 = new int[,] { { 5, 6, 7 }, { 7, 8, 9 } };

            //Console.WriteLine($"{zahlen2[0,0]}");
            //Console.WriteLine($"{zahlen.Sum()}");
            //Console.WriteLine($"Arraylänge: {zahlen.Length}");

            //int i;
            //for (i = 0; i <= zahlen.Length; i++)
            //{
            //    Console.WriteLine($"Aktuelle Zahl: {zahlen[i]}");
            //}
            //i = 0;
            //while (i < zahlen.Length)
            //{
            //    // Operationen
            //    Console.WriteLine($"{i}ter Durchlauf.");
            //    i++;
            //}

            //do
            //{
            //    // Operationen
            //    Console.WriteLine($"{i}ter Durchlauf.");
            //    i++;
            //} while (i < zahlen.Length);

            //foreach (int zahl in zahlen)
            //{
            //    Console.WriteLine($"Aktuelle Zahl: {zahl}");
            //    Console.WriteLine($"{zahl.GetType()}");
            //}

            #endregion Arrays & Schleifen

            List<string> StringListe = new List<string>();
            StringListe.Add("Element 1");
            StringListe.Add("Element 2");
            StringListe.Add("Element 3");

            foreach (string element in StringListe)
            {
                Console.WriteLine($"Aktuelles Element: {element}");
                if (element == "Element 2")
                {
                    Console.WriteLine("Hallo, ich bin Element 2");
                    //break;
                    //continue;
                }
            }

            Console.WriteLine("--- ENDE ---");
            Console.ReadLine();
        }
    }
}
