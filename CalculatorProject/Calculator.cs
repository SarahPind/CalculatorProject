using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CalculatorProject
{
    public class Calculator
    {
        public double Accumulator { get; private set; } = 0;

        private double a;

        public Calculator(double firstNb)
        {
            Accumulator = firstNb; 
        }
        
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
            if (a == 0)
            {
                throw new DivideByZeroException();
            }
            Accumulator = Accumulator / a;
            
            return Accumulator;
        }

        public double Power(double a)
        {
            return Math.Pow(Accumulator,a);
        }
        

    }
}
