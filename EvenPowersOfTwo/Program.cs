﻿using System;

namespace EvenPowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
            //int num = 1;
            //for (int i = 0; i <= n; i += 2)
            //{
            //    Console.WriteLine(num);
            //    num *= 4;
            //}
        }
    }
}
