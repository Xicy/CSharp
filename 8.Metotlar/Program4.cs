using System;

namespace Metotlar
{
    class Program4
    {
        static void Main()
        {
            //Aşırı yükleme
        }

        public static void AsiriYukle(int i)
        {
            Console.WriteLine("int");
        }
        public static void AsiriYukle(float i)
        {
            Console.WriteLine("float");
        }
        public static void AsiriYukle(int i, int j)
        {
            Console.WriteLine("iki degerli");
        }
        public static void AsiriYukle(params int[] i)
        {
            Console.WriteLine("params");
        }
    }
}
