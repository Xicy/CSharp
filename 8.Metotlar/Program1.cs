using System;

namespace Metotlar
{
    class Program1
    {
        static void Main()
        {
            int b, c;
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            int a = Topla(b,c);
            Console.WriteLine(a);
            Console.ReadLine();
        }

        static int Topla(int a, int b)
        {
            return a + b;
        }
    }
}
