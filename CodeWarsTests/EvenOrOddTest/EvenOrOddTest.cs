namespace CodeWarsTests
{
    internal class EvenOrOddTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("Even", EvenOrOdd.Solution(2));
            Assert.AreEqual("Odd", EvenOrOdd.Solution(1));
            Assert.AreEqual("Even", EvenOrOdd.Solution(0));
            Assert.AreEqual("Odd", EvenOrOdd.Solution(7));
            Assert.AreEqual("Odd", EvenOrOdd.Solution(-1));
        }
    }
}
