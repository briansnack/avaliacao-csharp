class Exercicio2
{
    public static void Rodar()  // Antes era Main()
    {
        Console.Write("Digite um número para ver a tabuada: ");
        string? entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int numero))
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            return;
        }

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}