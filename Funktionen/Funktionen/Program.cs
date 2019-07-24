using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funktionen
{
    class Program
    {
        static void Main(string[] args)
        {
            int alter = 29;
            Console.WriteLine($"Vor Ref-Aufruf: {alter}");
            ändereAlter(ref alter, 40);
            Console.WriteLine($"Nach Ref-Aufruf: {alter}");
            Console.ReadLine();

            int meineSumme = bildeSumme(5, 5, 5, 6, 3, 5, 3);
        }
        public static void ändereAlter(ref int _irgendwas, int zuÄndern)
        {
            _irgendwas = zuÄndern;
            //return true;
        }

        // params: Dynamische Werte-Übergabe an die Funktion .. siehe Zeile 20!
        public static int bildeSumme(params int[] summanden)
        {
            int summe = 0;
            foreach (int item in summanden)
            {
                summe += item;
            }
            return summe;
        }

    }
}
