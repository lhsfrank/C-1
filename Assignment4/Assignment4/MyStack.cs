using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class MyStack<T>
    {
        int capacity;
        T[] stack;
        int top;

        public int Count()
        {
            return stack.Length;
        }
        public T Pop()
        {
            return (T)stack[top];
        }
        public void Push()
        {
            stack[top] = stack[top + 1];
        }
    }
}
