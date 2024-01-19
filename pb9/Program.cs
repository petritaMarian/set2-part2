using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            float z = float.Parse(Console.ReadLine());
            float x;
            bool verif = true;

            for (int i = 2 ; i < n; i++)
            {
                x = float.Parse(Console.ReadLine());
                if ((y > z && x >= y) || (y < z && x <= y)) verif = false;
            }
            if (verif) Console.WriteLine("Secventa este monotona");  
            else Console.WriteLine("Secventa nu este monotona");
        }
    }
}
