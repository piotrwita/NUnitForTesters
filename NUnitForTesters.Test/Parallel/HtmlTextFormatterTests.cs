using NUnit.Framework;
using NUnitForTesters.Parallel;
using System.Threading;

namespace NUnitForTesters.Test.Parallel
{
    [Parallelizable(ParallelScope.Children)]
    public class HtmlTextFormatterTests
    {
        [TestCase("<b>text</b>", "text")]
        public void ShouldConvertTextToBoldFormat(string result, string text)
        {
            var formatter = new HtmlTextFormatter();
            var formatResult = formatter.FormatAsBold(text);

            Assert.IsNotNull(formatResult);
            StringAssert.IsMatch(formatResult, result);
        }

        [TestCase("<i>text</i>", "text")]
        public void ShouldConvertTextAsItalicFormat(string result, string text)
        {
            var formatter = new HtmlTextFormatter();
            var formatResult = formatter.FormatAsItalic(text);

            Assert.IsNotNull(formatResult);
            StringAssert.IsMatch(formatResult, result);
        }

        [TestCase("<small>text</small>", "text")]
        public void ShouldConvertTextAsSmallFormat(string result, string text)
        {
            var formatter = new HtmlTextFormatter();
            var formatResult = formatter.FormatAsSmall(text);

            Assert.IsNotNull(formatResult);
            StringAssert.IsMatch(formatResult, result);
        }

        [TestCase("<del>text</del>", "text")]
        public void ShouldConvertTextAsDeletedFormat(string result, string text)
        {
            var formatter = new HtmlTextFormatter();
            var formatResult = formatter.FormatAsDeleted(text);

            Assert.IsNotNull(formatResult);
            StringAssert.IsMatch(formatResult, result);
        }

        [TestCase("<sub>text</sub>", "text")]
        public void ShouldConvertTextAsSubscriptFormat(string result, string text)
        {
            var formatter = new HtmlTextFormatter();
            var formatResult = formatter.FormatAsSubscript(text);

            Assert.IsNotNull(formatResult);
            StringAssert.IsMatch(formatResult, result);
        }


        public string FormatAsCustomTag(string text, string customTag) => $"<{customTag}>{text}</{customTag}>";


        [TestCase("<tag>text</tag>", "text", "tag")]
        public void ShouldConvertTextAsCustomTagFormat(string result, string text, string tag)
        {
            var formatter = new HtmlTextFormatter();
            var formatResult = formatter.FormatAsCustomTag(text, tag);

            Assert.IsNotNull(formatResult);
            StringAssert.IsMatch(formatResult, result);
        }

        [TearDown]
        public void TearDown()
        {
            //Thread.Sleep(1500);
        }
    }
}
