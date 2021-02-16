using ARAPlus.DelegatesFuncActionEvents;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNamespace
{
    public static class LagerExtension
    {
        public static double GetLagerwert(this Lager lager, double stueckPreis)
        {
            return lager.Lagerbestand * stueckPreis;
        }

    }
}
