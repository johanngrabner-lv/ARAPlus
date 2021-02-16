using ARAPlus.OOPMitCSharp;
using System;
using Xunit;

namespace XUnitProduktTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Test Driven Development , Test First
            Produkt p = new Produkt();
            double actual, expexted = 100;
            p.Preis = 120;
            actual = p.CalcNettoPreis();

            Assert.Equal(expexted, actual);

        }

        [Fact]
        public void Test2()
        {
            //Test Driven Development , Test First
            Produkt p = new Produkt();
            p.Preis = 120;
            double actual, expexted = 100;
            actual = p.CalcNettoPreis(10);

            Assert.Equal(expexted, actual);

        }

        [Fact]
        public void Test3()
        {
            //Test Driven Development , Test First
            Produkt p = new Produkt();
            p.Bezeichnung = "Handy";
            p.Preis = 120;
            double actual, expexted = 5;
            actual = p.GetLengthBezeichnung();

            Assert.Equal(expexted, actual);

        }

        [Fact]
        public void Test4()
        {
            //Test Driven Development , Test First
            Produkt p = new Produkt();
            p.Bezeichnung = "Handy";
            p.Preis = 120;
            double actual, expexted = 5;
            actual = p.GetLengthBezeichnung("Hello");

            Assert.Equal(expexted, actual);

        }
    }
}
