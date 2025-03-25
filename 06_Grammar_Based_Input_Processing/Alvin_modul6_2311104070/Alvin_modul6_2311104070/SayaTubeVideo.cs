using System;
using System.Diagnostics;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(title != null, "Judul video tidak boleh null");
        Debug.Assert(title.Length <= 200, "Judul video tidak boleh lebih dari 200 karakter");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999); // Generate ID random 5 digit
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count > 0, "Jumlah penambahan play count tidak boleh negatif atau nol");
        Debug.Assert(count <= 25000000, "Jumlah penambahan play count maksimal 25.000.000");

        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas maksimum integer.");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID Video    : {this.id}");
        Console.WriteLine($"Judul Video : {this.title}");
        Console.WriteLine($"Play Count  : {this.playCount}");
    }

    public int GetPlayCount()
    {
        return this.playCount;
    }

    public string GetTitle()
    {
        return this.title;
    }
}
