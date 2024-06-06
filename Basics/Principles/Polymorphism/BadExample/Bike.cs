namespace Basics.Principles.Polymorphism.BadExample
{
    public class Bike
    {
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; }= string.Empty;
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine("Bike is starting.");
        }

        public void Stop()
        {
            Console.WriteLine("Bike is stopping.");
        }
    }
}
