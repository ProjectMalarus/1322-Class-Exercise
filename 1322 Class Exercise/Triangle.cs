using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1322_Class_Exercise
{
    internal class Triangle : Shape
    {
        private double bottom;
        private double height;
        private double perimeter;
        private double area;

        public Triangle()
        {
            bottom = 5.0;
            height = 3;
        }

        public Triangle(double b, double h)
        {
            
        }

        public void setBase(double b)
        {
            if (b > 0) {  bottom = b; }
        }

        public void setHeight (double h)
        {
            if (h > 0) {  height = h; }
        }

        public double getArea()
        {
            area = (bottom * height) / 2;
            return area;
        }

        public double getPerimeter()
        {
            perimeter = 3 * bottom;
            return perimeter;
        }

        public bool areaGreaterThan(Shape s)
        {
            if (area  > s.getArea())
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
