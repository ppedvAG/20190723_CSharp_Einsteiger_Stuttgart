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
        }
        public static void ändereAlter(ref int _irgendwas, int zuÄndern)
        {
            _irgendwas = zuÄndern;
            //return true;
        }

    }
}
