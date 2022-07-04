using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    /*
    Title: Consecutive strings

    Description: You are given an array(list) strarr of strings and an integer k. 
    Your task is to return the first longest string consisting of k consecutive strings taken in the array.

    Kata Link:
    https://www.codewars.com/kata/56a5d994ac971f1ac500003e/train/csharp
    */

    public class ConsecutiveStrings
    {
        public static string LongestConsec(string[] strarr, int k)
        {
            if (strarr.Length < k) return "";

            string longestString = "";

            for (int i = 0; i <= strarr.Length - k; i++)
            {
                var currentString = "";
                for (int y = i; y < i + k; y++) currentString += strarr[y];
                if (longestString.Length < currentString.Length) longestString = currentString;
            }

            return longestString;
        }
    }
}
