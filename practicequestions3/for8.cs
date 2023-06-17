using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Generate Fibonacci series. 0,1, 1, 2, 3, 5,8 ….. k. where k < n . n is entered by user

namespace practicequestions3
{
    internal class for8
    {
        static void Main(string[] args)
        {
            int n,sec,third=0;
            Console.WriteLine("Enter a number =");
            n = Convert.ToInt32(Console.ReadLine());
            int first=0;
            sec = 1;
            Console.WriteLine(first +"\n"+sec);
            for (int i = 0; i < n; i++)
            {
                third = first + sec;
                Console.WriteLine(third);
                first = sec;
                sec = third;
            }           
        }
    }
}
