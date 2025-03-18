using System;

class Program
{
    static void Main()
    {
        // Memanggil method SapaUser dengan tipe data string
        HaloGeneric.SapaUser("Alvin"); // Ganti dengan nama panggilan kamu

        // Membuat instance DataGeneric dengan tipe data string (NIM)
        DataGeneric<string> data = new DataGeneric<string>("2311104070");
        data.PrintData();
    }
}
