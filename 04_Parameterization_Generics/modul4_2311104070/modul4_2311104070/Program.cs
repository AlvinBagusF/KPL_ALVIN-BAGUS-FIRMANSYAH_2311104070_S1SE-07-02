class Program
{
    static void Main()
    {
        Console.WriteLine("Masukkan nama buah:");
        string namaBuah = Console.ReadLine();
        string kode = KodeBuah.GetKodeBuah(namaBuah);
        Console.WriteLine($"Kode buah {namaBuah}: {kode}");

        uint nim = 2311104050;
        PosisiKarakterGame karakter = new PosisiKarakterGame(nim);

        karakter.TombolS();
        karakter.CekPosisi();

        karakter.TombolW();
        karakter.CekPosisi();

        karakter.TombolS();
        karakter.CekPosisi();
    }
}
