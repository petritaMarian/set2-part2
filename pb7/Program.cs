using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float x = float.Parse(Console.ReadLine());
            float maxValue = x, minValue = x;

            for (int i = 1; i < n; i++)
            {
                x = float.Parse(Console.ReadLine());
                if (x > maxValue) maxValue = x;
                if (x < minValue) minValue = x;
            }
            Console.WriteLine("Minim: " + minValue + "\n" + "Maxim: " + maxValue);  
        }
    }
}
