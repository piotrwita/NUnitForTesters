using NUnit.Framework;
using NUnitForTesters.Services;

namespace NUnitForTesters.Test.Services
{
    public class NumberServiceTests
    {
        [Test]
        public void ShouldMyNumberReturnUnexpectedEffect([Range(0, 100)] int num)
        {
            var number = new NumberService();
            var numberResult = number.IsItTheAnswerToUltimateQuestionOfLife(num);
            StringAssert.DoesNotMatch(numberResult, "That should not happen at all");
        }
    }
}
