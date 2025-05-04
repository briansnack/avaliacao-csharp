using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Produto()
    {
        public string? Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double CalcularValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: R$ {Preco:F2}");
            Console.WriteLine($"Quantidade em estoque: {Quantidade}");
            Console.WriteLine($"Valor total em estoque: R$ {CalcularValorTotalEmEstoque():F2}");
            Console.WriteLine("----------------------------");
        }
    }
    public class Exercicio6
    {
        public static void Rodar()
        {
            Console.WriteLine(" Sistema de Cadastro de Produtos ");
            
            // Lista para armazenar os produtos
            List<Produto> produtos = new List<Produto>();
            
            // Cadastro de 3 produtos
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Cadastro do produto {i}:");
                
                Produto produto = new Produto();
                
                Console.Write("Nome: ");
                produto.Nome = Console.ReadLine();
                
                Console.Write("Preço (R$): ");
                double preco;
                // Tratamento de erros para garantir entrada válida
                while (!double.TryParse(Console.ReadLine(), out preco) || preco < 0)
                {
                    Console.Write("Preço inválido. Digite um valor numérico positivo: ");
                }
                produto.Preco = preco;
                
                Console.Write("Quantidade: ");
                int quantidade;
                while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade < 0)
                {
                    Console.Write("Quantidade inválida. Digite um valor inteiro positivo: ");
                }
                produto.Quantidade = quantidade;
                
                produtos.Add(produto);
            }
            
            Console.WriteLine(" Produtos Cadastrados ");
            double valorTotalGeral = 0;
            
            foreach (var p in produtos)
            {
                p.ExibirInformacoes();
                valorTotalGeral += p.CalcularValorTotalEmEstoque();
            }
            
            Console.WriteLine($"Valor total em estoque de todos os produtos: R$ {valorTotalGeral:F2}");
            
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
