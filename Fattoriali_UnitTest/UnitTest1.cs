using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fattoriali_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(50)]
        public void TestMethod1(long numero)
        {
            long fattoriale;

            fattoriale = EquazioniLibrary.CalcoliCombinatori.Fattoriale(numero);

            Console.WriteLine("{0}!={1}", numero, fattoriale);
        }




    }
}
