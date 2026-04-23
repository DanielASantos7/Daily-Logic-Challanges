using System;
using System.Text.RegularExpressions;

public class RegexValidatePin
{
    public static bool ValidatePin(string pin)
    {
        //Se for nulo ou tamanho errado, retorna falso.
        if (pin == null || (pin.Length != 4 && pin.Length != 6))
        {
            return false;
        }

        // Percorre toda string
        foreach (char c in pin)
        {
            // Se não for um Dígito
            if (!char.IsDigit(c))
            {
                return false;
            }
        }

        // Se chegou aqui, é porque é válido.
        return true;
    }
}

