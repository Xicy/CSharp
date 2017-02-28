using System;

namespace Metotlar
{
    class Program2
    {
        static void Main()
        {
            
            Yazdır yaz = new Yazdır();
            //yaz.Yaz("Merhaba");
            Console.ReadLine();
        }
    }

     class Yazdır
    {
        public static void Yaz(string metin)
        {
            Console.WriteLine(metin);
        }
    }
}
