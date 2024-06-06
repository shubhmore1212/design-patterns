namespace Basics.Principles.Polymorphism
{
    public class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike is starting.");
        }

        public override void Stop()
        {
            Console.WriteLine("Bike is stopping.");
        }
    }
}
