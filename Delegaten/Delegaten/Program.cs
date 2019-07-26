using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaten
{
    class Program
    {
        public delegate int MeinDelegatenTyp(int p1, int p2);
        static void Main(string[] args)
        {
            MeinDelegatenTyp HRManager = new MeinDelegatenTyp(BeispielMethode);

            MeinDelegatenTyp FinanceManager = new MeinDelegatenTyp(BeispielMethodeNummerZwei);

            HRManager.Invoke(10, 287);

            Console.WriteLine( $"{BeispielMethode(5, 5)}");
            Console.WriteLine($"{HRManager.Invoke(5, 5)}");

            Console.ReadLine();
        }

        public static int BeispielMethode(int p1, int p2)
        {
            return p1 + p2;
        }
        public static int BeispielMethodeNummerZwei(int p1, int p2)
        {
            return p1 - p2;
        }
    }
}
