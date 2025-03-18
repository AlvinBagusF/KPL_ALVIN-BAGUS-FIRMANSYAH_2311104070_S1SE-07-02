public class PosisiKarakterGame
{
    private enum State { Berdiri, Jongkok, Tengkurap, Terbang }
    private State posisiSaatIni;
    private int nimMod;

    public PosisiKarakterGame(uint nim)
    {
        posisiSaatIni = State.Berdiri;
        nimMod = (int)(nim % 3);
    }

    public void TombolW()
    {
        if (nimMod == 0)
        {
            Console.WriteLine("Tombol arah atas ditekan.");
        }

        if (posisiSaatIni == State.Jongkok)
        {
            posisiSaatIni = State.Berdiri;
            Console.WriteLine("Posisi karakter kembali berdiri.");
        }
        else if (posisiSaatIni == State.Berdiri)
        {
            posisiSaatIni = State.Terbang;
            if (nimMod == 2)
            {
                Console.WriteLine("Posisi karakter take off (terbang).");
            }
        }
    }

    public void TombolS()
    {
        if (nimMod == 0)
        {
            Console.WriteLine("Tombol arah bawah ditekan.");
        }

        if (posisiSaatIni == State.Berdiri)
        {
            posisiSaatIni = State.Jongkok;
            Console.WriteLine("Posisi karakter jongkok.");
        }
        else if (posisiSaatIni == State.Jongkok)
        {
            posisiSaatIni = State.Tengkurap;
            if (nimMod == 1)
            {
                Console.WriteLine("Posisi karakter tengkurap (istirahat).");
            }
        }
        else if (posisiSaatIni == State.Terbang)
        {
            posisiSaatIni = State.Jongkok;
            Console.WriteLine("Posisi karakter landing (mendarat).");
        }
    }

    public void CekPosisi()
    {
        Console.WriteLine($"Posisi saat ini: {posisiSaatIni}");

        if (posisiSaatIni == State.Berdiri && nimMod == 1)
        {
            Console.WriteLine("Posisi karakter standby.");
        }
    }
}
