using System.Security.Cryptography;
using System.Text;

namespace AccessControl.Core;

public static class PasswordHelper
{
    public const string VariantRule =
        "Пароль должен чередовать цифры и знаки препинания: цифра, знак, цифра и т. д.";

    public static string Hash(string password) => Hash(password, "");

    public static string Hash(string password, string salt)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(password + salt);
        return Convert.ToHexString(MD5.HashData(bytes));
    }

    public static string CreateSalt() =>
        Convert.ToHexString(RandomNumberGenerator.GetBytes(16));

    public static bool IsValid(UserAccount user, string password, out string error)
    {
        if (password.Length < user.MinimumPasswordLength)
        {
            error = $"Минимальная длина пароля: {user.MinimumPasswordLength}.";
            return false;
        }

        if (!user.UsePasswordRestriction)
        {
            error = "";
            return true;
        }

        if (password.Length < 3 || password.Length % 2 == 0)
        {
            error = VariantRule;
            return false;
        }

        for (int i = 0; i < password.Length; i++)
        {
            bool valid = i % 2 == 0
                ? char.IsDigit(password[i])
                : char.IsPunctuation(password[i]);

            if (!valid)
            {
                error = VariantRule;
                return false;
            }
        }

        error = "";
        return true;
    }
}
