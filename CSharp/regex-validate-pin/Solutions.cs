using System;
using System.Linq;

public class RegexValidatePin
{
    public static bool ValidatePin(string pin) =>
    //Checa nulidade e se o tamanho atende aos requisitos (4 ou 6)
    pin != null && (pin.Length == 4 || pin.Length == 6) &&
    //Garante que todos os caracteres sejam dígitos (LINQ)
    pin.All(char.IsDigit);
}

