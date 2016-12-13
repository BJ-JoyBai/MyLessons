using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLessons003
{
    class Program
    {
        delegate double F(double x);//描述方法类型

        static void Draw(int[,] B,F aFunc,double x0,double x1,double y0,double y1)
        {
            for(int col=0;col<B.GetLength(1);col++)
            {
                B.Initialize();//初始化清0；
                double x = x0 + (x1 - x0) * col / (B.GetLength(1) - 1);
                double y = aFunc(x);
                int row = (int)((B.GetLength(0) - 1) * (y - y1) / (y0 - y1));
                B[row, col] = 1;
            }
        }
        static void Print(int[,] B)
        {
            for (int i=0; i < B.GetLength(0);i ++)
            {
                for (int j=0; j < B.GetLength(1);j++)
                {
                    Console.Write(B[i, j]==1?"*":" ");
                }
                Console.WriteLine();

            }
        }
        static void Main(string[] args)
        {
            int[,] B = new int[30, 60];//存放曲线
            Draw(B, Math.Sin, 0, 2 * 3.14, -1, 1);
            Print(B);
            Console.ReadLine();
        }
    }
}
