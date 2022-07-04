using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    /*
    Title: Tribonacci Sequence

    Description: So, if we are to start our Tribonacci sequence with [1, 1, 1] as a starting input (AKA signature), we have this sequence:

    [1, 1 ,1, 3, 5, 9, 17, 31, ...]
    But what if we started with [0, 0, 1] as a signature? As starting with [0, 1] instead of [1, 1] basically shifts
    the common Fibonacci sequence by once place, you may be tempted to think that we would get the same sequence shifted by 2 places,
    but that is not the case and we would get:

    [0, 0, 1, 1, 2, 4, 7, 13, 24, ...]
    Well, you may have guessed it by now, but to be clear: you need to create a fibonacci function that given a signature array/list,
    returns the first n elements - signature included of the so seeded sequence.

    Signature will always contain 3 numbers; n will always be a non-negative number; if n == 0,
    then return an empty array (except in C return NULL) and be ready for anything else which is not clearly specified ;)

    Kata Link:
    https://www.codewars.com/kata/556deca17c58da83c00002db/train/csharp
    */

    public class TribonacciSequence
    {
        public static double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0) return new double[0];

            double[] result = new double[n];

            if (n <= signature.Length)
            {
                for (int i = 0; i < n; i++) result[i] = signature[i];

                return result;
            }

            for (int i = 0; i < signature.Length; i++) result[i] = signature[i];
            for (int i = 3; i < n; i++) result[i] = result[i - 1] + result[i - 2] + result[i - 3];

            return result;
        }
    }
}
