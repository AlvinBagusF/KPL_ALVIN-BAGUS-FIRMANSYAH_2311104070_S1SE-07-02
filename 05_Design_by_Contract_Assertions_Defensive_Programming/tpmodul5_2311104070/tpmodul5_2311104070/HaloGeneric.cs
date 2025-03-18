using System;

class HaloGeneric
{
    public static void SapaUser<T>(T nama)
    {
        Console.WriteLine($"Halo user {nama}");
    }
}
