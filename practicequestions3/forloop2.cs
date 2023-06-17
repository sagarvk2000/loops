using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program to print odd numbers from 521 to 229 using while loop

namespace practicequestions3
{
    internal class forloop2
    {
        static void Main(string[] args)
        {
            for (int i = 521; i >=229; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);   
                }
            }
        }
    }
}
