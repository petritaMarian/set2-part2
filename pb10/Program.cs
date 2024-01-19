using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            float x;
            int seqLengh = 1, maxSeqLenght = 1;

            for (int i = 1; i < n; i++) 
            { 
                x = float.Parse(Console.ReadLine());
                if (x == y) seqLengh += 1;
                else seqLengh = 1;

                y = x;

                if (seqLengh > maxSeqLenght) maxSeqLenght = seqLengh;
            }
            Console.WriteLine("Numarul maxim de numere consecutive in secventa este " + maxSeqLenght);
        }
    }
}
