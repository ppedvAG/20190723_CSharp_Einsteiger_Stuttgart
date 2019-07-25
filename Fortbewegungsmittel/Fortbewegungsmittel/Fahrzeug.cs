using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortbewegungsmittel
{
    public enum Zustand { stehend = 1, fahrend };
    public class Fahrzeug
    {
        // prop TAB TAB
        // public Property ohne Feld
        // propfull TAB TAB
        // public Property + private Feld

        #region Felder
        private Zustand aktuellerZustand;
        private string name;
        private const double maximalGeschwindigkeit = 250.00;

        private double aktuelleGeschwindigkeit;
        #endregion

        #region Eigenschaften
        public Zustand AktuellerZustand
        {
            get
            {
                if(aktuelleGeschwindigkeit > 0 )
                {
                    return aktuellerZustand = Zustand.fahrend;
                } else
                {
                    return aktuellerZustand = Zustand.stehend;
                }
            }
            private set
            {
                    aktuellerZustand = value;                
            }
        }
        public double AktuelleGeschwindigkeit
        {
            get { return aktuelleGeschwindigkeit; }
            private set { aktuelleGeschwindigkeit = value; }
        }
        public decimal Preis { get; set; }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        #endregion Eigenscahften

        #region Konstruktor
        public Fahrzeug()
        {
            aktuelleGeschwindigkeit = 0;
        }
        public Fahrzeug(string Name, decimal Preis)
        {
            aktuelleGeschwindigkeit = 0;
            name = Name;
            this.Preis = Preis;
        }
        #endregion Konstruktor

        #region Methoden
        public void Beschleunige(double BeschleunigungsWert)
        {
            if (!(aktuelleGeschwindigkeit + BeschleunigungsWert >= maximalGeschwindigkeit))
            {
                aktuelleGeschwindigkeit += BeschleunigungsWert;
                Console.WriteLine($"Beschleunige um {BeschleunigungsWert}");
            } else
            {
                Console.WriteLine($"Maximalgeschwindigkeit erreicht ...");
            }
        }
        public void StarteMotor()
        {
            Console.WriteLine("Motor wurde gestartet");
        }
        public void StoppeMotor()
        {
            Console.WriteLine("Motor wurde gestoppt...");
            aktuelleGeschwindigkeit = 0.00;
        }
        public void BeschreibeMich()
        {
            Console.WriteLine($"Fahrzeugname: {Name}, Aktueller Zustand: {AktuellerZustand}, Preis: {Preis}, Max-Geschw: {maximalGeschwindigkeit}, aktuelle Geschw.: {aktuelleGeschwindigkeit}");
        }
        #endregion Methoden
    }
}
