using System;
using CalculatorProject;
using NUnit.Framework;


namespace Calculatornittest
{
    [TestFixture]
    public class Tests
    {
        private CalculatorProject.Calculator uut;

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2,2)]
        [TestCase(3.78,3.78)]
        [TestCase(-15.1,-15.1)]
        public void Check_Constructor_setting_Accumulator(double a, double expected)
        {
            uut = new Calculator(a);
            Assert.That(uut.Accumulator,Is.EqualTo(expected));
        }


        [TestCase(3, 4, 7)]
        [TestCase(5, 6, 11)]
        [TestCase(7, 8, 15)]
        public void Check_Add_Method_return_expected(double a, double b, double expected)
        {
            uut = new Calculator(a);
            double result = uut.Add(b);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(expected));
                Assert.That(uut.Accumulator, Is.EqualTo(expected));
            });
        }

        [TestCase(10, 5, 5)]
        [TestCase(5, 6, -1)]
        [TestCase(4.5, 1.5, 3.0)]
        public void Check_Substract_Method_return_expected(double a, double b, double expected)
        {
            uut = new Calculator(a);
            double result = uut.Substact(b);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(expected));
                Assert.That(uut.Accumulator, Is.EqualTo(expected));
            });
        }

        [Test]
        public void Check_Devide_Method_return7()
        {
            uut = new Calculator(14);
            double result = uut.Divide(2);
            double expected = 7; 

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(expected));
                Assert.That(uut.Accumulator, Is.EqualTo(expected));
            });
        }
        [Test]
        public void Check_Devide_Method_DividByZeroExc()
        {
            uut = new Calculator(14);
            Assert.Throws<DivideByZeroException>(() =>uut.Divide( 0));
        }
        [Test]
        public void Check_Devide_Method_return3_point_5()
        {
            uut = new Calculator(14);
            double result = uut.Divide(4);
            double expected = 3.5; 

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(expected));
                Assert.That(uut.Accumulator, Is.EqualTo(expected));
            });
        }

        [TestCase(3, 4, 12)]
        [TestCase(5, 5, 25)]
        [TestCase(3.23, 6.45, 20.8)]
        public void Check_Multiply_Method_return_expected(double a, double b, double expected)
        {
            uut = new Calculator(a);
            double result = uut.Multiply(b);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(expected).Within(1E-1));
                Assert.That(uut.Accumulator, Is.EqualTo(expected).Within(1E-1));
            });
        }

        [TestCase(3, 2, 9)]
        [TestCase(5, 2, 25)]
        [TestCase(2, 3, 8)]
        public void Check_Power_Method_return_expected(double a, double b, double expected)
        {
            uut = new Calculator(a);
            double result = uut.Power(b);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(expected));
                Assert.That(uut.Accumulator, Is.EqualTo(expected));
            });

        }

    }
}