using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            float x;
            bool ord = true;

            for (int i = 1; i < n; i++)
            {
                x = float.Parse(Console.ReadLine());
                if (y > x) ord = false;
                y = x;
            }
            if (ord == true) Console.WriteLine("Secventa e ordonata crescator");
            else Console.WriteLine("Secventa nu e ordonata crescator");
        }
    }
}
