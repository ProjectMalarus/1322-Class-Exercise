using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1322_Class_Exercise
{
    internal class Circle : Shape
    {
        private double radius;
        private double circumference;
        private double area;

        public Circle()
        {
            radius = 0.5;
        }

        public Circle(double r)
        {
            radius = r;
        }

        public double getArea()
        {
            area = Math.PI * (radius * radius);
            return area;
        }

        public double getPerimeter()
        {
            circumference = 2 * Math.PI * radius;
            return circumference;
        }

        public bool areaGreaterThan(Shape shape)
        {
            double sArea = shape.getArea();
            if (sArea < area)
            {
                return true;
            }
            return false;
        }

        public bool perimeterGreaterThan(Shape shape)
        {
            double sPerimeter = shape.getPerimeter();

            if (sPerimeter < circumference)
            {
                return true;
            }
            return false;
        }

        public bool isValid()
        {
                return true;
        }
    }
}
