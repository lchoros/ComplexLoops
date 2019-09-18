using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            int b = 1;
            for (int i = 0; i < n-1; i++)
            {
                int next = a + b;
                a = b;
                b = next;
            }
            Console.WriteLine(b);
            //PrinSequence
            //int n = int.Parse(Console.ReadLine());
            //int a = 0;
            //int b = 1;
            //for (int i = 0; i < n; i++)
            //{
            //int next = a + b;
            //a = b;
            //b = next;
            //Console.WriteLine(a);
            //int next = a + b;
            //a = b;
            //b = next;
            //}
        }
    }
}
