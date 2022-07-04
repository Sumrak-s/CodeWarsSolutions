namespace CodeWarsTests
{
    public class MultiplyTest
    {

        [Test]
        public void ShouldMultiple()
        {
            Assert.AreEqual(2, Multiply.multiply(2, 1));
            Assert.AreEqual(8, Multiply.multiply(2, 4));
        }
    }
}