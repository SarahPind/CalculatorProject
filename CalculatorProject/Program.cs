using System;

namespace CalculatorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            double firstNb = Convert.ToDouble(Console.ReadLine());
            calc.Accumulator = firstNb; 

            while (true)
            {
                string operation = Console.ReadLine(); 
                double newNb = Convert.ToDouble(Console.ReadLine());

                if (operation == "+")
                {
                    double result = calc.Add(newNb); 
                    Console.WriteLine(result);
                }

                else if (operation == "-")
                {
                    double result = calc.Substact(newNb);
                    Console.WriteLine(result);
                }

                else if (operation == "*")
                {
                    double result = calc.Multiply(newNb);
                    Console.WriteLine(result);
                }

                else if (operation == "/")
                {
                    double result = calc.Divide(newNb);
                    Console.WriteLine(result);
                }

                else if (operation == "^")
                {
                    double result = calc.Power(newNb);
                    Console.WriteLine(result);
                }
            }

            // Test af Add metoden
            //Console.WriteLine("a + b er: " + calc.Add(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));

            // Test af Substact metoden
            //Console.WriteLine("a - b er: " + calc.Substact(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));

            // Test af Multiple metoden
            //Console.WriteLine("a * b er: " + calc.Multiple(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));

            // Test af Power metoden
            //Console.WriteLine("a^b er: " + calc.Power(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));

            //Test af Divide metoden
            //Console.WriteLine("a / b er: " + calc.Divide(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));

        }
    }
}
