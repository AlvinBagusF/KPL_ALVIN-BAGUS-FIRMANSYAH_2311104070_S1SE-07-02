using System;

class Program
{
    static void Main()
    {
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Alvin Bagus Firmansyah");
            video.PrintVideoDetails();
            video.IncreasePlayCount(5000);
            video.PrintVideoDetails();

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
    }
}
