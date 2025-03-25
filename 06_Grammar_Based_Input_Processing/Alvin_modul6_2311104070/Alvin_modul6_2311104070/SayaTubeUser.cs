using System;
using System.Collections.Generic;
using System.Diagnostics;

public class SayaTubeUser
{
    private int id;
    public string Username { get; private set; }
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        Debug.Assert(username != null && username.Length <= 100, "Username tidak valid!");

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        Debug.Assert(video != null, "Video tidak boleh null!");
        Debug.Assert(video.GetPlayCount() < int.MaxValue, "Play count melebihi batas integer!");

        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in uploadedVideos)
        {
            total += video.GetPlayCount();
        }
        return total;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {Username}");
        int count = 0;
        foreach (var video in uploadedVideos)
        {
            if (count >= 8) break;
            Console.WriteLine($"Video {count + 1}: {video.GetTitle()}");
            count++;
        }
    }
}
