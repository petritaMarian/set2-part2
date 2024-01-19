using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1 || n == 2) Console.WriteLine("Al " + n + "-lea termen este 1");
            else
            {
                int f1 = 1, f2 = 1, f3 = f1 + f2;
                for (int i = 3; i <= n; i++)
                {
                    f3 = f1 + f2;
                    f1 = f2;
                    f2 = f3;
                }
                Console.WriteLine("Al " + n + "-lea termen este " + f3);
            }
        }
    }
}
