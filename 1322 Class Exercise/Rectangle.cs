using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1322_Class_Exercise
{
    internal class Rectangle : Shape
    {
        private double length;
        private double width;
        private double perimeter;
        private double area;

        public Rectangle()
        {
            length = 8;
            width = 4;
            
        }

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public double getArea()
        {
            area = length * width;
            return area;
        }

        public double getPerimeter()
        {
            perimeter = (2 * length) + (2 * width);
            return perimeter;
        }

        public bool areaGreaterThan(Shape s)
        {
            if (area > s.getArea())
            {
                return true;
            }
            return false;
        }

        public bool perimeterGreaterThan(Shape s)
        {
            if (perimeter > s.getPerimeter())
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
