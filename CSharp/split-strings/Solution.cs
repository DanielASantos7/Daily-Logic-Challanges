using System.Collections.Generic;

public class SplitString
{
    public static string[] Solution(string str)
    {
        List<string> lista = new List<string>();
        for (int i = 0; i < str.Length; i += 2)
        {
            if (i + 1 < str.Length)
            {
                lista.Add("" + str[i] + str[i + 1]);
            }
            else
            {
                lista.Add(str[i] + "_");
            }
        }

        return lista.ToArray();
    }
}