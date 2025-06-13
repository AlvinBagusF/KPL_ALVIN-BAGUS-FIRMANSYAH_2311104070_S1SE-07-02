using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

public class UserManager
{
    private const string FilePath = "users.json";
    private List<UserData> users = new List<UserData>();

    public UserManager()
    {
        LoadUsers();
    }

    private void LoadUsers()
    {
        if (File.Exists(FilePath))
        {
            string json = File.ReadAllText(FilePath);
            users = JsonSerializer.Deserialize<List<UserData>>(json) ?? new List<UserData>();
        }
    }

    private void SaveUsers()
    {
        string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FilePath, json);
    }

    private string HashPassword(string password)
    {
        using (SHA256 sha = SHA256.Create())
        {
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }

    private bool IsValidUsername(string username)
    {
        return username.All(c => char.IsLetter(c)); // hanya alfabet ASCII
    }

    private bool IsValidPassword(string password, string username)
    {
        if (password.Length < 6 || password.Length > 20)
            return false;
        if (!password.Any(ch => "!@#$%^&*".Contains(ch)))
            return false;
        if (password.ToLower().Contains(username.ToLower()))
            return false;
        return true;
    }

    public bool Register(string username, string password)
    {
        if (!IsValidUsername(username))
        {
            Console.WriteLine("Username hanya boleh huruf alfabet!");
            return false;
        }

        if (!IsValidPassword(password, username))
        {
            Console.WriteLine("Password tidak memenuhi aturan!");
            return false;
        }

        if (users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("Username sudah terdaftar.");
            return false;
        }

        var user = new UserData { Username = username, PasswordHash = HashPassword(password) };
        users.Add(user);
        SaveUsers();
        return true;
    }

    public bool Login(string username, string password)
    {
        string hash = HashPassword(password);
        return users.Any(u => u.Username == username && u.PasswordHash == hash);
    }
}
