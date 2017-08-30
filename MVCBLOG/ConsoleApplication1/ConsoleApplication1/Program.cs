using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n ; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i <= n - 2; i++)
            {
                Console.WriteLine('*' + new string(' ', n - 2) + '*');

            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("*");
            }
        }
    }
}
