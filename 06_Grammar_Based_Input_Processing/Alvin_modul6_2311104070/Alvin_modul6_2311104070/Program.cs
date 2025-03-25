using System;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Alvin Bagus Firmansyah");

        SayaTubeVideo[] videos = new SayaTubeVideo[]
        {
            new SayaTubeVideo("Review Film Interstellar oleh Alvin"),
            new SayaTubeVideo("Review Film Inception oleh Alvin"),
            new SayaTubeVideo("Review Film The Dark Knight oleh Alvin"),
            new SayaTubeVideo("Review Film Parasite oleh Alvin"),
            new SayaTubeVideo("Review Film Whiplash oleh Alvin"),
            new SayaTubeVideo("Review Film La La Land oleh Alvin"),
            new SayaTubeVideo("Review Film The Prestige oleh Alvin"),
            new SayaTubeVideo("Review Film Avengers: Endgame oleh Alvin"),
            new SayaTubeVideo("Review Film Joker oleh Alvin"),
            new SayaTubeVideo("Review Film Dune oleh Alvin")
        };

        foreach (var video in videos)
        {
            user.AddVideo(video);
        }

        videos[0].IncreasePlayCount(10000);
        videos[1].IncreasePlayCount(5000000);
        videos[2].IncreasePlayCount(25000000); // Maksimum

        user.PrintAllVideoPlaycount();
        Console.WriteLine($"Total Play Count: {user.GetTotalVideoPlayCount()}");
    }
}
