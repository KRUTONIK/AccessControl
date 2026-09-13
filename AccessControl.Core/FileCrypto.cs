using System.Security.Cryptography;

namespace AccessControl.Core;

public static class FileCrypto
{
    public static byte[] Encrypt(byte[] source, byte[] key, byte[] iv)
    {
        using DES des = CreateDes(key);
        return des.EncryptCfb(source, iv, PaddingMode.None, 8);
    }

    public static byte[] Decrypt(byte[] source, byte[] key, byte[] iv)
    {
        using DES des = CreateDes(key);
        return des.DecryptCfb(source, iv, PaddingMode.None, 8);
    }

    private static DES CreateDes(byte[] key)
    {
        if (key.Length != 8)
            throw new ArgumentException("Ключ DES должен содержать 8 байт.", nameof(key));

        byte[] validKey = (byte[])key.Clone();
        while (DES.IsWeakKey(validKey) || DES.IsSemiWeakKey(validKey))
            validKey[^1]++;

        DES des = DES.Create();
        des.Key = validKey;
        return des;
    }
}
