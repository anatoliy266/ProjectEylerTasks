using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareSum = 0;
            var sumOfSquares = 0;
            for (int i = 1; i < 101; i++)
            {
                sumOfSquares += i * i;
                squareSum += i;
            }
            squareSum = squareSum * squareSum;
            var result = squareSum - sumOfSquares;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
