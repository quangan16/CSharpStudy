using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC
{
    internal static class DoubleCalulation
    {
        public static double Multiply(this double x, double y) => x * y;
        public static double Pow(this double x) => x * x;
        public static double Divide(this double x, double y) => x / y;
        public static double Sqrt(this double x) => Math.Sqrt(x);
        public static double Sin(this double x) => Math.Sin(x);

    }
}


    

