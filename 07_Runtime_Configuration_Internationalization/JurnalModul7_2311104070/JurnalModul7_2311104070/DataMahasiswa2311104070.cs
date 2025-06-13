using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Alamat
{
    public string Jalan { get; set; }
    public string Kota { get; set; }
    public string Provinsi { get; set; }
}

public class MataKuliah
{
    public string Kode { get; set; }
    public string Nama { get; set; }
}

public class Mahasiswa
{
    public string NamaDepan { get; set; }
    public string NamaBelakang { get; set; }
    public string JenisKelamin { get; set; }
    public int Usia { get; set; }
    public Alamat Alamat { get; set; }
    public List<MataKuliah> MataKuliah { get; set; }
}

public class DataMahasiswa2311104070
{
    public static void ReadJson(string filePath)
    {
        try
        {
            string jsonString = File.ReadAllText(filePath);
            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
            Console.WriteLine($"Nama: {mhs.NamaDepan} {mhs.NamaBelakang}, Usia: {mhs.Usia}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
