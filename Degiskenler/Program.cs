using System;

namespace Degiskenler
{
    class Program
    {
        /* Değişken Adlandırılması
         * Değişken adları boşluk, simge içeremez
         * Değişkenler bir numerik karakterle başlayamaz
         * C#'ın diğer bütün komut, metot ve benzerlerinde olduğu gibi değişken adlarında büyük-küçük harf duyarlılığı vardır. 
         * Yani degisken isimli bir değişkenle Degisken isimli bir değişken birbirinden farklıdır
         * Değişken adları Türkçe karakterlerden(ğ,ü,ş,ö,ç,ı) oluşamaz. (Yeni versiyonlarda Türkçe karakterler kullanılabilir.)
         */

        static void Main(string[] args)
        {
            //byte	    1 bayt      0, ...,255 (tam sayı)
            byte varByte = 0;

            //sbyte	    1 bayt      -128, ...,127 (tam sayı)
            sbyte varsByte = -100;

            //short     2 bayt      -32768, ...,32767 (tam sayı)
            short varShort = short.MinValue;

            //ushort    2 bayt      0, ...,65535 (tam sayı)
            ushort varuShort = ushort.MaxValue;

            //int	    4 bayt	    -2147483648, ...,2147483647 (tam sayı)
            int varInt = 2017;

            //uint	    4 bayt	    0, ...,4294967295 (tam sayı)
            uint varuInt = 17;

            //long	    8 bayt	    -9223372036854775808, ...,9223372036854775807 (tam sayı)	
            long varLong=1990;

            //ulong	    8 bayt	    0,...,18446744073709551615 (tam sayı)	
            ulong varuLong=0;

            //float	    4 bayt	    ±1.5*10-45, ...,±3.4*1038 (reel sayı)	
            float varFloat=5f;

            //double	8 bayt	    ±5.0*10-324, ...,±1.7*10308 (reel sayı)	
            double varDouble=12d;
            
            //decimal	16 bayt	    ±1.5*10-28, ...,±7.9*1028 (reel sayı)	
            decimal varDecimal=5M;

            //char	    2 bayt	    Tek bir karakteri tutar.
            char varChar = 'C';

            //string	Sınırsız	Metin tutar.
            string varString = "Test";
            string varString2 = varString + " Metni";

            //bool      2 Değişken  true yada false
            bool varBool = true;

            //object    bütün değerler tanımlanan bütün değişkenler obje türünde tanımlanabilir
            object varObject = null;

            int a, b, c = 1;

            const int d = 5;

            string escapeString = "\"escape karakteri nasıl kullanılır\"";
            string escapeString2 = "C:\\Program Files";
            string escapeString3 = @"C:\Program Files";
            string escapeString4 = @"Yeni satır \n tab \t";


        }
    }
}
