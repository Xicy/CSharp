﻿using System;

namespace TurDonusumleri
{
    class Program3
    {
        static void Main()
        {
            int i = 256;
            int a = 300;
            byte b, c;
            checked
            {
                b = (byte)i;
                c = (byte)a;
            }
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
