using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTests
{
    internal class ConvertBooleanValuesToStringsYesOrNoTest
    {
        [Test]
        public void boolToWordReturned1()
        {
            Assert.AreEqual("Yes", ConvertBooleanValuesToStringsYesOrNo.boolToWord(true));
            Console.WriteLine("Expected Yes");
        }

        [Test]
        public void boolToWordReturned2()
        {
            Assert.AreEqual("No", ConvertBooleanValuesToStringsYesOrNo.boolToWord(false));
            Console.WriteLine("Expected No");
        }

        [Test]
        public void boolToWordReturned3()
        {
            Assert.AreEqual("Yes", ConvertBooleanValuesToStringsYesOrNo.boolToWord(true));
            Console.WriteLine("Expected Yes");
        }
    }
}
