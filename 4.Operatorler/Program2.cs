using System;

namespace Operatorler
{
    class Program2
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
            byte a = 12;
            //128 64 32 16 8 4 2 1
            // 0  0  0  0  1 1 0 0
            byte b = (byte)~a;

            //128 64 32 16 8 4 2 1
            // 1  1  1  1  0 0 1 1

            b = (byte)(a << 2);
            //128 64 32 16 8 4 2 1
            // 0  0  1  1  0 0 0 0

            b = (byte)(a >> 3);
            //128 64 32 16 8 4 2 1
            // 0  0  0  0  0 0 0 1

            b = (byte)(a | b);
            //128 64 32 16 8 4 2 1
            // 0  0  0  0  1 1 0 1

            b = (byte)(a & b);
            //128 64 32 16 8 4 2 1
            // 0  0  0  0  1 1 0 0

            b = (byte)(a ^ b);
            //128 64 32 16 8 4 2 1
            // 0  0  0  0  0 0 0 1

        }
    }
}
