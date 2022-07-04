using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    /*
     Title: Beginner Series #2 Clock

     Description:
     Clock shows h hours, m minutes and s seconds after midnight.
     Your task is to write a function which returns the time since midnight in milliseconds.

     Kata Link:
     https://www.codewars.com/kata/55f9bca8ecaa9eac7100004a/train/csharp
     */

    public class BeginnerSeries2Clock
    {
        public static int Past(int h, int m, int s)
        {
            int result = 0;

            if (h != 0 || h < 0) result += h * 3600;
            if (m != 0 || m < 0) result += m * 60;
            if (s >= 0) result += s;

            return result * 1000;
        }
    }
}
