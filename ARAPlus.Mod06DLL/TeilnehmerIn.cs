using System;

namespace ARAPlus.Mod06DLL
{
    public class TeilnehmerIn
    {
        public int ID { get; set; }
        public string Vorname { get; set; }

        public override string ToString()
        {
            return $"Id: {ID} Vorname: {Vorname}";
        }

        public Geschlecht Geschlecht { get; set; }

        public Wetter Lieblingswetter{ get; set; }

        public (string,int) GetInfo()
        {
            return (Vorname, ID);
        }
    }
}
