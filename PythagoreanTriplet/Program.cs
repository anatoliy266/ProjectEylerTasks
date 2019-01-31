using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagoreanTriplet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.Millisecond);
            long result = 0;
            for (long i = 1; i < 1000; i++)
            {
                for (long j = 1; j < 1000; j++)
                {
                    if (i+j < 1000)
                    {
                        long q = 1000 - j - i;
                        if (Math.Pow(q, 2) + Math.Pow(j, 2) == Math.Pow(i, 2))
                        {
                            result = i * j * q;
                            Console.WriteLine(DateTime.Now.Millisecond);
                            break;
                            
                        }
                    }
                    
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
