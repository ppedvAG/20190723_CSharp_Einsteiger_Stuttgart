﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloWelt
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sprachgrundlagen Eingabe/Ausgabe
            //string einText = "Hallo Welt";
            //string meinName = "Daniel";
            //Console.WriteLine(einText + ", ich bin Daniel");
            //Console.WriteLine("{0} ich bin {1}", einText, meinName);
            //Console.WriteLine($"{einText} , ich bin Daniel");
            //Console.WriteLine("Bitte geben Sie Ihren Namen ein:");
            ////Console.WriteLine($"Hallo {Console.ReadLine()}");
            //string EingabeName = Console.ReadLine();
            //Console.WriteLine($"Hallo {EingabeName}");
            //Console.WriteLine("Bitte ein Alter angeben (Ganzzahl!): ");
            //sbyte EingabeAlter = Convert.ToSByte();
            //long output;
            //bool result = Int64.TryParse(Console.ReadLine(), out output);
            //long eingabe2 = Int64.Parse(Console.ReadLine());
            double ddtest = 5.55;
            int test = (int)ddtest;
            MessageBox.Show(Convert.ToString(test));

            //Console.WriteLine($"Alter ist {eingabe2}");

            //Console.WriteLine($"Dein Alter ist: {EingabeAlter}");

            #endregion Sprachgrundlagen Eingabe/Ausgabe

            // Intellisense an einer Klasse öffnen STRG + Leerzeichen
            Console.WriteLine("--- ENDE ---");
            Console.ReadLine();
        }
    }
}
