using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    internal class CreditCardMaskTest
    {
        [Test]
        public void ExamplesTests()
        {
            Assert.AreEqual("############5616", CreditCardMask.Maskify("4556364607935616"));
            Assert.AreEqual("1", CreditCardMask.Maskify("1"));
            Assert.AreEqual("#1111", CreditCardMask.Maskify("11111"));
        }
    }
}
