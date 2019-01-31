using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighlyDivisibleTriangularNumber
{
    class Program
    {
        static int NextPrime(long value)
        {
            var val = value+1;
            var i = 2;
            while (i < val)
            {
                if(val%i == 0)
                {
                    val++;
                }
                i++;
            }
            return i;
        }

        static void Main(string[] args)
        {
            long i = 20;
            long sum = 0;
            long count = 2;
            
            List<int> divisors = new List<int>();
            while (count < 500)
            {
                var val = 2;
                sum = i * (i + 1) / 2;
                count = 2;
                while (val < Math.Sqrt(sum))
                {
                    if (sum % val == 0)
                    {
                        count += 2;
                    }
                    val++;
                }
                i++;
            }
            Console.WriteLine(i + ": " + sum + ", " + count);
            Console.ReadLine();
        }
    }
}
