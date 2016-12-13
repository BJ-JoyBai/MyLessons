using System;
using System.Collections.Generic;//泛型容器
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLessons2
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] A = new int[10];
            List<int> A = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                string aText = Console.ReadLine();
                //int.TryParse(aText, out A[i]);//从里往外输出，解析输入是否正确，返回布尔值
                try
                {
                    //A[i] = int.Parse(aText);
                    A.Add(int.Parse(aText));
                }
                catch(Exception e)
                {
                    //throw;
                    //变量字符串的添加输出
                    Console.WriteLine($"输入[{aText}]错误【{e.Message}】，忽略本次输入");
                   // A[i] = 0;
                }
            }
            // Array.Sort(A);
            A.Sort();
            foreach(int x in A)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
