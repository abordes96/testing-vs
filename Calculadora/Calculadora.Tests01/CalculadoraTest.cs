// <copyright file="CalculadoraTest.cs">Copyright ©  2017</copyright>

using System;
using CalculadoraNS;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraNS.Tests
{
    [TestClass]
    [PexClass(typeof(Calculadora))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CalculadoraTest
    {

        [PexMethod]
        public string tipoTriangulo(
            int a,
            int b,
            int c
        )
        {
            string result = Calculadora.tipoTriangulo(a, b, c);
            return result;
            // TODO: agregar aserciones a método CalculadoraTest.tipoTriangulo(Int32, Int32, Int32)
          
        }
    }
}
