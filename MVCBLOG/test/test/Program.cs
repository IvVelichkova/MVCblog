using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n ; i++)
            {
                if (i==1 || i==n)
                {
                    Console.Write(new string('*',n));
                    Console.WriteLine();
                }

 
                else
                {
                    Console.Write("*" + new string(' ',n-2) + "*");
                    Console.WriteLine();
                }
            }
            

            
        }
    }
}
