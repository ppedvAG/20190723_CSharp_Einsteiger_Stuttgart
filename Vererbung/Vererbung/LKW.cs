using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public class LKW : Fahrzeug
    {
        private string typ;

        public override string Typ
        {
            get { return typ; }
            set { typ = value; }
        }

        public LKW()
        {
            //
        }
        public override string BeschreibeMich()
        {
            return "als LKW";
        }
        public override string Fahren()
        {
            return "als LKW";
        }
    }
}
