using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLessons005
{
    class Program
    {
        static void MyWork(A aInstance)
        {
            Console.WriteLine("开始工作！");
            aInstance.Func();
            Console.WriteLine("结束工作！");
        }
        static void Main(string[] args)
        {
            MyWork(new A());
            MyWork(new B());
            MyWork(new C());
            Console.ReadLine();
        }
    }
    class A
    {
        public virtual void Func()
        {
            Console.WriteLine("来自A的Func!");
        }
    }
    class B:A
    {
        public override void Func()
        {
            //base.Func();
            Console.WriteLine("来自B的Func!");
        }
    }
    class C : A
    {
        public override void Func()
        {
            //base.Func();
            Console.WriteLine("来自C的Func!");
        }
    }

}
