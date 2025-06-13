using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class TeamMember
{
    [JsonPropertyName("FirstName")]
    public string FirstName { get; set; }

    [JsonPropertyName("LastName")]
    public string LastName { get; set; }

    [JsonPropertyName("Gender")]
    public string Gender { get; set; }

    [JsonPropertyName("Age")]
    public int Age { get; set; }

    [JsonPropertyName("Nim")]
    public string Nim { get; set; }
}

public class TeamMembers2311104070
{
    public static void ReadJson(string filePath)
    {
        try
        {
            string jsonString = File.ReadAllText(filePath);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<TeamMember> members = JsonSerializer.Deserialize<List<TeamMember>>(jsonString, options);

            foreach (var member in members)
            {
                Console.WriteLine($"{member.FirstName} {member.LastName}, NIM: {member.Nim}, Usia: {member.Age}, Gender: {member.Gender}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
