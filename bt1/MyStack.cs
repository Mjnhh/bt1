using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1
{
    public class MyStack
    {
        private int[] data;
        private int top;

        public MyStack()
        {
            data = new int[100];
            top = -1;
        }

        public MyStack(int size)
        {
            data = new int[size];
            top = -1;
        }


        public bool isEmpty()
        {
            return top == -1;
        }

        public bool isFull()
        {
            return top == data.Length - 1;
        }

        public void Push(int x)
        {
            if (isFull())
            {
                Console.WriteLine("Stack is full");
                return;
            }

            top++;
            data[top] = x;
        }

        public int Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack rỗng");
                return -1;
            }

            int value = data[top];
            top--;
            return value;
        }
    }
}

