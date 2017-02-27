using System;

namespace Diziler
{
    class Program2
    {
        static void Main()
        {
            int[,] test = new int[2, 3];
            //{0,0,0}
            //{0,0,0}
            int[,,] test2 = new int[2, 2, 2] { { { 0, 0 }, { 1, 1 } }, { { 2, 2 }, { 3, 3 } } };

            int[][] test3 = new int[2][];
            test3[0] = new int[1];
            test3[1] = new int[2];
            //{0}
            //{1,2}
            string[] isimler = {"Veli", "Ali", "Ayşe"}; 
            Array.Sort(isimler);
            Array.Clear(test2, 0, test2.Length);
            Array.Reverse(isimler);
        }
    }
}
