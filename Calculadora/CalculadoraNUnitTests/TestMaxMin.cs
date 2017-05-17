using NUnit.Framework;
using CalculadoraNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNS.Tests
{
    [TestFixture()]
    public class TestMaxMin
    {
       

        [Test()]
        [Sequential]
        public void maxTest([Values(1, 2, 3)] int num1, [Values(4, 5)] int num2, [Values(4, 5, 3)] int resultado)
        {
            var calculadora = new Calculadora();
            Assert.AreEqual(resultado, calculadora.max(num1, num2));
        }

        [Test()]
        [Sequential]
        public void minTest([Values(1, 2, 3)] int num1, [Values(4, 5)] int num2, [Values(1, 2, null)] int resultado)
        {
            var calculadora = new Calculadora();
            Assert.AreEqual(resultado, calculadora.min(num1, num2));
        }
        [TestCase(3, 4, ExpectedResult = 3, TestName = "min_3_4_should_be_3")]
        [TestCase(2, 4, ExpectedResult = 2)]
        [TestCase(5, 14, ExpectedResult = 5, TestName = "min_5_14_should_be_5")]
        public double minTestCases(int num1, int num2)
        {
            var calculadora = new Calculadora();
            return calculadora.min(num1, num2);
           
        }

    }
}

