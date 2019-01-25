using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001stPrime
{
    class Program
    {
        public static bool IsPrime(int num)
        {
            var val = 2;
            bool c = false;
            while (val != num)
            {
                //Console.WriteLine(val);
                if (num % val == 0)
                {
                    c = false;
                    break;
                } else
                {
                    c = true;
                    val++;
                }
                

            }
            return c;
        }

        static void Main(string[] args)
        {
            var primeList = new List<int> { 2, 3 };
            var i = 4;
            var count = primeList.Count;
            while (count != 10001)
            {
                if (IsPrime(i))
                {
                    primeList.Add(i);
                    count = primeList.Count;
                    Console.WriteLine(i);
                    Console.WriteLine(count);
                }
                i++;
            }
            Console.WriteLine(primeList.Last());
            Console.ReadLine();
        }
    }
}
