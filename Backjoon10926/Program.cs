using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon10926
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] id = Console.ReadLine().Split();

            if (id.Contains(id[0]))
            {
                Console.WriteLine(id[0] + "??!");
            }
        }
    }
}
