using System;

namespace Modul7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek dari class DataMahasiswa2311104070
            DataMahasiswa2311104070 mahasiswa = new DataMahasiswa2311104070();

            // Memanggil method ReadJSON untuk mendeserialisasi dan menampilkan data JSON
            DataMahasiswa2311104070.ReadJSON(); // ✅ Ini benar

        }
    }
}
