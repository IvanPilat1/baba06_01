using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public class Trapezium : Shape
    {
        public double C { get; set; } // Перша основа трапеції
        public double D { get; set; } // Друга основа трапеції
        public double H { get; set; } // Висота трапеції

        public override double GetPerimeter()
        {
            double X = Math.Sqrt(Math.Pow(0.5 * (C - D), 2) + Math.Pow(H, 2));
            return 2 * X + D + C;
        }
    }

}
