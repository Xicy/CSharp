// Konsol uygulamaları yazılması için System isim uzayı eklenir. 
// Bu sayede derleyici, System.dll'i kullanması gerektiğini bilir.
using System;

namespace IlkProgramimiz
{
    class Program2
    {
        // .NET çalışma zamanında ön tanımlı olarak Main() fonksiyonunu çalıştırır.
        static void Main()
        {
            // Console sınıfı içerisindeki Writeline() fonksiyonu çalıştırılır
            Console.WriteLine("Merhaba Dünya");
            // Console sınıfı içerisindeki ReadLine() fonksiyonu çalıştırılır
            Console.ReadLine();
        }
    }
}
