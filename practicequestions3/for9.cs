using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Find the sum of all digits of a number → 123 ⇒ 1+2+3 → 6

namespace practicequestions3
{
    internal class for9
    {
        static void Main(string[] args)
        {
            int n,sum=0,a;
            Console.WriteLine("Enter a digit number =");
            n = Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {
                a = n % 10;
                sum = sum + a;
                n = n / 10;               
            }
            Console.WriteLine(sum);
        }
    }
}
