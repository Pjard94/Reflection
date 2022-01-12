using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Car
    {
        public string CarMake;
        public string CarModel;
        public string Registration;
        public int FirstRegistration;
        public int CurrentValue;

        public Car (string make, string model, string registration, int firstRegistration, int currentValue)
        {
            CarMake = make;
            CarModel = model;
            Registration = registration;
            FirstRegistration = firstRegistration;
            CurrentValue = currentValue;
        }
        Car car = new("Toyota", "Aygo", "ASD9890548FT", 2001, 1995);
        public int Value() {   return CurrentValue; }

        public int Year() { return FirstRegistration; }

        public override string ToString() 
        {
           return "Car: " + CarMake + ", " + 
           CarModel + ", " + Registration + ", " +
           FirstRegistration + ", " + CurrentValue;
        }

    }

   

}
