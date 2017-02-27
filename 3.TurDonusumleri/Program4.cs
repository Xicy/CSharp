using System;

namespace TurDonusumleri
{
    class Program4
    {
        static void Main()
        {
            string s1, s2;
            int sayi1, sayi2;
            int Toplam;
            Console.Write("Birinci sayıyı girin: ");
            s1 = Console.ReadLine();
            Console.Write("İkinci sayıyı girin: ");
            s2 = Console.ReadLine();
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            //sayi1 = int.Parse(s1);
            //int.TryParse(s2, out sayi2);

            Toplam = sayi1 + sayi2;
            Console.Write("Toplam= " + Toplam);
            Console.ReadLine();
        }
    }
}
