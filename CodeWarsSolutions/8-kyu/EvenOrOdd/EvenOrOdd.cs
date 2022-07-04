using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
   /*

   Title: Even or Odd

   Description:
   Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.

   Kata Link:
   https://www.codewars.com/kata/53da3dbb4a5168369a0000fe/train/csharp

   */

    public class EvenOrOdd
    {
        public static string Solution(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }
    }
}
