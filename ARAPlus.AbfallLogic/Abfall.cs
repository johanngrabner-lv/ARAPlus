using System;

//Firma.Technologie -- at.araplus.license (Java)
namespace ARAPlus.AbfallLogic
{
    //Neuer Datentyp
    /// <summary>
    /// Das ist eine Beschreibung
    /// </summary>
    public class Abfall
    {
        //Properties -- Get- Set - private Variablen
        //Code-Snippet -- SnippteName + Tab Tab 
        public double Gewicht { get; set; }
        /// <summary>
        /// Preis in Euro
        /// </summary>
        public decimal Preis { get; set; }
        public string Bezeichnung { get; set; }

        private int _AbweichungInProzent;

        public int AbweichungInProzent
        {
            get { return _AbweichungInProzent; }
            set { _AbweichungInProzent = value; }
        }

    }
}
