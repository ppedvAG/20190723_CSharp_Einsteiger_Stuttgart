using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public class Auto : Fahrzeug
    {
        private string typ;

        public override string Typ
        {
            get { return typ; }
            set { typ = value; }
        }

        public Auto()
        {

        }

        public override string BeschreibeMich()
        {
            // Logik einbauen
            return "als Auto";
        }

        public override string Fahren()
        {
            return "auf 4 Rädern";
        }
    }
}
