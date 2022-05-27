using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Let’s make a program that uses methods to accomplish a task. Let’s take an array and
reverse the contents of it. For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would
become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.
To accomplish this, you’ll create three methods: one to create the array, one to reverse the
array, and one to print the array at the end.
*/

namespace Assignment3
{
    public class ReverseArray
    {
        public int[] GenerateNumbers()
        {
            int[] num = new int[] {1,2,3,4,5,6,7,8,9,10};
            return num;
        }

        public void Reverse(ref int[] num)
        {
            for (int i = 0; i < num.Length / 2; i++)
            {
                int temp = num[i];
                num[i] = num[num.Length - i - 1];
                num[num.Length - i - 1] = temp;
            }
        }

        public void PrinttNumbersMethod(int[] num)
        {
            foreach (int i in num)
                Console.Write($"{i} ");
        }
    }
}
