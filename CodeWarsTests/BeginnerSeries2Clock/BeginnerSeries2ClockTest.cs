using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    internal class BeginnerSeries2ClockTest
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(61000, BeginnerSeries2Clock.Past(0, 1, 1));
        }
    }
}
