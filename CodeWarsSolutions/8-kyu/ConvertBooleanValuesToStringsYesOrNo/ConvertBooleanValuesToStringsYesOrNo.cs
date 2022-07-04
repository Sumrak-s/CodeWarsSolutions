using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public class ConvertBooleanValuesToStringsYesOrNo
    {

        /*
        Title: Convert boolean values to strings 'Yes' or 'No'.

        Description:
        Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.

        Kata Link:
        https://www.codewars.com/kata/53369039d7ab3ac506000467/train/csharp
        */

        public static string boolToWord(bool word)
        {
            return word ? "Yes" : "No";
        }
    }
}
