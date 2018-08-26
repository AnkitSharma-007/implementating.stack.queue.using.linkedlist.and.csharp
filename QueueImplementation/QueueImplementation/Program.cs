using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueueCaller();

            Console.ReadLine();
        }

        public static void QueueCaller()
        {
            Queue queue = new Queue(100);

            QueueHelper helper = new QueueHelper();

            helper.EnQueue(queue, 10);
            helper.EnQueue(queue, 20);
            helper.EnQueue(queue, 30);
            helper.EnQueue(queue, 40);

            helper.GetFrontElement(queue);
            helper.GetRearElement(queue);

            helper.PrintQueue(queue);

            helper.DeQueue(queue);
            helper.GetFrontElement(queue);
            helper.GetRearElement(queue);

            helper.PrintQueue(queue);
        }

        public static void LinkedListQueueCaller()
        {
            LinkListQueue myQueue = new LinkListQueue();

            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);
            myQueue.Enqueue(40);

            myQueue.PrintQueue();

            myQueue.Dequeue();
            myQueue.Enqueue(50);

            myQueue.PrintQueue();
            myQueue.Dequeue();
            myQueue.PrintQueue();
        }
    }
}
