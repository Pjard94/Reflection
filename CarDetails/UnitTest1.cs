using NUnit.Framework;
using Reflection;
using System;

namespace CarDetails
{
    public class Tests
    {

        [Test]
        public void CarYear()
        {

         string CarMake = "Toyota";
         string CarModel = "Aygo";
         string Registration = "ASD9890548FT";
         int FirstRegistration = 2001;
         int CurrentValue = 1995;


        Car car = new(CarMake, CarModel, Registration, FirstRegistration, CurrentValue);

            var expected = 2001;

            Assert.AreEqual(expected, car.Year());
        

        }

        [Test]
        public void CurrentValue()
        {

            string CarMake = "Toyota";
            string CarModel = "Aygo";
            string Registration = "ASD9890548FT";
            int FirstRegistration = 2001;
            int CurrentValue = 1995;


            Car car = new(CarMake, CarModel, Registration, FirstRegistration, CurrentValue);

            var expected = 1995;

            Assert.AreEqual(expected, car.Value());


        }

        [Test]
        public void CarDetails()
        {

            string CarMake = "Toyota";
            string CarModel = "Aygo";
            string Registration = "ASD9890548FT";
            int FirstRegistration = 2001;
            int CurrentValue = 1995;


            Car car = new(CarMake, CarModel, Registration, FirstRegistration, CurrentValue);

            var expected = "Car: Toyota, Aygo, ASD9890548FT, 2001, 1995";

            Assert.AreEqual(expected, car.ToString());


        }
    }
}