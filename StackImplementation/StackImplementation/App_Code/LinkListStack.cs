using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    //this class will depict Linked List implementation of Stack
    internal class LinkListStack
    {
        Node top;

        public LinkListStack()
        {
            this.top = null;
        }

        internal void Push(int value)
        {
            Node newNode = new Node(value);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine("{0} pushed to stack", value);
        }

        internal void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow. Deletion not possible");
                return;
            }

            Console.WriteLine("Item popped is {0}", top.data);
            top = top.next;
        }

        internal void Peek()
        {
            Console.WriteLine("{0} is on the top of Stack", this.top.data);
        }

        internal void PrintStack()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }

            Node temp = this.top;

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
