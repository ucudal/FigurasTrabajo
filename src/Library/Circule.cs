using System;

namespace Ucu.Poo.Shapes
{
    public class Circule : IFiguret
    {
        public double Radius { get; private set; }

        public double Perimeter
        {
            get
            {
                return 2 * Math.PI * this.Radius;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * this.Radius * this.Radius;
            }
        }
        public string Type
        {
            get { return "circule"; }
        }
        public int Id { get; private set; }

        public Circule(double radius, int id)
        {
            this.Radius = radius;
            this.Id = id;
        }
    }
}