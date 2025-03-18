using System;

class Program
{
    static void Main()
    {
        // Bagian A: Menerima input satu karakter
        Console.Write("Masukkan satu huruf: ");
        char input = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if ("AIUEO".Contains(input))
        {
            Console.WriteLine($"Huruf {input} merupakan huruf vokal");
        }
        else
        {
            Console.WriteLine($"Huruf {input} merupakan huruf konsonan");
        }

        // Bagian B: Array bilangan genap
        int[] bilanganGenap = { 2, 4, 6, 8, 10 };

        for (int i = 0; i < bilanganGenap.Length; i++)
        {
            Console.WriteLine($"Angka genap {i + 1} : {bilanganGenap[i]}");
        }
    }
}
