// <copyright file="CalculadoraTest.cs">Copyright ©  2017</copyright>
using System;
using CalculadoraNS;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraNS.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para Calculadora</summary>
    [PexClass(typeof(Calculadora))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CalculadoraTest
    {
        /// <summary>Código auxiliar de prueba para Sumar(Double, Double)</summary>
        [PexMethod]
        public double SumarTest(
            [PexAssumeUnderTest]Calculadora target,
            double num1,
            double num2
        )
        {
            double result = target.Sumar(num1, num2);
            return result;
            // TODO: agregar aserciones a método CalculadoraTest.SumarTest(Calculadora, Double, Double)
        }

        /// <summary>Código auxiliar de prueba para max(Double, Double)</summary>
        [PexMethod]
        public double maxTest(
            [PexAssumeUnderTest]Calculadora target,
            double num1,
            double num2
        )
        {
            double result = target.max(num1, num2);
            return result;
            // TODO: agregar aserciones a método CalculadoraTest.maxTest(Calculadora, Double, Double)
        }

        /// <summary>Código auxiliar de prueba para min(Double, Double)</summary>
        [PexMethod]
        public double minTest(
            [PexAssumeUnderTest]Calculadora target,
            double num1,
            double num2
        )
        {
            double result = target.min(num1, num2);
            return result;
            // TODO: agregar aserciones a método CalculadoraTest.minTest(Calculadora, Double, Double)
        }

        /// <summary>Código auxiliar de prueba para restar(Double, Double)</summary>
        [PexMethod]
        public double restarTest(
            [PexAssumeUnderTest]Calculadora target,
            double num1,
            double num2
        )
        {
            double result = target.restar(num1, num2);
            return result;
            // TODO: agregar aserciones a método CalculadoraTest.restarTest(Calculadora, Double, Double)
        }
    }
}
