using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
The Fibonacci sequence is a sequence of numbers where the first two numbers are 1 and 1,
and every other number in the sequence after it is the sum of the two numbers before it.*/

namespace Assignment3
{
    public class FibonacciSequence
    {
        public int[] Fibonacci(int num)
        {
            int[] fib = new int[num];
            for (int i = 0; i < num; i++)
            {
                if (i == 0 || i == 1)
                {
                    fib[i] = 1;
                }
                else
                {
                    fib[i] = fib[i - 1] + fib[i - 2];
                }
            }

            return fib;
        }
    }
}
