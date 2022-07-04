using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    internal class OppositeNumberTest
    {
        [Test]
        public void Test_1()
        {
            Assert.AreEqual(-1, OppositeNumber.Opposite(1));
        }
    }
}
