using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test01
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = 5;
            int b = 6;
            Console.WriteLine(a ?? b);
            Console.ReadKey();
        }
    }
}
