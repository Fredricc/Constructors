namespace Constructors
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized.");
        //}
        public Vehicle(string RegistrationNumber)
        {
           _registrationNumber = RegistrationNumber;
            Console.WriteLine($"Vehicle is being initialized. {_registrationNumber}");
        }
    }

    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base( registrationNumber )
        {
            Console.WriteLine($"Car is being initialized. {registrationNumber}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("KBL 149L");
        }
    }
}