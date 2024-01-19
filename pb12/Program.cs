using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            float x;
            int seqLengh = 1, totalSeq = 0;

            for (int i = 1; i < n; i++)
            {
                x = float.Parse(Console.ReadLine());
                if (x != 0 && y != 0 && x == y + 1) seqLengh += 1;
                else seqLengh = 1;

                y = x;

                if (seqLengh > 1) totalSeq += 1;
            }
            Console.WriteLine("Grupuri de numere consecutive diferite de zero: " + totalSeq);
        }
    }
}
