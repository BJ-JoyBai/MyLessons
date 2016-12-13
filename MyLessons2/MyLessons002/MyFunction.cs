using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLessons002
{
    class MyFunction
    {
        public MyFunction(double aa,double bb,double cc)
        {
            a = aa;
            b = bb;
            c = cc;
        }
        public double Calc(double x,double y)
        {
            return a * x * x + b * y * y + a * b * x * y + c;
        }
        public double a { get; }
        public double b { get; }
        public double c { get; }
    }
}
