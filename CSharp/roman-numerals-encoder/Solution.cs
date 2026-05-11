using System;
using System.Collections.Generic;

public class RomanConvert
{
    public static string Solution(int n)
    {
        List<int> valores = new List<int>()
        {
            1000, 900, 500, 400,
            100, 90, 50, 40,
            10, 9, 5, 4, 1
        };

        List<string> simbolos = new List<string>()
        {
            "M", "CM", "D", "CD",
            "C", "XC", "L", "XL",
            "X", "IX", "V", "IV", "I"
        };

        string resultado = "";

        for (int i = 0; i < valores.Count; i++)
        {
            while (n >= valores[i])
            {
                resultado += simbolos[i];
                n -= valores[i];
            }
        }

        return resultado;
    }
}