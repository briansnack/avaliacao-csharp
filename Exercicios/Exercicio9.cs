using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Exercicio9
    {
        public static void Rodar()
        {
            Console.WriteLine(" JOGO DE ADIVINHAÇÃO ");
            Console.WriteLine("Estou pensando em um número entre 1 e 100.");
            Console.WriteLine("Tente adivinhar qual é!");
            
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int numeroTentativas = 0;
            bool acertou = false;
            
            while (!acertou)
            {
                Console.Write("Digite seu palpite: ");

                int palpite;
                bool entradaValida = int.TryParse(Console.ReadLine(), out palpite);

                if (!entradaValida)
                {
                    Console.WriteLine("Por favor, digite apenas números inteiros.");
                    continue;
                }
                
                if (palpite < 1 || palpite > 100)
                {
                    Console.WriteLine("Por favor, digite um número entre 1 e 100.");
                    continue;
                }
                
                numeroTentativas++;
                
                if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é MAIOR que seu palpite.");
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("O número secreto é MENOR que seu palpite.");
                }
                else
                {
                    acertou = true;
                    Console.WriteLine($"PARABÉNS! Você acertou em {numeroTentativas} tentativa(s)!");
                    
                    if (numeroTentativas <= 3)
                    {
                        Console.WriteLine("Impressionante! Você tem um ótimo instinto!");
                    }
                    else if (numeroTentativas <= 7)
                    {
                        Console.WriteLine("Muito bom! Você é um bom jogador!");
                    }
                    else if (numeroTentativas <= 15)
                    {
                        Console.WriteLine("Bom trabalho! Continue praticando!");
                    }
                    else
                    {
                        Console.WriteLine("Você conseguiu! Da próxima vez será mais rápido!");
                    }
                }
            }
            
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}