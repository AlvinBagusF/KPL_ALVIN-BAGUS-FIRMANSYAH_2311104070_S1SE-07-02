class Program
{
    static void Main()
    {
        UserManager userManager = new UserManager();

        while (true)
        {
            Console.WriteLine("\n1. Registrasi");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Keluar");
            Console.Write("Pilih menu: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Masukkan username: ");
                    string regUsername = Console.ReadLine();
                    Console.Write("Masukkan password: ");
                    string regPassword = Console.ReadLine();

                    if (userManager.Register(regUsername, regPassword))
                        Console.WriteLine("Registrasi berhasil!");
                    else
                        Console.WriteLine("Registrasi gagal.");
                    break;

                case "2":
                    Console.Write("Masukkan username: ");
                    string loginUsername = Console.ReadLine();
                    Console.Write("Masukkan password: ");
                    string loginPassword = Console.ReadLine();

                    if (userManager.Login(loginUsername, loginPassword))
                        Console.WriteLine("Login berhasil!");
                    else
                        Console.WriteLine("Login gagal. Username/password salah.");
                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
        }
    }
}
