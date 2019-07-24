using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werkzeuge
{
    class Prüfgerät
    {
        #region Eigenschaften
        public string Hersteller;
        private DateTime BauDatum;
        private int ID;
        private string Modelbezeichnung;
        #endregion

        #region Konstruktor

        #endregion

        #region Methoden
        public bool Einschalten()
        {
            Console.WriteLine("Prüfgerät wurde angeschaltet");
            return true;
        } 

        public bool Ausschalten()
        {
            return true;
        }

        public float SpannungMessen()
        {
            return 0;
        }
        #endregion
    }
}
