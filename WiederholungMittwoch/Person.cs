using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace WiederholungMittwoch
{
    public class Person
    {
        public const int MINIMUM_ALTER = 0;

        public string Vorname; //Public Field

        public string Nachname { get; set; }//Automatich Property

        private string _Mittelname;

        public string Mittelname
        {
            get { 
                return _Mittelname.ToUpper(); 
            }
            //public void setMittlename(string value)
            //{

            //}
            set {
                if (value.Length < 2)
                    throw new Exception("Mindestens 2 Zeichen");

                _Mittelname = value; 
            }
        }

        public void CalcBonus()
        {

        }

        public void CalcBonus(int x)
        {

        }

        public void CalcBonus(string x)
        {

        }
        public void CalcBonus(long x)
        {

        }

        /*nicht möglich
        public long CalcBonus(long x)
        {

        }*/

        public virtual string GetInfo()
        {
            return "ich bin eine Person";
        }

    }

    public interface ILogic
    {
        int CalcGesamtPreis();
    }
    public interface IMittwoch
    {
        int CalcGesamtPreis();
        void Ausgabe();
    }
    public sealed class ProgrammiererIn : Person, ILogic, IMittwoch, ICloneable
    {
        public override string GetInfo()
        {
            return "ich bin Programmierer";
        }

        public new void CalcBonus(long x)
        {

        }

        int ILogic.CalcGesamtPreis()
        {
            return 7;
        }

        int IMittwoch.CalcGesamtPreis()
        {
            return 12;
        }

        void IMittwoch.Ausgabe()
        {
            Console.WriteLine("Test");
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }

    public static class MyExtensions
    {
        public static void EinTest(this ProgrammiererIn prog, int i)
        {

        }
    }

    public class SortiertNachVorname : IComparer<Person>
    {
        public int Compare([AllowNull] Person x, [AllowNull] Person y)
        {
            return x.Vorname.CompareTo(y.Vorname);
        }
    }

    public class SortiertNachNachname : IComparer<Person>
    {
        public int Compare([AllowNull] Person x, [AllowNull] Person y)
        {
            return x.Nachname.CompareTo(y.Vorname);
        }
    }

}
