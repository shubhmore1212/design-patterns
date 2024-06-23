namespace Basics.SOLID.I.BetterExample
{
    public class Sphere : IShape3D
    {
        public double Radius { get; set; }

        public double Area()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        public double Volume()
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(Radius, 3);
        }
    }
}