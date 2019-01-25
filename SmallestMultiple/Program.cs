using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c = false;
            int i = 1;
            while (!c)
            {
                var count = 0;
                for (int j = 1; j < 21; j++)
                {
                    if (i%j == 0)
                    {
                        count += 1;
                    }
                }
                if (count == 20)
                {
                    c = true;
                    break;
                } else
                {
                    i++;
                }
                
            }
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
