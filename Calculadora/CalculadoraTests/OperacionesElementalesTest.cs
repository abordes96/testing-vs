using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CalculadoraNS;

namespace CalculadoraNS.Tests
{
    [TestClass()]
    public class OperacionesElementalesTest
    {
        [TestMethod()]
        public void SumarTest()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Sumar(1, 2);
            Assert.AreEqual(3, resultado);
        }

        [TestMethod()]
        public void restarTest()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.restar(1, 2);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod()]
        public void metodoSinCoberturaCompletaTest()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.metodoSinCoberturaCompleta(10);
            Assert.AreEqual(1, resultado);
        }
    }
}


