using System;

namespace Modul5
{
    class Program
    {
        static void Main()
        {
            long nim = 2311104070;
            int lastDigit = (int)(nim % 10);

            if (lastDigit == 0 || lastDigit == 9)
            {
                Console.WriteLine(Penjumlahan.JumlahTigaAngka(12L, 34L, 56L)); // long
            }
            else if (lastDigit == 1 || lastDigit == 2)
            {
                Console.WriteLine(Penjumlahan.JumlahTigaAngka(12.3f, 34.5f, 56.7f)); // float
            }
            else if (lastDigit == 3 || lastDigit == 4 || lastDigit == 5)
            {
                Console.WriteLine(Penjumlahan.JumlahTigaAngka(12.0, 34.0, 56.0)); // double
            }
            else if (lastDigit == 6 || lastDigit == 7 || lastDigit == 8)
            {
                Console.WriteLine(Penjumlahan.JumlahTigaAngka(12, 34, 56)); // int
            }
        }
    }
}
