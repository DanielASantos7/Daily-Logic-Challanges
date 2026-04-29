using System;

public class Kata
{
    public static int DuplicateCount(string str)
    {

        Dictionary<char, int> mapa = new Dictionary<char, int>();

        str = str.ToLower();

        foreach (char c in str)
        {
            if (mapa.ContainsKey(c))
            {
                mapa[c]++;
            }
            else
            {
                mapa[c] = 1;
            }

        }

        int cont = 0;
        foreach (var item in mapa)
        {
            if (item.Value > 1)
            {
                cont++;
            }
        }

        return cont;
    }
}