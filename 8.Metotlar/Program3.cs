using System;

namespace Metotlar
{
    class Program3
    {
        static void Main()
        {
            int b = 20;
            OutDeneme(out b);
            Console.WriteLine(b);
            Console.ReadLine();
        }

        public static void Deneme(int i)
        {
            i = 55;
        }

        public static void RefDeneme(ref int i)
        {
            i = 55;
        }

        public static void OutDeneme(out int i)
        {
            i = 0;
        }

        public static void ParamsDeneme(params int[] arr)
        {
            foreach (var i in arr)
                Console.WriteLine(i);
        }
    }
}
