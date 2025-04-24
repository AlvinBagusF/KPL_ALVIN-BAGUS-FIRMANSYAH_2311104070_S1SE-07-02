using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

public class BankTransferConfig
{
    public string lang { get; set; } = "en";

    public Transfer transfer { get; set; } = new Transfer();
    public List<string> methods { get; set; } = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" };

    public Confirmation confirmation { get; set; } = new Confirmation();

    private const string filePath = "bank_transfer_config.json";

    public static BankTransferConfig LoadConfig()
    {
        if (!File.Exists(filePath))
        {
            return new BankTransferConfig(); // default value
        }

        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<BankTransferConfig>(json) ?? new BankTransferConfig();
    }

    public class Transfer
    {
        public int threshold { get; set; } = 25000000;
        public int low_fee { get; set; } = 6500;
        public int high_fee { get; set; } = 15000;
    }

    public class Confirmation
    {
        public string en { get; set; } = "yes";
        public string id { get; set; } = "ya";
    }
}
