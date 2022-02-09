using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using NUnitForTesters.Services;
using System.Threading;

namespace NUnitForTesters.Test.Services
{
    [TestFixture]
    public class WeirdServiceTests
    {
        [Test]
        public void TestExceptionMethod()
        {
            var ex = Assert.Throws<ArgumentException>(() => WeirdService.ThisMethodWillThrowExceptionIfParameterIsZero(0));
            Assert.That(ex.Message, Is.EqualTo("Parameter cannot be zero"));
        }

        [Test, Retry(5)]
        public void TestMethodThatPassSometimes()
        {
            var result = WeirdService.ThisMethodWillPassSometimes();
            Thread.Sleep(1000);
            Assert.That(result, Is.LessThanOrEqualTo(1000));
        }

    }
}
