﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    /*
    Title: Credit Card Mask

    Description: Usually when you buy something, you're asked whether your credit card number,
    phone number or answer to your most secret question is still correct. However, since someone could look over your shoulder,
    you don't want that shown on your screen. Instead, we mask it.

    Your task is to write a function maskify, which changes all but the last four characters into '#'.
    Examples:
    "4556364607935616" --> "############5616"
     "64607935616" -->      "#######5616"
               "1" -->                "1"
                "" -->                 ""

    // "What was the name of your first pet?"

    "Skippy" --> "##ippy"

    "Nananananananananananananananana Batman!"
    -->
    "####################################man!"

    Kata Link:
    https://www.codewars.com/kata/5412509bd436bd33920011bc/train/csharp
    */

    public class CreditCardMask
    {
        public static string Maskify(string cc)
        {
            if (cc.Length > 4)
            {
                char[] result = cc.ToCharArray();
                for (int i = 0; i < cc.Length - 4; i++) result[i] = '#';
                return new string(result);
            }

            return cc;
        }
    }
}