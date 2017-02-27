using System;

namespace Metotlar
{
    class Program5
    {
        static void Main()
        {
        }

        public static uint Faktoriyel(uint i)
        {
            return i <= 1 ? 1 : i * Faktoriyel(i - 1);
        }

    }
}
