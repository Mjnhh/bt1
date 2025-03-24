using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Cho biết số nguyên N hệ 10: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Cho biết hệ số X cần đổi (2,8,16): ");
            int X = int.Parse(Console.ReadLine());

            if (X != 2 && X != 8 && X != 16)
            {
                Console.WriteLine("Hệ số X không hợp lệ. Chỉ hỗ trợ hệ số 2, 8 hoặc 16.");
                return;
            }

            MyStack stack = new MyStack();

            int temp = N;
            while (temp > 0)
            {
                int remainder = temp % X;
                stack.Push(remainder);
                temp = temp / X;
            }

            Console.Write("Kết quả : " + N + "(10) = ");

            if (N == 0)
            {
                Console.WriteLine("0 (" + X + ")");
            }
            else
            {
                while (!stack.isEmpty())
                {
                    int digit = stack.Pop();
                    if (X == 16 && digit >= 10)
                    {
                        char hexChar = (char)('A' + (digit - 10));
                        Console.Write(hexChar);
                    }
                    else
                    {
                        Console.Write(digit);
                    }
                }
                Console.WriteLine(" (" + X + ")");
                Console.ReadLine();
            }
        }
    }
}
