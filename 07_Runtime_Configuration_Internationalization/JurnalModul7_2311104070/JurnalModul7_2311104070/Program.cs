﻿internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Data Mahasiswa:");
        DataMahasiswa2311104070.ReadJson("mahasiswa.json");

        Console.WriteLine("\nAnggota Tim:");
        TeamMembers2311104070.ReadJson("team.json");

        Console.WriteLine("\nGlossary:");
        GlossaryItem2311104070.ReadJson("glossary.json");
    }
}
