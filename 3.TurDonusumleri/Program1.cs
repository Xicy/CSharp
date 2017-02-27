using System;

namespace TurDonusumleri
{
    class Program1
    {
        /*
            Kaynak	Hedef
            sbyte	short, int, float, long, double, decimal
            byte	short, ushort, int, uint, long, ulong, float, double, decimal
            short	int, long, float, double, decimal
            ushort	int, uint, long, ulong, float, double, decimal
            int	    long, float, double, decimal
            uint	long, ulong, float, double, decimal
            long    ulong	float, double, decimal
            char	ushort, int, uint, long, ulong, float, double, decimal
            float	double
         */
        static void Main()
        {
            byte a = 20;
            short b = 50;
            sbyte c = 80;
            int d = a + b + c;
            string e = "deneme";
            char f = 'k';
            object g = e + f + d;
            long h = d;
            float i = h;
            double j = i;
            double k = 12.5f;
            Console.WriteLine(g);
            Console.ReadLine();
        }
    }
}
