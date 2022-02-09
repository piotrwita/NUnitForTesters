using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnitForTesters.Services
{
    public class WeirdService
    {
        public static string ThisMethodWillTimeout()
        {
            Thread.Sleep(3000);
            return "This method should timeout";
        }

        public static double ThisMethodWillThrowExceptionIfParameterIsZero(int parameter)
        {
            if (parameter == 0)
                throw new ArgumentException("Parameter cannot be zero");
            else 
                return 100 / parameter;
        }

        public static int ThisMethodWillPassSometimes()
        {

            Random rnd = new Random();
            int timeout = rnd.Next(500, 1500);
            return timeout;
        }


    }
}
