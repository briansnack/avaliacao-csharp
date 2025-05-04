using System;
using System.Text.RegularExpressions;

class Exercicio5
{
    public static void Rodar()
    {
        Console.Write("Digite uma palavra ou frase: ");
        string? entrada = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }

        entrada = entrada.ToLower();
        entrada = Regex.Replace(entrada, "[^a-z0-9]", "");

        char[] arr = entrada.ToCharArray();
        Array.Reverse(arr);
        string reverso = new string(arr);

        if (entrada == reverso)
            Console.WriteLine("É um palíndromo!");
        else
            Console.WriteLine("Não é um palíndromo.");
    }
}