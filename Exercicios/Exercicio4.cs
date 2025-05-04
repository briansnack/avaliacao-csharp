using System;

class Exercicio4
{
    public static void Rodar()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");

            string? entradaOpcao = Console.ReadLine();
            if (!int.TryParse(entradaOpcao, out opcao))
            {
                Console.WriteLine("Entrada inválida. Tente novamente.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a temperatura em Celsius: ");
                    string? entradaC = Console.ReadLine();
                    if (double.TryParse(entradaC, out double c))
                    {
                        Console.WriteLine($"Resultado: {(c * 9 / 5) + 32} °F");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case 2:
                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    string? entradaF = Console.ReadLine();
                    if (double.TryParse(entradaF, out double f))
                    {
                        Console.WriteLine($"Resultado: {(f - 32) * 5 / 9} °C");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (opcao != 3);
    }
}