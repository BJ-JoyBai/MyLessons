using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLessons002
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFunction aCalc = new MyFunction(1, 2, 3);
            Console.WriteLine($"Calc(1.2,2.3)={aCalc.Calc(1.2,2.3)}");
            Console.WriteLine($"Calc(2.5,3.2)={aCalc.Calc(2.5, 3.2)}");
            Console.ReadLine();
        }
    }
}
