using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    //this class will depict Linked List implementation of Queue
    internal class LinkListQueue
    {
        Node front;
        Node rear;

        public LinkListQueue()
        {
            this.front = this.rear = null;
        }

        // Method to add an element to the queue.
        internal void Enqueue(int item)
        {
            Node newNode = new Node(item);

            // If queue is empty, then new node is front and rear both
            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                // Add the new node at the end of queue and change rear
                this.rear.next = newNode;
                this.rear = newNode;
            }
            Console.WriteLine("{0} inserted into Queue", item);
        }

        // Method to remove an element from queue.
        internal void Dequeue()
        {
            // If queue is empty, return NULL.
            if (this.front == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            // Store previous front and move front one node ahead
            Node temp = this.front;
            this.front = this.front.next;

            // If front becomes NULL, then change rear also as NULL
            if (this.front == null)
            {
                this.rear = null;
            }

            Console.WriteLine("Item deleted is {0}", temp.data);
        }

        // Method to print Queue elements
        internal void PrintQueue()
        {
            if (this.front == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            Node temp = this.front;

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}

