using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//* * * * *
//* * * * * 
//* * * * *
//* * * * *
namespace practicequestions3
{
    internal class nestedloop
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <=4 ; i++)
            //{
            //    for (int j = 0; j <= 5; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine( );
            //}

            //1
            //12
            //123
            //1234
            //12345

            //for (int i = 1; i <=5; i++)                        
            //{
            //    for (int j = 1; j <=i ; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}


            //54321
            //5432
            //54
            //5

            //for (int i = 1; i <=5; i++)//row
            //{
            //    for (int j = 5; j >=i; j--)//cloumn
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}



            //*
            //**
            //***
            //****
            //*****

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }













        }
    }
}
