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
            uut = new Calculator();
        }

        [Test]
        public void Check_Add_Method()
        {
            uut.Accumulator = 3;
            Assert.That(uut.Add(4), Is.EqualTo(7));
        }

        [Test]
        public void Check_Devide_Method_return7()
        {
            uut.Accumulator = 14;
            Assert.That(uut.Divide( 2), Is.EqualTo(7));
        }
        [Test]
        public void Check_Devide_Method_return0()
        {
            uut.Accumulator = 14;
            Assert.That(uut.Divide( 0), Is.EqualTo(0));
        }
        [Test]
        public void Check_Devide_Method_return35()
        {
            uut.Accumulator = 14;
            Assert.That(uut.Divide( 4), Is.EqualTo(3.5));
        }

    }
}