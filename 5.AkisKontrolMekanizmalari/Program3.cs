using System;

namespace AkisKontrolMekanizmalari
{
    class Program3
    {
        static void Main()
        {
            switch (5)
            {
                case 1:
                    Console.Write("1");
                    break;
                case 2:
                    Console.Write("2");
                    break;
                case 3:
                    Console.Write("3");
                    break;
                default:
                    Console.Write("4");
                    goto case 3;
            }
            Console.ReadLine();
        }
    }
}
