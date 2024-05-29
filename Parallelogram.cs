using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public class Parallelogram : Shape
    {
        public double A { get; set; } // Основа паралелограма
        public double H { get; set; } // Висота паралелограма
        public double Alfa { get; set; } // Кут між основою і боковою стороною в радіанах

        public override double GetPerimeter()
        {
            double X = H / Math.Sin(Alfa);
            return 2 * X + 2 * A;
        }
    }

}
