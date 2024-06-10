using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sportboot
{
    public class Sportboot
    {
        /*
         * Die Eigenschaften Bootsnummer, Laenge, Motorleistung sind privat, da diese Eigenschaften der Klasse Sportboot nicht mehr im Nachhinein geändert
         * werden sollten und nur für die interene Klasse bestimmt sind (toString()). Gewicht und Führerscheinplicht ist öffentlich, da auf diese Eigenschaften
         * zugegriffen werden muss, um die Eigenschaften auszulesen.
        */

        public Sportboot() : this(111, 11, 11) { }
        
        public Sportboot(int pBootsnummer, int pLaenge, int pMotorleistung)
        {
            Bootsnummer = pBootsnummer;
            Laenge = pLaenge;
            Motorleistung = pMotorleistung;
        }

        public override string ToString()
        {
            return $"Bootsnummer: {Bootsnummer}, Länge: {Laenge} m, Motorleistung: {Motorleistung} kW";
        }

        private int Bootsnummer
        {
            get;
            set;
        }

        private int Laenge
        {
            get;
            set;
        }

        private int Motorleistung
        {
            get;
            set;
        }

        public bool FuehrerscheinPlicht
        {
            get
            {
                if(Motorleistung > 11 || Laenge >= 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public double Gewicht
        {
            get
            {
                return (275 * Laenge) - 1125;
            }
        }
    }
}