using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace AccessControl.Core;

public sealed class EncryptedUserStore
{
    private readonly string path;
    private readonly string phrase;
    private byte[] salt = [];

    public EncryptedUserStore(string path, string phrase)
    {
        this.path = path;
        this.phrase = phrase;
    }

    public List<UserAccount> Load()
    {
        if (!File.Exists(path))
        {
            salt = RandomNumberGenerator.GetBytes(16);
            string passwordSalt = PasswordHelper.CreateSalt();
            var users = new List<UserAccount>
            {
                new()
                {
                    Name = "ADMIN",
                    PasswordSalt = passwordSalt,
                    PasswordHash = PasswordHelper.Hash("", passwordSalt)
                }
            };
            Save(users);
            return users;
        }

        byte[] file = File.ReadAllBytes(path);
        if (file.Length < 25)
            throw new InvalidDataException("Файл пользователей повреждён.");

        salt = file[..16];
        byte[] iv = file[16..24];
        byte[] encrypted = file[24..];

        try
        {
            byte[] json = FileCrypto.Decrypt(encrypted, CreateKey(salt), iv);
            var users = JsonSerializer.Deserialize<List<UserAccount>>(json);

            if (users is null || !users.Any(u => u.Name == "ADMIN"))
                throw new InvalidDataException();

            return users;
        }
        catch
        {
            throw new InvalidDataException("Неверная парольная фраза или файл пользователей повреждён.");
        }
    }

    public void Save(IReadOnlyList<UserAccount> users)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        if (salt.Length == 0)
            salt = RandomNumberGenerator.GetBytes(16);

        byte[] iv = RandomNumberGenerator.GetBytes(8);
        byte[] json = JsonSerializer.SerializeToUtf8Bytes(users);
        byte[] encrypted = FileCrypto.Encrypt(json, CreateKey(salt), iv);
        File.WriteAllBytes(path, [.. salt, .. iv, .. encrypted]);
    }

    private byte[] CreateKey(byte[] keySalt)
    {
        byte[] source = Encoding.UTF8.GetBytes(phrase).Concat(keySalt).ToArray();
        return MD5.HashData(source)[..8];
    }
}
