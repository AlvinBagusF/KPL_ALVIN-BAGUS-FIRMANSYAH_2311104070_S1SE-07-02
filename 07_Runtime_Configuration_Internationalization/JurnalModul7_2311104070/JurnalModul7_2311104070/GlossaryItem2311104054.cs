using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

public class GlossDef
{
    public string Para { get; set; }
    public List<string> GlossSeeAlso { get; set; }
}

public class GlossEntry
{
    public string ID { get; set; }
    public string SortAs { get; set; }
    public string GlossTerm { get; set; }
    public string Acronym { get; set; }
    public string Abbrev { get; set; }
    public GlossDef GlossDef { get; set; }
    public string GlossSee { get; set; }
}

public class GlossDiv
{
    public string Title { get; set; }
    public GlossEntry GlossEntry { get; set; }
}

public class Glossary
{
    public string Title { get; set; }
    public GlossDiv GlossDiv { get; set; }
}

public class GlossaryItem2311104054
{
    public static void ReadJson(string filePath)
    {
        try
        {
            string jsonString = File.ReadAllText(filePath);
            Glossary glossary = JsonSerializer.Deserialize<Glossary>(jsonString);
            var entry = glossary.GlossDiv.GlossEntry;

            Console.WriteLine($"ID: {entry.ID}, Term: {entry.GlossTerm}, Definisi: {entry.GlossDef.Para}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
