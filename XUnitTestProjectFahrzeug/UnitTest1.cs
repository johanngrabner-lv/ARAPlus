using System;
using Xunit;
using Grabner.Demo;

namespace XUnitTestProjectFahrzeug
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Fahrzeug f = new Fahrzeug(10);
            int expected = 0;
            Assert.Equal(f.AktuelleGeschwindigkeit, expected);



        }
    }
}
