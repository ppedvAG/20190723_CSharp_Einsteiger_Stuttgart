using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortbewegungsmittel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanzierung eines Fahfzeugobjektes
            Fahrzeug f1 = new Fahrzeug("BMW",19999);

            f1.BeschreibeMich();

            f1.StarteMotor();

            f1.Beschleunige(50.00);

            f1.BeschreibeMich();

            f1.StoppeMotor();

            f1.BeschreibeMich();

            Console.ReadLine();
        }
    }
}
