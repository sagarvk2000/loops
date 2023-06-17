using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Find the factorial of a given number.

//5 = 5 * 4 * 3 * 2 * 1 → 120


namespace practicequestions3
{
    internal class for11
    {
        static void Main(string[] args)
        {
            int n, fact=1;
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
                
            }
            Console.WriteLine(fact);


        }
    }
}
