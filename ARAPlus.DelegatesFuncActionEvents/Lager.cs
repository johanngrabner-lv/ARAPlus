using System;
using System.Collections.Generic;
using System.Text;

namespace ARAPlus.DelegatesFuncActionEvents
{
    public class Lager: System.Object, IPrintable, IDisposable
    {
        //public delegate Membervariable
        //1. event anbieten
        public event Action<string> OnLagerUberschritten;
        public int Lagerbestand { get; set; }

        public void AddToLager(int stueck)
        {
            Lagerbestand += stueck;

            if (Lagerbestand>100 && OnLagerUberschritten!=null)
            {
                //Raise an event
                OnLagerUberschritten($"aktuller Lagerbestand: {Lagerbestand}");
            }
        }
        ~Lager()
        {

        }
        public void Print()
        {
            Console.WriteLine("wurde gedruckt");
        }

        public void Dispose()
        {
           //Release Non-Memory Ressources
        }
    }
}
