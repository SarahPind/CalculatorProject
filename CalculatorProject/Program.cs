using System;

namespace CalculatorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast et tal efterfulgt af Enter");

            double firstNb = Convert.ToDouble(Console.ReadLine());

            Calculator calc = new Calculator(firstNb);

            while (true)
            {
                Console.WriteLine("Indtast en regneoperation efterfulgt af Enter");
                string operation = Console.ReadLine();

                Console.WriteLine("Indtast et tal efterfulgt af Enter");
                double newNb = Convert.ToDouble(Console.ReadLine());

                if (operation == "+")
                {
                    double result = calc.Add(newNb); 
                    Console.WriteLine("Resultatet er: " + result);
                }

                else if (operation == "-")
                {
                    double result = calc.Substact(newNb);
                    Console.WriteLine("Resultatet er: " + result);
                }

                else if (operation == "*")
                {
                    double result = calc.Multiply(newNb);
                    Console.WriteLine("Resultatet er: " + result);
                }

                else if (operation == "/")
                {
                    double result = calc.Divide(newNb);
                    Console.WriteLine("Resultatet er: " + result);
                }

                else if (operation == "^")
                {
                    double result = calc.Power(newNb);
                    Console.WriteLine("Resultatet er: " + result);
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
