using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    internal class MakeUpperCaseTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("HELLO", MakeUpperCase.Solution("hello"));
        }
    }
}
