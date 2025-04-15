namespace Modul5
{
    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T a, T b, T c) where T : struct
        {
            return (dynamic)a + (dynamic)b + (dynamic)c;
        }
    }
}
