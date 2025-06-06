using System;

class Program
{
    static void Main()
    {
        var data1 = PusatDataSingleton.GetDataSingleton();
        var data2 = PusatDataSingleton.GetDataSingleton();

        data1.AddSebuahData("Alvin");
        data1.AddSebuahData("Davina");
        data1.AddSebuahData("Freya");

        Console.WriteLine("Data dari data2:");
        data2.PrintSemuaData();

        data2.HapusSebuahData(2);

        Console.WriteLine("\nSetelah Freya dihapus dari data2, cetak dari data1:");
        data1.PrintSemuaData();

        Console.WriteLine($"\nJumlah data di data1: {data1.GetSemuaData().Count}");
        Console.WriteLine($"Jumlah data di data2: {data2.GetSemuaData().Count}");
    }
}
