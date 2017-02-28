using System;

namespace AkisKontrolMekanizmalari
{
    class Program5
    {
        static void Main()
        {
            int toplam = 0;
            //break continue
            for (int i = 1; i <= 5; i++)
            {
                if (i % 2 == 0)
                    continue;
                else if (i == 3)
                    break;
                toplam += i;
            }

            Console.Write("toplam={0}toplam={0}", toplam);
            Console.ReadLine();
        }
    }
}
