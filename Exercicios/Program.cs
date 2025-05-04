using Exercicios;

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
        Console.WriteLine("6 - Cadastro de Produtos");
        Console.WriteLine("7 - Soma de Números Pares de um Array");
        Console.WriteLine("8 - Cálculo de IMC com Classificação");
        Console.WriteLine("9 -  Jogo da Adivinhaçãos");
        Console.WriteLine("10 - Gerencimento de Tarefas");
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
            case "6":
                Exercicio6.Rodar();
                break;
            case "7":
                Exercicio7.Rodar();
                break;
            case "8":
                Exercicio8.Rodar();
                break;
            case "9":
                Exercicio9.Rodar();
                break;
            case "10":
                Exercicio10.Rodar();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}