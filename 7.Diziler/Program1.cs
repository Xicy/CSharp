using System;

namespace Diziler
{
    class Program1
    {
        static void Main()
        {
            int[] test = new int[10];
            int[] test2 = {0, 1};

            foreach (var i in test2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
