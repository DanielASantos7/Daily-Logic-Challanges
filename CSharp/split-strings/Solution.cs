using System.Collections.Generic;

public class SplitString
{
    public static string[] Solution(string str)
    {
        List<string> lista = new List<string>();

        if (str.Length % 2 != 0)
        {
            str += "_";
        }

        for (int i = 0; i < str.Length; i += 2)
        {
            lista.Add("" + str[i] + str[i + 1]);
        }
        return lista.ToArray();
    }
}