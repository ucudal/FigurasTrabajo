using System;

namespace Ucu.Poo.Shapes
{
    public class Triangle : IFiguret
    {
        public string Type
        {
            get { return "triangle"; }
        }
        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        public double Side3 { get; private set; }

        public double Perimeter
        {
            get
            {
                return this.Side1 + this.Side2 + this.Side3;
            }
        }

        public double Area
        {
            get
            {
                double semiperimeter = this.Perimeter / 2;
                return Math.Sqrt(semiperimeter * (semiperimeter - Side1) * (semiperimeter - Side2) *
                                 (semiperimeter - Side3));
            }
        }
        public int Id { get; private set; }

        public Triangle(double side1, double side2, double side3)
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }

    }
}