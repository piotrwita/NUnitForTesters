using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using NUnitForTesters.Services;
using System.Threading;

namespace NUnitForTesters.Test.Services
{
    public class WeirdServiceTests
    {
        [Test, Timeout(4000)]        
        public void ShouldVoidReturnTimeout()
        {
            WeirdService.ThisMethodWillTimeout();
        }

        [TestCase(0)]
        public void ShouldReturnThrowExceptionIfParameterIsZero(int parameter)
        {      
            Assert.That(() => 
                WeirdService.ThisMethodWillThrowExceptionIfParameterIsZero(parameter),
                Throws.TypeOf<ArgumentException>());
        }

        [Test, Retry(5)]
        public void ShouldMethodWillPassSometimes()
        {
            var result = WeirdService.ThisMethodWillPassSometimes();
            Assert.Less(result, 1000); 
        }
    }
}
