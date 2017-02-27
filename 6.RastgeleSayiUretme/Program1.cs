using System;

namespace RastgeleSayiUretme
{
    class Program1
    {
        static void Main()
        {
            Random rnd = new Random();
            int a = rnd.Next();
            int b = rnd.Next(50);
            int c = rnd.Next(50, 100);
            double d = rnd.NextDouble();

            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
