using System;

namespace AkisKontrolMekanizmalari
{
    class Program2
    {
        /// <summary>
        /// Cinsiyet Alan bir uygulama
        /// ekrana e girilirse Erkeksiniz
        /// ekrana k girilirse Kızsınız
        /// hiçbiriyse Lütfen doğru seçim yapınız çıksın
        /// </summary>
        static void Main()
        {
            char deger;
            deger = (char)Console.Read();
            if (deger == 'k')
            {
                Console.WriteLine("Kadın");
            }
            else if (deger == 'e')
            {
                Console.WriteLine("Erkek");
            }
            else
            {
                Console.WriteLine("Lütfen Tekrar Giriniz");
            }
            Console.ReadLine();
        }
    }
}
