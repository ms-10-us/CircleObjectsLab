using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjectsLab
{
    internal class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateDiameter()
        {
            double diameter = 2 * radius;
            return diameter;
        }

        public double CalculateCircumference()
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }

        public double CalculateArea()
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public void Grow()
        {
            radius = 2 * radius;
            double diameter = CalculateDiameter();
            double circumference = CalculateCircumference();
            double area = CalculateArea();

            Console.WriteLine($"Diameter: {diameter}");
            Console.WriteLine($"Circumference: {circumference}");
            Console.WriteLine($"Area: {area}");
        }

        public double GetRadius()
        {
            return radius;
        }
    }
}
