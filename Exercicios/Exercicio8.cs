using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Exercicio8
    {
        public static void Rodar()
        {
            Console.WriteLine("=== Calculadora de IMC ===");

            Console.Write("Digite seu peso (em kg): ");
            double peso;
            while (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0)
            {
                Console.Write("Valor inválido! Digite seu peso (em kg): ");
            }

            Console.Write("Digite sua altura (em metros, ex: 1,80): ");
            double altura;
            while (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0)
            {
                Console.Write("Valor inválido! Digite sua altura (em metros): ");
            }

            double imc = peso / (altura * altura);
            string classificacao;

            if (imc < 18.5)
            {
                classificacao = "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                classificacao = "Peso normal";
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                classificacao = "Sobrepeso";
            }
            else // imc >= 30
            {
                classificacao = "Obesidade";
            }

            Console.WriteLine("=== Resultado do IMC ===");
            Console.WriteLine($"Seu IMC é: {imc:F2}");
            Console.WriteLine($"Classificação: {classificacao}");

            Console.WriteLine(" Tabela de Referência ");
            Console.WriteLine("• Abaixo de 18.5: Abaixo do peso");
            Console.WriteLine("• 18.5 a 24.9: Peso normal");
            Console.WriteLine("• 25 a 29.9: Sobrepeso");
            Console.WriteLine("• 30 ou mais: Obesidade");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}