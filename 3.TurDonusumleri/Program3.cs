using System;

namespace TurDonusumleri
{
    class Program3
    {
        static void Main()
        {
            int i = 257;
            int a = 300;
            byte b, c;
            unchecked
            {
                b = (byte)i;
                c = (byte)a;
            }
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
