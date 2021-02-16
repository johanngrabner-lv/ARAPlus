using System;
using System.Collections.Generic;
using System.Text;

namespace Grabner.Demo
{
    public interface IPersistence
    {
        void Load();
        void Save();
    }
    public abstract class MyStarter
    {
        public abstract void TuerOeffnen();
    }
    public class Fahrzeug: MyStarter, IDisposable, IPersistence
    {
        public string Marke { get; set; }
        private int _PS;

        public int PS
        {
            get { return _PS; }
            set { _PS = value; }
        }
        public int AktuelleGeschwindigkeit { get; set; }
        public Fahrzeug():this(0)
        {

        }
        public Fahrzeug(int ps)
        {
            PS = ps;
        }

        public virtual void Beschleunigen()
        {
            Console.WriteLine("fahrzeug beschleunigt");
            AktuelleGeschwindigkeit++;
        }

        ~Fahrzeug()
        {
            //Release Non-Memory db.Close
        }
        public void Dispose()
        {
            //Release Non-Memory db.Close
            GC.SuppressFinalize(this);
        }

        public override void TuerOeffnen()
        {
            Console.WriteLine("Tür offnen");
        }

        public void Load()
        {
            Console.WriteLine("Load");
        }

        //Explizite Interface-Implementierung
        void IPersistence.Save()
        {
            Console.WriteLine("Load");
        }
    }
}
