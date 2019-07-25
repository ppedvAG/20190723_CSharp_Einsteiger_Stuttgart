using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Werkzeuge
{
    public enum PowerZustand { On = 1, Off };
    public class Prüfgerät
    {
        #region Felder
        private DateTime bauDatum;
        private int id;
        private PowerZustand power;
        private string modelbezeichnung { get => modelbezeichnung; set => modelbezeichnung = value; }
        public string Hersteller;
        #endregion Felder

        #region Eigenschaften
        public int Id
        {
            get
            {
                return id;
            }
            private set
            {
                id = value;
            }
        }

        //public DateTime BauDatum { get => bauDatum; set => bauDatum = value; }
        public DateTime BauDatum
        {
            get
            {
                return bauDatum;
            }
            set
            {
                bauDatum = value;
            }
        }

        public PowerZustand Power { get => power; private set => power = value; }

        #endregion

        #region Konstruktor
        public Prüfgerät()
        {
            power = PowerZustand.Off;
        }

        public Prüfgerät(int id)
        {
            Id = id;
        }
        #endregion

        #region Destruktor
        ~Prüfgerät()
        {
            Console.WriteLine($"Destruktor wurde ausgeführt ...");
        }
        #endregion

        #region Methoden
        public bool Einschalten()
        {
            Console.WriteLine("Prüfgerät wurde angeschaltet");
            power = PowerZustand.On;
            return true;
        }

        public bool Ausschalten()
        {
            power = PowerZustand.Off;
            return true;
        }

        public bool Ausschalten(int timer)
        {
            Console.WriteLine($"Prüfgerät wird in {timer/1000} Sekunden ausgeschaltet..");
            Thread.Sleep(timer);
            power = PowerZustand.Off;
            return true;
        }

        public int Ausschalten(string irgendwas)
        {
            return 0;
        }

        public float SpannungMessen()
        {
            return 0;
        }
        #endregion
    }
}
