using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipliesOf3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            int naturalSum = 0;
            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        Console.WriteLine(i);
                        naturalSum += i;
                    }
                }
                Console.WriteLine(naturalSum);
                Console.ReadLine();
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            
        }
    }
}
