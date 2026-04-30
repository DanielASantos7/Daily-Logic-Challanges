using System;

public class Kata
{
    public static bool Narcissistic(int value)
    {
        string str = value.ToString();
        int soma = 0;

        foreach (char c in str)
        {
            int n = int.Parse(c.ToString());
            soma += (int)Math.Pow(n, str.Length);
        }

        return soma == value;
    }
}