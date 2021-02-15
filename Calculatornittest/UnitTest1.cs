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

        [TestCase(3, 4, 7)]
        [TestCase(5, 6, 11)]
        [TestCase(7, 8, 15)]
        public void Check_Add_Method_return_expected(double a, double b, double expected)
        {
            uut = new Calculator(a);
            double result = uut.Add(b);
            Assert.That(result,Is.EqualTo(expected));
        }

        [TestCase(10, 5, 5)]
        [TestCase(5, 6, -1)]
        [TestCase(4.5, 1.5, 3.0)]
        public void Check_Substract_Method_return_expected(double a, double b, double expected)
        {
            uut = new Calculator(a);
            double result = uut.Substact(b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Check_Devide_Method_return7()
        {
            uut = new Calculator(14);
            Assert.That(uut.Divide( 2), Is.EqualTo(7));
        }
        [Test]
        public void Check_Devide_Method_return14()
        {
            uut = new Calculator(14);
            Assert.That(uut.Divide( 0), Is.EqualTo(14));
        }
        [Test]
        public void Check_Devide_Method_return3_point_5()
        {
            uut = new Calculator(14);
            Assert.That(uut.Divide( 4), Is.EqualTo(3.5));
        }

    }
}