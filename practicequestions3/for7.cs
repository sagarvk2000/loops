using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Find out given number is palindrome or not

namespace practicequestions3
{
    internal class for7
    {
        static void Main(string[] args)
        {
            int rem,rev=0;
            int n = Convert.ToInt32(Console.ReadLine()); //123
            int c = n;
            
            while(n > 0) //or (n !=0)
            {
                rem = n % 10; // 123-->123%10-->3-->12%10-->2-->1%10-->1              
                rev = rem + (rev * 10);
                n = n / 10;// 123-->123/10--> 12 -->12/10--> 1 -->1/10--> 0
            }
            if (c == rev)
            {
                Console.WriteLine(" palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
        }
    }
}
