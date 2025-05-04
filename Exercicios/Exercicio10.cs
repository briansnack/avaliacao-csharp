using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Tarefa
    {
        public string Descricao { get; set; }
        public bool Concluida { get; set; }

        public Tarefa(string descricao)
        {
            Descricao = descricao;
            Concluida = false;
        }

        public override string ToString()
        {
            return $"[{(Concluida ? "X" : " ")}] {Descricao}";
        }
    }
    public class Exercicio10
    {
        public static void Rodar()
        {
            List<Tarefa> tarefas = new List<Tarefa>();
            bool sair = false;

            Console.WriteLine("=== GERENCIADOR DE TAREFAS ===");

            while (!sair)
            {
                Console.WriteLine("\nOpções:");
                Console.WriteLine("1. Adicionar tarefa");
                Console.WriteLine("2. Marcar tarefa como concluída");
                Console.WriteLine("3. Listar todas as tarefas");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarTarefa(tarefas);
                        break;
                    case "2":
                        MarcarComoConcluida(tarefas);
                        break;
                    case "3":
                        ListarTarefas(tarefas);
                        break;
                    case "4":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void AdicionarTarefa(List<Tarefa> tarefas)
        {
            Console.Write("Digite a descrição da tarefa: ");
            string descricao = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(descricao))
            {
                tarefas.Add(new Tarefa(descricao));
                Console.WriteLine("Tarefa adicionada com sucesso!");
            }
            else
            {
                Console.WriteLine("Descrição não pode ser vazia.");
            }
        }

        static void MarcarComoConcluida(List<Tarefa> tarefas)
        {
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Não há tarefas para marcar como concluídas.");
                return;
            }

            Console.WriteLine("Tarefas pendentes:");
            for (int i = 0; i < tarefas.Count; i++)
            {
                if (!tarefas[i].Concluida)
                {
                    Console.WriteLine($"{i + 1}. {tarefas[i].Descricao}");
                }
            }

            Console.Write("Digite o número da tarefa a marcar como concluída: ");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= tarefas.Count)
            {
                if (!tarefas[indice - 1].Concluida)
                {
                    tarefas[indice - 1].Concluida = true;
                    Console.WriteLine("Tarefa marcada como concluída!");
                }
                else
                {
                    Console.WriteLine("Esta tarefa já está concluída.");
                }
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }

        static void ListarTarefas(List<Tarefa> tarefas)
        {
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
                return;
            }

            Console.WriteLine("\n=== LISTA DE TAREFAS ===");
            for (int i = 0; i < tarefas.Count; i++)
            {
                string status = tarefas[i].Concluida ? "[X]" : "[ ]";
                Console.WriteLine($"{i + 1}. {status} {tarefas[i].Descricao}");
            }
        }
    }
}