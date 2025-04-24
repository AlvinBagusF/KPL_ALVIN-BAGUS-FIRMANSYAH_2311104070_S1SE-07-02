using System;

class Program
{
    static void Main(string[] args)
    {
        var config = BankTransferConfig.LoadConfig();

        // Step 1: Input transfer amount
        string prompt = config.lang == "id" ?
            "Masukkan jumlah uang yang akan di-transfer:" :
            "Please insert the amount of money to transfer:";

        Console.WriteLine(prompt);
        int amount = Convert.ToInt32(Console.ReadLine());

        // Step 2: Hitung biaya transfer
        int fee = amount <= config.transfer.threshold ? config.transfer.low_fee : config.transfer.high_fee;
        int total = amount + fee;

        if (config.lang == "id")
        {
            Console.WriteLine($"Biaya transfer = {fee}");
            Console.WriteLine($"Total biaya = {total}");
        }
        else
        {
            Console.WriteLine($"Transfer fee = {fee}");
            Console.WriteLine($"Total amount = {total}");
        }

        // Step 3: Pilih metode transfer
        Console.WriteLine(config.lang == "id" ? "Pilih metode transfer:" : "Select transfer method:");
        for (int i = 0; i < config.methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.methods[i]}");
        }

        int pilih = Convert.ToInt32(Console.ReadLine()); // input pilihan metode (tidak divalidasi)

        // Step 4: Konfirmasi transaksi
        string konfirmasi = config.lang == "id" ?
            $"Ketik \"{config.confirmation.id}\" untuk mengkonfirmasi transaksi:" :
            $"Please type \"{config.confirmation.en}\" to confirm the transaction:";

        Console.WriteLine(konfirmasi);
        string input = Console.ReadLine();

        bool confirmed = (config.lang == "id" && input == config.confirmation.id) ||
                         (config.lang == "en" && input == config.confirmation.en);

        if (confirmed)
        {
            Console.WriteLine(config.lang == "id" ? "Proses transfer berhasil" : "The transfer is completed");
        }
        else
        {
            Console.WriteLine(config.lang == "id" ? "Transfer dibatalkan" : "Transfer is cancelled");
        }
    }
}
