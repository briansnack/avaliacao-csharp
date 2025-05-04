class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha um exercício para rodar:");
        Console.WriteLine("1 - Validação de senha");
        Console.WriteLine("2 - Tabuada");
        Console.WriteLine("3 - Fatorial");
        Console.WriteLine("4 - Conversão de temperatura");
        Console.WriteLine("5 - Palíndromo");
        Console.Write("Digite o número do exercício: ");

        string? escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                Exercicio1.Rodar();
                break;
            case "2":
                Exercicio2.Rodar();  
                break;
            case "3":
                Exercicio3.Rodar();
                break;
            case "4":
                Exercicio4.Rodar();
                break;
            case "5":
                Exercicio5.Rodar();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}