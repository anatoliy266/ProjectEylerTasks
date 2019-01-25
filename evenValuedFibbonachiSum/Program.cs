using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenValuedFibbonachiSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibbonachiArray = new List<int>{ 1, 2 };
            var evenValued = new List<int>{ 2 };
            
            while (fibbonachiArray.Last() < 4000000)
            {
                int count = fibbonachiArray.Count;
                int prev1 = fibbonachiArray[count-1];
                int prev2 = fibbonachiArray[count - 2];
                Console.WriteLine(prev1+prev2);
                Console.WriteLine("------------------------");
                fibbonachiArray.Add(prev1 + prev2);
                if ((prev1 + prev2)% 2 ==0)
                {
                    evenValued.Add(prev1 + prev2);
                }
            }
            try
            {
                Console.WriteLine(evenValued.Count);
                var sum = 0;
                for (int i = 0; i < evenValued.Count; i++)
                {
                    sum += evenValued[i];
                }
                Console.WriteLine(sum);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            
            Console.ReadLine();
            

        }
    }
}
