using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fattoriali_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(5, 120)]
        public void Fattorialetest(int nr1, int nr2)
        {
            nr2 = Fattoriali_library.FAtoriali.Fattoriale(nr1);
            int resultato_asspetato = nr2;
            Assert.AreEqual(120, resultato_asspetato);
        }




    }
}
