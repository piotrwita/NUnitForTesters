using NUnit.Framework;
using NUnitForTesters.Services;

namespace NUnitForTesters.Test.Services
{
    public class NumberServiceTests
    {
        private NumberService _numberService;
        [SetUp]
        public void Setup()
        {
            _numberService = new NumberService();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _numberService.IsPrime(1);
            Assert.IsFalse(result, "1 should not be prime");
        }

        [Test]
        public void TestRangeForUnexpectedValue([Range(1,100)] int i)
        {
            string answer = _numberService.IsItTheAnswerToUltimateQuestionOfLife(i);
            StringAssert.DoesNotMatch(answer, "That should not happen at all");
        }
    }
}
