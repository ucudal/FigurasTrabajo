using System;

namespace Ucu.Poo.Shapes
{
    public static class Program
    {
        public static void Main()
        {
            Square cuadrado = new Square(5, 2);
            Triangle triangle = new Triangle(4, 8, 10,4);
            Export export = new Export();
            Jason jason = new Jason();
            export.Exporting(jason,triangle);
        }
    }
}