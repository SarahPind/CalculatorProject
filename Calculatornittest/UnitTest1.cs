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
           Assert.That(uut.Add(3,4), Is.EqualTo(7));
        }

        [Test]
        public void Check_Devide_Method_return7()
        {
            Assert.That(uut.Divide(14, 2), Is.EqualTo(7));
        }
        [Test]
        public void Check_Devide_Method_return0()
        {
            Assert.That(uut.Divide(14, 0), Is.EqualTo(0));
        }
        [Test]
        public void Check_Devide_Method_return35()
        {
            Assert.That(uut.Divide(14, 4), Is.EqualTo(3.5));
        }

    }
}