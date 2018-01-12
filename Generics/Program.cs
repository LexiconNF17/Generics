using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pair<int>(4, 6);
            Console.WriteLine(p.First);
            Console.WriteLine(p.Second);
            Console.WriteLine(p);
            Console.WriteLine();

            var p2 = new Pair<string>("four", "six");
            Console.WriteLine(p2.First);
            Console.WriteLine(p2.Second);
            Console.WriteLine(p2);
            Console.WriteLine();

            var p3 = new Pair<int, string>(3, "three");
            Console.WriteLine(p3.First);
            Console.WriteLine(p3.Second);
            Console.WriteLine(p3);
            Console.WriteLine();

            var p4 = new Pair(4, 6);
            Console.WriteLine(p4.First);
            Console.WriteLine(p4.Second);
            Console.WriteLine(p4);
            Console.WriteLine();

        }
    }
}
