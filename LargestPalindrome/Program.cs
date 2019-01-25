using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindrome
{
    class Program
    {
        public static bool Parser(int num)
        {
            char[] charNum = num.ToString().ToCharArray();
            if (charNum.Length%2 == 0)
            {
                //Console.WriteLine(charNum.Length);
                bool c = true;
                var i = 0;
                while(i != charNum.Length / 2)
                {
                    if (charNum[0 + i] != charNum[charNum.Length - i-1])
                    {
                        c = true;
                        break;
                    } else
                    {
                        c = false;
                    }
                    i++;
                }
                if (c)
                {
                    return false;
                } else
                {
                    return true;
                }
                
            } else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            var val = 100;
            var palindrome = 0;
            while (val < 1000)
            {
                for (int j = 100; j < 1000; j++)
                {
                    //Console.WriteLine(val*j);
                    if (Parser(val * j))
                    {
                        if (palindrome < (val*j))
                        {
                            palindrome = val * j;
                        } 
                    }
                }
                val++;
                Console.WriteLine();
            }
            Console.WriteLine(palindrome);
            Console.ReadLine();
        }
    }
}
