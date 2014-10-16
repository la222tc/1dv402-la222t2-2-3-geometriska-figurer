using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{


    abstract class Shape
    {
        private double _length;
        private double _width;

        public abstract double Area
        { get; }

        public double Length
        {
            get { return _length; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _length = value;
            }

        }

        public abstract double Perimeter
        { get; }

        public double Width
        {
            get { return _width; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _width = value;
            }
        }

        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override string ToString()
        {
            return String.Format("Längd:        {0}\nBredd:        {1}\nOmkrets:      {2:0.0}\nArea:        {3:0.0}\n ",
                Length, Width, Perimeter, Area);
        }
    }
}
