using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{
    internal class Circle
    {
        //properties
        public double Radius;



        //constructor
        public Circle(double _radius)
        {
            Radius = _radius;
        }


        //methods
        public double CalculateCircumference()
        {
            double circumference = 2 * Math.PI * Radius;
            return circumference;
        }

        public double CalculateArea()
        {
            double area = Math.PI * (Radius * Radius);
            return area;
        }

        public string CalculateFormattedCircumference(double x)
        {
            double roundedx = Math.Round(x, 2);
            return FormatNumber(roundedx);
        }

        public string CalculateFormattedArea(double y)
        {
            double roundedY = Math.Round(y, 2);
            return FormatNumber(roundedY);
        }

        private string FormatNumber(double x)
        {
            return x.ToString();
        }

    }
}
