using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon1008
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();

            Console.WriteLine(double.Parse(a[0]) / double.Parse(a[1]));
        }
    }
}
