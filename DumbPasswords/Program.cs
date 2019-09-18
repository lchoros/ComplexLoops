using System;

namespace DumbPasswords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char l = char.Parse(Console.ReadLine());

            //character one

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("{0}{1} ", i, j);
                    //for (int g = 0; g < length; g++)
                    //{
                    //    for (int g = 0; g < length; g++)
                    //    {
                    //        for (int g = 0; g < length; g++)
                    //        {

                    //        }
                    //    }
                    //}
                    Console.WriteLine();
                }
            }
        }
    }
}
