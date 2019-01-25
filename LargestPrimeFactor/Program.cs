using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = 600851475143;
            var prime = 2;
            while (value != prime)
            {
                for (int i = 2; i < value+1; i++)
                {
                   
                    if (value%i == 0)
                    {
                        prime = i;
                        if (prime != value)
                        {
                            value = value / i;
                        }
                        Console.WriteLine("------------");
                        Console.WriteLine(prime);
                        Console.WriteLine(value);
                        Console.WriteLine("------------");
                        break;
                    } 
                }                
            }
            Console.WriteLine(prime);
            Console.ReadLine();
        }
    }
}
