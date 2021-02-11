using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject
{
    public class Calculator
    {
        private double a;
        private double b;
        
        //public Calculator(double a, double b, double x)
        //{
        //    this.a = a;
        //    this.b = b;
        //    this.x = x;
        //}

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Substact(double a, double b)
        {
            return a - b;
        }

        public double Multiple(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            var c=0.0;
            if (b != 0)
            {
                c = a / b;
            }
            else
                c = 0.0;
            return c;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a,b);
        }
        ♣

    }
}
