using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackjoonBasicQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(a[0]) * int.Parse(a[1]));
        }
    }
}
