using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Cho biết số nguyên N hệ 10: ");
            int N = int.Parse(Console.ReadLine());

            MyStack stack = new MyStack(32);

            int temp = N;
            while (temp > 0)
            {
                int remainder = temp % 2;
                stack.Push(remainder);
                temp = temp / 2;
            }

            Console.Write("Kết quả : " + N + "(10) = ");

            if (N == 0)
            {
                Console.WriteLine("0 (2)");
            }
            else
            {
                while (!stack.isEmpty())
                {
                    Console.Write(stack.Pop());
                }
                Console.WriteLine(" (2)");
            }
            Console.ReadLine();
        }
    }
}