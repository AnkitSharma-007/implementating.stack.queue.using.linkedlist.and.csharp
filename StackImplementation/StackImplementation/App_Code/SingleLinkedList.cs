using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public class Node
    {
        internal int data;
        internal Node next;

        // Constructor to create a new node.Next is by default initialized as null
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
