using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zahlen1 = new int[1];
            int[] zahlen3 = new int[] { 1, 2, 3 };
            //int[50] zahlen4;

            Array.Resize(ref zahlen1, 2);
            zahlen1.SetValue(10, 0);
            zahlen1[1] = 1000;

            //int[,] mehrdim = new int[1, 1];

            Console.WriteLine(zahlen1.Length);

            //List<string> ZahlenListe = new List<string>();
            //ZahlenListe.Add("Element 1");
            //ZahlenListe.Add("Element 2");
            //Console.WriteLine($"Index: {ZahlenListe.IndexOf("Element 1")}")

            //int[] zahlen2 = zahlen1.Append(20).ToArray();

            //zahlen[2] = 30;

            //Console.WriteLine(zahlen1.GetLength(0));
            //Console.WriteLine(zahlen2.Length);
            //Console.WriteLine(zahlen1[0]);


            Console.ReadLine();
        }

    }
}
