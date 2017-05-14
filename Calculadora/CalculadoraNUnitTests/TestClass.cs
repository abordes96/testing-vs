using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalculadoraNS;

namespace CalculadoraNUnitTests
{
   
    [TestFixture(1, 2, 3)]
    [TestFixture(2, 2, 4)]
    class CalculadoraText
    {
        private readonly int _num1;
        private readonly int _num2;
        private readonly int _expected;

        public CalculadoraText(int num1, int num2, int expected)
        {
            _num1 = num1;
            _num2 = num2;
            _expected = expected;
        }

        [Test]
        public void Sumar()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Sumar(_num1, _num2);
            Assert.AreEqual(_expected, resultado);
        }
    }
}
