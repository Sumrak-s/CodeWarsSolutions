using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    internal class ConsecutiveStringsTest
    {
        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public static void test1()
        {
            Console.WriteLine("Basic Tests");
            testing(ConsecutiveStrings.LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2), "abigailtheta");
            testing(ConsecutiveStrings.LongestConsec(new String[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1), "oocccffuucccjjjkkkjyyyeehh");
            testing(ConsecutiveStrings.LongestConsec(new String[] { }, 3), "");
            testing(ConsecutiveStrings.LongestConsec(new String[] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" }, 2), "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck");
            testing(ConsecutiveStrings.LongestConsec(new String[] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2), "wlwsasphmxxowiaxujylentrklctozmymu");
            testing(ConsecutiveStrings.LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas" }, -2), "");
            testing(ConsecutiveStrings.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3), "ixoyx3452zzzzzzzzzzzz");
            testing(ConsecutiveStrings.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 15), "");
            testing(ConsecutiveStrings.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0), "");
        }
    }
}
