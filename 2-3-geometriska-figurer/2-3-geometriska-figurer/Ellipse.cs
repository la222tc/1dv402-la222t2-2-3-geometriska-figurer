using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    class Ellipse : Shape
    {
        public override double Area
        {
            get { return Math.PI * Length * Width; }
        }

        public override double Perimeter
        {
            get { return 2 * Math.PI * Math.Sqrt((Length * Length + Width * Width) / 2); }
        }

        public Ellipse(double length, double width)
            : base(length, width)
        {

        }
    }
}