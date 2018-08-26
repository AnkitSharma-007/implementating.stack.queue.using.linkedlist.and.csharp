using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStackCaller();
            Console.ReadLine();
        }

        public static void StackCaller()
        {
            Stack myStack = new Stack();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.PrintStack();
            myStack.Peek();
            myStack.Pop();
            myStack.Peek();
            myStack.PrintStack();
        }
        public static void LinkedListStackCaller()
        {
            LinkListStack myStack = new LinkListStack();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.PrintStack();
            myStack.Peek();
            myStack.Pop();
            myStack.Peek();
            myStack.Pop();
            myStack.PrintStack();
        }
    }
}
