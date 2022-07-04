using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    /*
    Title: Highest and Lowest

    Description: In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

    Examples:
    Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
    Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
    Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"

    Kata Link:
    https://www.codewars.com/kata/554b4ac871d6813a03000035/train/csharp
    */

    public class HighestAndLowest
    {
        public static string HighAndLow(string numbers)
        {
            var array = numbers.Split(' ');
            return $"{Max(array)} {Min(array)}";
        }

        private static int Min(string[] array)
        {
            int result = int.Parse(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                if (int.Parse(array[i]) < result) result = int.Parse(array[i]);
            }
            return result;
        }
        private static int Max(string[] array)
        {
            int result = int.Parse(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                if (int.Parse(array[i]) > result) result = int.Parse(array[i]);
            }
            return result;
        }
    }
}
