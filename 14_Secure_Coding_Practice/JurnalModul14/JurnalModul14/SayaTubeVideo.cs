using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 100)
            throw new ArgumentException("Judul harus memiliki 1 - 100 karakter.");

        Random random = new Random();
        id = random.Next(10000, 99999);
        this.title = title;
        playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0 || count > 10000000)
            throw new ArgumentOutOfRangeException("Jumlah play count harus antara 0 dan 10.000.000.");

        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Terjadi overflow saat menambahkan play count.");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID Video   : " + id);
        Console.WriteLine("Judul Video: " + title);
        Console.WriteLine("Play Count : " + playCount);
    }
}
