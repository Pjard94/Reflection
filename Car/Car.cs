namespace Car
{
    public class Car
    {
        public string CarMake;
        public string CarModel;
        public string Registration;
        public int FirstRegistration;
        public int CurrentValue;
        private static readonly bool carValue;

        public Car(string make, string model, string registration, int firstRegistration, int currentValue)
        {
            CarMake = make;
            CarModel = model;
            Registration = registration;
            FirstRegistration = firstRegistration;
            CurrentValue = currentValue;
        }

        public int Value() { return CurrentValue; }

        public int Year() { return FirstRegistration; }

        public override string ToString()
        {
            return "Car: " + CarMake + ", " +
            CarModel + ", " + Registration + ", " +
            FirstRegistration + ", " + CurrentValue;
        }
    }
}