using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Generics
            // Dictionary = Schlüssel-Wert-Sammlung
            // Schlüssel und Werte können auch komplexe Datentypen sein .. z.B. Listen, Personen, usw.
            // Schlüssel: String, Wert: Int-Array
            Dictionary<string, int> blutdruckMesswerte = new Dictionary<string, int>();
            blutdruckMesswerte.Add("Messwert", 12080);

            // Werte des Schlüssel überschreiben (einfach)
            blutdruckMesswerte["Messwert"] = 13094;
            blutdruckMesswerte["Messwert"] = 39857;

            // Neuen Schlüssel hinzufügen (ohne .Add();)
            blutdruckMesswerte["IrgendeinSchlüssel"] = 8273;

            // Deklaration Dictionary, Schlüssel: String, Wert: Integer-Array
            Dictionary<string, int[]> dic = new Dictionary<string, int[]>();

            // Deklaration neues Integer-Array mit Initialisierung
            int[] intArr = new int[] { 2983, 28347, 28347 };

            // hinzufügen Schlüssel + intarray
            dic.Add("Messwert", intArr );
            // hinzufügen Schlüssel + inline-initialisiertes Int-Arrayr
            dic["Messwert"] = new int[] { 1, 5, 23, 4 };
            dic.Add("Spannung", new int[] { 230, 12});

            Hashtable ht = new Hashtable();

            foreach (string key in dic.Keys)
            {
                //Console.WriteLine($"Vorhandener Schlüssel: {key}");
                Console.WriteLine($"Aktueller Schlüssel: {key}");
                foreach (int wert in dic[key])
                {
                    Console.WriteLine($"Aktueller Wert: {wert}");
                }
            }
            #endregion

            #region Queue/Stack
            //Queue<string> Warteschlange = new Queue<string>();
            //Warteschlange.Enqueue("Element 1");
            //Warteschlange.Enqueue("Element 2");
            //Warteschlange.Enqueue("Element 3");

            //foreach(string element in Warteschlange)
            //{
            //    Console.WriteLine($"Warteschlange: {element}");
            //}

            //Console.WriteLine($"Dequeue! : {(Warteschlange.Dequeue()).GetType()}");

            //foreach (string element in Warteschlange)
            //{
            //    Console.WriteLine($"Warteschlange: {element}");
            //}

            //Console.WriteLine($"{Environment.NewLine}");
            //Stack<string> Stapel = new Stack<string>();
            //Stapel.Push("Element 1");
            //Stapel.Push("Element 2");
            //Stapel.Push("Element 3");

            //foreach(string element in Stapel)
            //{
            //    Console.WriteLine($"Stapel: {element}");
            //}
            #endregion

            Console.WriteLine("--- ENDE ---");
            Console.ReadLine();
        }
    }
}
