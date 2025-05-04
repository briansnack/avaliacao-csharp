using System;

class Exercicio3
{
    public static void Rodar()
    {
        Console.Write("Digite um número inteiro positivo: ");
        string? entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int numero) || numero < 0)
        {
            Console.WriteLine("Entrada inválida. Digite um número inteiro positivo.");
            return;
        }

        int fatorial = 1;
        int contador = numero;

        while (contador > 1)
        {
            fatorial *= contador;
            contador--;
        }

        Console.WriteLine($"Fatorial de {numero} é {fatorial}");
    }
}