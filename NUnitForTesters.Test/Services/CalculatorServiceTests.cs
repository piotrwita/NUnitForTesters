using NUnit.Framework;
using NUnitForTesters.Services;

namespace NUnitForTesters.Test.Services
{
    public class CalculatorServiceTests
    {
        CalculatorService calc;

        [SetUp]
        public void Setup()
        {
            calc = new CalculatorService();
        }

        [TestCase(11, 12, -1)]
        [TestCase(0, 12, -12)]
        [TestCase(-13, -12, -1)]
        public void TestAddFunction(int result, int a, int b)
        {
            Assert.AreEqual(result, calc.Add(a, b));
        }

        [Test]
        public void TestSubFunction()
        {
            Assert.AreEqual(7, calc.Sub(49, 42));
        }

        [Test]
        public void TestMulFunction()
        {
            Assert.AreEqual(-8, calc.Mul(4, -2));
        }

        [Test]
        public void TestDivFunction()
        {
            Assert.AreEqual(6, calc.Div(48, 8));
        }
    }
}