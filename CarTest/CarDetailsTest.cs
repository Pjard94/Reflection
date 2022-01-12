using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reflection.Car;

namespace CarTest
{
    [TestClass]
    public class CarDetailsTest
    {
        [TestMethod]
        public void CarDetailsTestMethod()
        {
                Car car = new("Toyota", "Aygo", "ASD9890548FT", 2001, 1995);

    }
}
}