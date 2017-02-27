using System;

namespace Metotlar
{
    class Program3
    {
        static void Main()
        {
            
        }

        public static void RefDeneme(ref int i)
        {

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
