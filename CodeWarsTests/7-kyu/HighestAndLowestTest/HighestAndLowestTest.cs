using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    internal class HighestAndLowestTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("42 -9", HighestAndLowest.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual("3 1", HighestAndLowest.HighAndLow("1 2 3"));
        }
    }
}
