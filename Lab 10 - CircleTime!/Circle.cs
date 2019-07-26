using System;
using System.Collections.Generic;
using System.Text;


namespace Lab_10___CircleTime_
{
    class Circle
    {
        //field start with a lower case camelCase
        private double _radius;

        //property are Capitalized PascalCase
        public double Radius
        {
            get
            {
                return  _radius;
            }
            set
            {
                _radius = value;
            }
        }

        //Constructor
        public Circle (double radius)
        {
            _radius = radius;
        }


        //methods
        public double CalculateCircumference()
        {
            return 2 * Math.PI * _radius;
        }
        public double CalculateArea()
        {
           return Math.PI * Math.Pow(_radius, 2);
            
        }
        public string CalculateFormatedArea()
        {
            double result = Math.Round(CalculateArea(), 2);
            return result.ToString();
        }
        public string  CalculateFormatedCircumference()
        {
            double result = Math.Round(CalculateCircumference(), 2);
            return result.ToString();
        }
    }
}
