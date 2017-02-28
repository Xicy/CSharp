using System;

namespace Diziler
{
    class Program1
    {
        static void Main()
        {
            int[] test = new int[10];
            int[] test2 = {0, 1};

            foreach (int i in test2)
            {
                Console.WriteLine(i);
            }

            for (int a = 0; a < 2; a++)
            {
                Console.WriteLine(test2[a]);
            }
        }
    }
}
