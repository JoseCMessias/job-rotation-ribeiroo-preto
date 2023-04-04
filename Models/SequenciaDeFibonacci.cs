using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Job_Rotation.Models
{
    public class SequenciaDeFibonacci
    {
        public void DeFibonacci()
        {
            
            int num = 5;

            int a = 0;
            int b = 1;
            int c = a + b;

            while (c <= num)
            {
                if (c == num)
                {
                    Console.WriteLine("{0} pertence à sequência de Fibonacci.", num);
                    return;
                }

                a = b;
                b = c;
                c = a + b;
            }

            Console.WriteLine("{0} não pertence à sequência de Fibonacci.", num);
        }
    }
}