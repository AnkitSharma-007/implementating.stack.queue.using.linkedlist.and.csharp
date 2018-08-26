using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    //this class will depict Array implementation of Stack
    internal class Stack
    {
        static readonly int MAX = 1000;
        int top;
        int[] a = new int[MAX];

        bool IsEmpty()
        {
            return (top < 0);
        }
        public Stack()
        {
            top = -1;
        }
        internal void Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                a[++top] = data;
            }
            Console.WriteLine("{0} pushed to stack", data);
        }

        internal void Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Item popped is {0}", a[top--]);
            }
        }
        internal void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("{0} is on the top of Stack", a[top]);
        }
        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
}
