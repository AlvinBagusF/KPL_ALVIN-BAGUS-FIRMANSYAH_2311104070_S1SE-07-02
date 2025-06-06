public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Review Film oleh Alvin Bagus Firmansyah");

        for (int i = 0; i < 10; i++)
        {
            video.IncreasePlayCount(1000000); // Total akan jadi 10 juta play count
        }

        video.PrintVideoDetails();
    }
}
