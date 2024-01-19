using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float x, sum = 0;

            for (int i = 0; i < n; i++)
            {
                x = float.Parse(Console.ReadLine());
                if (x == 0) continue;
                else sum += 1 / x;
            }
            Console.WriteLine("Suma inverselor: " + sum);
        }
    }
}
