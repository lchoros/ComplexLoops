using System;

namespace ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int cnt = n; cnt >= 1; cnt -=1)
            {
                Console.WriteLine(cnt);
            }
        }
    }
}
