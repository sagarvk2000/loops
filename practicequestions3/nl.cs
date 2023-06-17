using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicequestions3
{
    internal class nl
    {
        static void Main(string[] args)
        {
            //*****
            // ****
            //  ***
            //   **
            //    *
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //  *
            // * *
            //* * *
            //* * * * 
            //for (int i = 1; i <= 5; i++)       //row
            //{
            //    for (int j = 5; j >i; j--) //column printing space
            //    {
            //        Console.Write(" ");  //printing space
            //    }
            //    for (int k = 1; k <= i; k++)       //column
            //    {
            //        Console.Write(" *");      //printing stars
            //    }
            //    Console.WriteLine();     //for next line
            //}

            //ulta pyramid
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if (j < i)
            //        {
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write(" *");
            //        }
            //        Console.WriteLine();
            //    }
            //}


            //Diamond pyramid

           // int number;   enter the number below int declaration
            int  i, k, count = 1;
            //Console.Write("Enter number of rows\n");
            //number = int.Parse(Console.ReadLine());
            //count = number - 1;
            count = 5 - 1;
            //for (k = 1; k <= number; k++)
            for (k = 1; k <= 5; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * k - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            //for (k = 1; k <= number - 1; k++)
            for (k = 1; k <= 5 - 1; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                //for (i = 1; i <= 2 * (number - k) - 1; i++)
                for (i = 1; i <= 2 * (5 - k) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();


        }
    }
}
