using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_2311104050
{
    using System;
    using System.Collections.Generic;

    namespace InformasiKelurahan
    {
        class Kelurahan
        {
            public string NamaKelurahan { get; set; }
            public int KodePos { get; set; }

            public Kelurahan(string namaKelurahan, int kodePos)
            {
                NamaKelurahan = namaKelurahan;
                KodePos = kodePos;
            }

            public void TampilkanInformasi()
            {
                Console.WriteLine($"Kelurahan: {NamaKelurahan}, Kode Pos: {KodePos}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Membuat list kelurahan
                List<Kelurahan> kelurahans = new List<Kelurahan>
            {
                new Kelurahan("Batununggal", 40266),
                new Kelurahan("Kujangsari", 40287),
                new Kelurahan("Mengger", 40267),
                new Kelurahan("Wates", 40256),
                new Kelurahan("Cijura", 40287),
                new Kelurahan("Jatisari", 40286),
                new Kelurahan("Margasari", 40286),
                new Kelurahan("Sekejati", 40286),
                new Kelurahan("Kebonwaru", 40272),
                new Kelurahan("Maleer", 40274),
                new Kelurahan("Samoja", 40273)
            };

                // Memanggil metode untuk menampilkan informasi kelurahan
                Console.WriteLine("Daftar Kelurahan dan Kode Pos:");
                foreach (var kelurahan in kelurahans)
                {
                    kelurahan.TampilkanInformasi();
                }
            }
        }
    }
}