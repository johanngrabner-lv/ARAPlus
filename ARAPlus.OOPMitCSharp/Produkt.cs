using System;
using System.Collections.Generic;
using System.Text;

namespace ARAPlus.OOPMitCSharp
{
    //POCO - Plain old CLR Object
    //DTO - Data Transfer objects
    class Produkt
    {
        public int ProduktId { get; set; }
        public string Bezeichnung { get; set; }
        public double Preis { get; set; }

        public double CalcNettoPreis()
        {
            double nettoPreis = 0;
            nettoPreis = Preis/ 120 * 100;
            return nettoPreis;
        }

        //Overloading
        public double CalcNettoPreis(double steuersatz)
        {
            double nettoPreis = 0;
            nettoPreis = Preis / (100 + steuersatz)  * 100;
            return nettoPreis;
        }
        public double CalcNettoPreis(double steuersatz, double abzug=0)
        {
            double nettoPreis = 0;
            nettoPreis = Preis / (100 + steuersatz) * 100 - abzug ;
            return nettoPreis;
        }



    }
}
