using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraNS
{
    public class Calculadora
    {
        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }
        public double restar(double num1, double num2)
        {
            return num1 - num2;
        }

        public double max(double num1, double num2)
        {
            if (num1 > num2) return num1;
            
            return num2;
        }

        public double min(double num1, double num2)
        {
            if (num1 < num2) return num1;

            return num2;
        }

    }
}
