using System;

namespace AkisKontrolMekanizmalari
{
    class Program5
    {
        static void Main()
        {
            int toplam = 0;
            //break continue
            for (int i = 1; i <= 3; i++)
                toplam += i;
            Console.Write("toplam={0}", toplam);
            Console.ReadLine();
        }
    }
}
