using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N1 : ");
            int N1 = int.Parse(Console.ReadLine());
            Console.Write("Enter N2  : ");
            int N2 = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = N1; i <= N2; i++)
            {
                for (int g = 1; g < i; g++)
                {
                    if (i % g == 0)
                    {
                        sum = g + sum;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                    sum = 0;
                }
                else
                    sum = 0;
            }
        }
    }
}
