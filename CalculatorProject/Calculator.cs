using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject
{
    public class Calculator
    {
        public double Accumulator { get; set; } = 0;

        private double a;
        
        public double Add(double a)
        {
            Accumulator += a;
            return Accumulator; 
        }

        public double Substact(double a)
        {
            Accumulator -= a;
            return Accumulator; 
        }

        public double Multiply(double a)
        {
            Accumulator = Accumulator * a;
            return Accumulator; 
        }

        public double Divide(double a)
        {
            if (a != 0)
            {
                Accumulator = Accumulator / a;
            }
            else
                Console.WriteLine("Fejl");
            return Accumulator;
        }

        public double Power(double a)
        {
            return Math.Pow(Accumulator,a);
        }
        

    }
}
