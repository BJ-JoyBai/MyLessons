using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyLessons004
{
    delegate void MyClarifyHander(object sener, int clarifydata);
    class Program
    {
        
        static void Main(string[] args)
        {
            MyWorkClass aWork = new MyWorkClass();
            aWork.ProgressChanged += OnWork_ProgressChanged;   
            Console.WriteLine("开始计算。。。。");
            aWork.DoWork();
            Console.WriteLine("就算结果！");
            Console.ReadLine();
        }
        private static void OnWork_ProgressChanged(object sener, int clarifydata)
        {
            Console.Write("...");
        }
    }
    
    class MyWorkClass
    {
        public event MyClarifyHander ProgressChanged;
        public void DoWork()
        {
            for(int i=0;i<100;i++)
            {
                // MyClarifyHander temp = ProgressChanged();
                //if(temp!=null)
                //ProgressChanged(this,i)
                ProgressChanged?.Invoke(this, i);//空引用
                Thread.Sleep(200);
            }
        }
    }
}
