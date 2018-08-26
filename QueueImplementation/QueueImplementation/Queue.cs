using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    //this class will depict Array implementation of Queue
    internal class Queue
    {
        internal int front;
        internal int rear;
        internal int size;

        internal int capacity;

        internal int[] array;

        public Queue(int capacity)
        {
            this.capacity = capacity;
            front = this.size = 0;
            rear = capacity - 1;
            array = new int[capacity];
        }
    }

    internal class QueueHelper
    {
        // Queue is full when size becomes equal to 
        // the capacity 
        internal bool IsFull(Queue queue)
        {
            return (queue.size == queue.capacity);
        }

        // Queue is empty when size is 0
        internal bool IsEmpty(Queue queue)
        {
            return (queue.size == 0);
        }

        // Method to add an item to the queue. We will add items from rear of Queue.
        // It changes rear and size
        internal void EnQueue(Queue queue, int item)
        {
            if (IsFull(queue))
            {
                return;
            }
            queue.rear = (queue.rear + 1) % queue.capacity;
            queue.array[queue.rear] = item;
            queue.size = queue.size + 1;
            Console.WriteLine("Value {0} has been Enqueued", item);
        }

        // Method to remove an item from queue. We will remove items from front of Queue
        // It changes front and size
        internal void DeQueue(Queue queue)
        {
            if (IsEmpty(queue))
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            int item = queue.array[queue.front];
            queue.front = (queue.front + 1) % queue.capacity;
            queue.size = queue.size - 1;
            Console.WriteLine("Item deleted is {0}", item);
        }

        // Method to get front element of queue
        internal void GetFrontElement(Queue queue)
        {
            if (IsEmpty(queue))
            {
                Console.WriteLine("The Queue is empty");
                return;
            }
            Console.WriteLine("Front : {0}", queue.array[queue.front]);
        }

        // Method to get rear element of queue
        internal void GetRearElement(Queue queue)
        {
            if (IsEmpty(queue))
            {
                Console.WriteLine("The Queue is empty");
                return;
            }
            Console.WriteLine("Rear : {0}", queue.array[queue.rear]);
        }

        internal void PrintQueue(Queue queue)
        {
            for (int i = queue.front; i <= queue.rear; i++)
            {
                Console.Write(queue.array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
