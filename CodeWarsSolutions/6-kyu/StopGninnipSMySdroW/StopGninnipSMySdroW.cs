﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    /*
    Title: Stop gninnipS My sdroW!

    Description:
    Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed
    (Just like the name of this Kata).
    Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.

    Examples: 
    spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw"
    spinWords( "This is a test") => returns "This is a test"
    spinWords( "This is another test" )=> returns "This is rehtona test"

    Kata Link:
    https://www.codewars.com/kata/5264d2b162488dc400000001/train/csharp
    */

    public class StopGninnipSMySdroW
    {
        public static string SpinWords(string sentence)
        {
            var arr = sentence.Split(' ');

            for (int i = 0; i < arr.Length; i++) if (arr[i].Length >= 5) arr[i] = new string(arr[i].Reverse().ToArray());

            return string.Join(" ", arr);
        }
    }
}
