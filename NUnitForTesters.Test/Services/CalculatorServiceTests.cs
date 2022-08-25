using NUnit.Framework;
using NUnitForTesters.Services;

namespace NUnitForTesters.Test.Services
{
    public class CalculatorServiceTests
    {
        [TestCase(3, 1, 2)]
        [TestCase(5, 2, 3)]
        public void ShouldSumTwoPositionNumber(int result, int a, int b)
        {
            var calculator = new CalculatorService();
            var addResult = calculator.Add(a, b);
            Assert.That(addResult, Is.EqualTo(result));
        }
        [TestCase(1, 2, 1)]
        public void ShouldSubTwoPositionNumber(int result, int a, int b)
        {
            var calculator = new CalculatorService();
            var addResult = calculator.Sub(a, b);
            Assert.That(addResult, Is.EqualTo(result));
        }
        [TestCase(4, 2, 2)]
        public void ShouldMultiTwoPositionNumber(int result, int a, int b)
        {
            var calculator = new CalculatorService();
            var addResult = calculator.Mul(a, b);
            Assert.That(addResult, Is.EqualTo(result));
        }
        [TestCase(1, 2, 2)]
        public void ShouldDivTwoPositionNumber(int result, int a, int b)
        {
            var calculator = new CalculatorService();
            var addResult = calculator.Div(a, b);
            Assert.That(addResult, Is.EqualTo(result));
        }
    }
}