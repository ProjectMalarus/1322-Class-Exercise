using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1322_Class_Exercise
{
    internal interface Shape
    {
        public double getArea();
        public double getPerimeter();

        public bool areaGreaterThan(Shape s);

        public bool perimeterGreaterThan(Shape s);

        public bool isValid();
    }
}
