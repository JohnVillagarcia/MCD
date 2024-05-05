using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MaxCDAloritmo;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void mcd_Dos_Positivos()
        {
            int a = 12;
            int b = 18;
            int esperado = 6;
            int prueba = MaxComuDiv.mcd(a, b);
            Assert.AreEqual(esperado, prueba);
        }
        public void MCD_Cero_Positivo()
        {
            int a = 0;
            int b = 12;
            int esperado = 12;
            int prueba = MaxComuDiv.mcd(a, b);
            Assert.AreEqual(esperado, prueba);
        }
        public void MCD_Mismo_Numero()
        {
            int a = 12;
            int b = 12;
            int esperado = 12;
            int prueba = MaxComuDiv.mcd(a, b);
            Assert.AreEqual(esperado, prueba);
        }
    }
}
