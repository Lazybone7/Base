using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    /**
     * 委托是一个引用类型，存的是方法的引用
     * 通俗来说，就是一个能存放很多方法的指针的调用清单（但方法签名必须和委托类型签名一样)，你一调用这个清单，那么清单里的所有的指针所对应的方法就会依次被执行。
     * */
    class DelegateLearn
    {
        delegate void Say01(string str);
        static void Main(string[] args)
        {
            Say01 say01 = new Say01(say); //向委托中注册方法
            say01 += dosth; //继续向委托中注册方法
            say01("123"); //结果：依次调用say方法和dosth方法
            Console.ReadKey();
        }
        
        static void say(string str)
        {
            Console.WriteLine("say：" + str);
        }
       
        static void dosth(string str)
        {
            Console.WriteLine("dosth：" + str);
        }

       
    }
}
