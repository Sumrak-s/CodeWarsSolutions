using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    /*

     Title: Grasshopper - Summation

     Description:
     Write a program that finds the summation of every number from 1 to num. The number will always be a positive integer greater than 0.

     Kata Link:
     https://www.codewars.com/kata/55d24f55d7dd296eb9000030/train/csharp

     */

    public class GrasshopperSummation
    {
        public static int summation(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
