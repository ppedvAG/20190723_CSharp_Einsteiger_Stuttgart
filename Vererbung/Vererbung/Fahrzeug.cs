using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public abstract class Fahrzeug
    { 
        public abstract string Typ { get; set; }

        private string model;

        public virtual string Model
        {
            get { return model; }
            set { model = value; }
        }


        public Fahrzeug()
        {
            //
        }
        public abstract string BeschreibeMich();
        public abstract string Fahren();

    }
}
