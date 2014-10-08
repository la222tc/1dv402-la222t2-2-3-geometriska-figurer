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
        private double _widht;

        public abstract double Area
        { get; }

        public double Length
        { get; set; }

        public abstract double Perineter
        { get; }

        public double Width
        { get; set; }

        protected Shape(double length, double width)
        {
                
        }

        public string ToString()
        {
            return "hej";
        }
    }
}
