using NUnit.Framework;

namespace CarDetailTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Car car = new("Toyota", "Aygo", "ASD9890548FT", 2001, 1995);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}