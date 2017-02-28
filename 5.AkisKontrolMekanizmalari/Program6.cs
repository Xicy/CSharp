using System;

namespace AkisKontrolMekanizmalari
{
    class Program6
    {
        static void Main()
        {
            /*int i = 6;
            while (i > 5)
            {
                i = int.Parse(Console.ReadLine());
                Console.WriteLine(i);
            }
            Console.WriteLine("Bitti");
            Console.ReadLine();*/

            int i;
            Console.WriteLine("100 ile 0 arasında sayı girin");
            do
            {
                i = int.Parse(Console.ReadLine());
            } while (i < 0 || i > 100);
            Console.WriteLine("Bitti");
            Console.ReadLine();
        }
    }
}
