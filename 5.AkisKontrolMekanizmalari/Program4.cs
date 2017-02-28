using System;

namespace AkisKontrolMekanizmalari
{
    class Program4
    {
        /// <summary>
        /// Cinsiyet Alan bir uygulama
        /// ekrana e girilirse Erkeksiniz
        /// ekrana k girilirse Kızsınız
        /// hiçbiriyse Lütfen doğru seçim yapınız çıksın
        /// bunu switch yapısi ile yapın
        /// </summary>
        static void Main()
        {
            string deger;
            deger = Console.ReadLine();
            switch (deger)
            {
                case "e":Console.WriteLine("Erkek");break;
                case "k": Console.WriteLine("Kadın");break;
                default:Console.WriteLine("Lütfen Tekrar Deneyiniz"); break;

            }
            Console.ReadLine();
        }
    }
}
