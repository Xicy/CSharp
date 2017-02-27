using System;

namespace Operatorler
{
    class Program1
    {
        /*
        Birinci öncelikliler	x++, x--
        Tek operand alan operatörler	+, -, !, ~, ++x, --x, (Tür)x
        Çarpma ve bölme	*, /, %
        Toplama ve çıkarma	+, -
        Kaydırma operatörleri	<<, >>
        İlişkisel ve tür testi operatörleri	<, >, <=, >=, is, as
        Eşitlik operatörü	==, !=
        Bitsel Ve (AND)	&
        Bitsel Özel Veya (XOR)	^
        Bitsel Veya (OR)	|
        Mantıksal Ve	&&
        Mantıksal Veya	||
        Koşul operatörü	?:
        Atama ve işlemli atama operatörleri	=, *=, /=, %=, +=, -=, <<=, >>=, &=, ^=, |=
        */
        static void Main()
        {
            int x = 0;
            int y = x++;
            y = x--;
            y = --x;
            y = ++x;


            bool c = true;
            bool d = !c;

            c = 10 > 5;
            c = 5 <= 5;
            c = "a" == "A";

            c = true && false;
            c = true || false;

            c = x is int;

            object f = "selam";
            string k = (string)f;
            k = f as string;
            k = f.ToString();

            float l;

            if (12 > 5)
                l = 12 * 5;
            else
                l = 12f / 5;

            l = 12 > 5 ? 12 * 5 : 12f / 5;
            
        }
    }
}
