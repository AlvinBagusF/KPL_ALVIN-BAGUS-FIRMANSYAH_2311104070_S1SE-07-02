using System.Text.Json;
using System.IO;

public class CovidConfig
{
    public string satuan_suhu { get; set; } = "celcius";
    public int batas_hari_deman { get; set; } = 14;
    public string pesan_ditolak { get; set; } = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
    public string pesan_diterima { get; set; } = "Anda dipersilahkan untuk masuk ke dalam gedung ini";

    private static string filePath = "covid_config.json";

    public static CovidConfig LoadFromFile()
    {
        if (!File.Exists(filePath))
        {
            return new CovidConfig();
        }

        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<CovidConfig>(json) ?? new CovidConfig();
    }

    public void SaveToFile()
    {
        string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    public void UbahSatuan()
    {
        if (satuan_suhu.ToLower() == "celcius")
            satuan_suhu = "fahrenheit";
        else
            satuan_suhu = "celcius";

        SaveToFile();
    }
}
