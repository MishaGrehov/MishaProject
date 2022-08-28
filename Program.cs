using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static bool CombineByAnd(bool a, bool b, bool c)
        {
            bool result = a && b && c;
            return result;
        }

        static bool CombineByOr(bool a, bool b, bool c)
        {
            bool result = a || b || c;
            return result;
        }
        static void Main(string[] args)
        {
            bool a = false;           
            bool b = true;
            bool c = true;
            bool d = CombineByAnd(a, b, c);
            bool f = CombineByOr(a, b, c);
            Console.WriteLine(d);
            Console.WriteLine(f);
        }
    }
}
