using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LottoApp            
            Console.WriteLine("Gib eine Zahl zwischen 1 und 10 ein: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib eine weitere Zahl zwischen 1 und 10 ein: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib eine letzte Zahl zwischen 1 und 10 ein: ");
            int userInput3 = Convert.ToInt32(Console.ReadLine());
            int[] userZahlen = new int[] { userInput1, userInput2, userInput3 };

            Random generator = new Random();
            int[] zufallsZahlen = new int[3];
            int counter = 0;

            for (int i = 0; i <= zufallsZahlen.Length - 1; i++)
            {
                int aktuelleZahl = 0;
                do
                {
                    aktuelleZahl = generator.Next(1, 11);
                } while (zufallsZahlen.Contains(aktuelleZahl));

                zufallsZahlen[i] = aktuelleZahl;
                Console.WriteLine($"{i + 1}. Gewinnzahl: {aktuelleZahl}");

                foreach (int zahl in userZahlen)
                {
                    if (aktuelleZahl == zahl)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"Du hast {counter} Zahl(en) richtig getippt!");
            Console.ReadLine();
        }
        #endregion LottoApp
    }
}
