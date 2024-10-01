using System;

public class InsecureRandomExample
{
    public string GenerateToken(int length)
    {
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        char[] token = new char[length];

        for (int i = 0; i < length; i++)
        {
            token[i] = chars[random.Next(chars.Length)];
        }

        return new string(token);
    }

    public static void Main(string[] args)
    {
        InsecureRandomExample example = new InsecureRandomExample();
        string token = example.GenerateToken(16);
        Console.WriteLine($"Generated Token: {token}");
    }
}
