using System;
using System.Collections.Generic;

class KodePos
{
    private static readonly Dictionary<string, string> kodePosMap = new Dictionary<string, string>
    {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    public static void TampilkanSemuaKodePos()
    {
        Console.WriteLine("===== DAFTAR KODE POS =====");
        foreach (var entry in kodePosMap)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }

    public static string GetKodePos(string kelurahan)
    {
        if (kodePosMap.TryGetValue(kelurahan, out string kodePos))
        {
            return kodePos;
        }
        return "Kode pos tidak ditemukan";
    }
}

// Contoh penggunaan
class Program
{
    static void Main()
    {
        // Menampilkan semua kode pos
        KodePos.TampilkanSemuaKodePos();

        // Mencari kode pos berdasarkan kelurahan
        Console.WriteLine("\nKode pos Batununggal: " + KodePos.GetKodePos("Batununggal"));
        Console.WriteLine("Kode pos Wates: " + KodePos.GetKodePos("Wates"));
        Console.WriteLine("Kode pos TidakAda: " + KodePos.GetKodePos("TidakAda"));

        Console.WriteLine("\nProgram selesai. Tekan Enter untuk keluar.");
        Console.ReadLine();
    }
}
