namespace Basics.Principles.Inheritance
{
    //Inheritance allows one class to acquire the properties and methods of another class (parent class).
    public class Vehicle
    {
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine("Vehicle is starting.");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle is stopping.");
        }
    }
}
