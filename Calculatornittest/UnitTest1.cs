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


    }
}