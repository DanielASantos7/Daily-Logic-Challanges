using System;

public class Kata
{
    public static string ToCamelCase(string str)
    {

        string resultado = "";
        string[] texto = str.Split('-', '_');

        for (int i = 0; i < texto.Length; i++)
        {
            if (i == 0)
            {
                resultado += texto[i];
            }
            else
            {
                resultado += char.ToUpper(texto[i][0]).ToString() + texto[i].Substring(1);
            }
        }

        return resultado;
    }
}