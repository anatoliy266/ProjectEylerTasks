using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<long, long> primes = new Dictionary<long, long>
            {
                [2] = 1,
                [3] = 1
            };
            long i = 4;
            long limit = 2000000;
            long sum = 5;
            for (var q = 4; q < 2000000; q++)
            {
                if (q%2 ==0 || q%3==0)
                {
                    primes[q] = 0;
                } else
                {
                    primes[q] = 1;
                }
            }
            while(i < limit)
            {
                if (primes[i] == 1)
                {
                    sum += i;
                    long step = i;
                    long sqr = i * i;
                    long j = sqr;
                    while(j < limit)
                    {
                        try
                        {
                            if (primes[j] == 1)
                            {
                                primes[j] = 0;
                            }
                        } catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine(j);
                            Console.WriteLine(i);
                            Console.WriteLine(step);
                            Console.WriteLine(sqr);
                            Console.ReadLine();
                        }
                        j += step;
                    }
                }
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
