using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2
{
    public class MyStack
    {
        private Node top;

        public MyStack()
        {
            top = null;
        }

        public bool isEmpty()
        {
            return top == null;
        }

        public void Push(int x)
        {
            Node newNode = new Node(x);
            newNode.Next = top;
            top = newNode;
        }
        public int Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack rỗng.");
                return -1; 
            }

            int value = top.Data;
            top = top.Next;
            return value;
        }
    }
}
