using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Exercicio7
    {
        public static void Rodar()
        {
            Console.WriteLine(" Soma de Números Pares ");

            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");

                while (!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.Write($"Valor inválido. Digite o {i + 1}º número novamente: ");
                }
            }

            int somaPares = 0;
            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    somaPares += numero;
                }
            }

            Console.WriteLine("Números digitados:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Posição {i}: {numeros[i]} {(numeros[i] % 2 == 0 ? "(par)" : "(ímpar)")}");
            }

            Console.WriteLine($"A soma dos números pares é: {somaPares}");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}