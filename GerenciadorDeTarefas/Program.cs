// See https://aka.ms/new-console-template for more information
using System;
using GerenciadorDeTarefas.Services;

namespace GerenciadorDeTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            var tarefaService = new GerenciadorTarefasService();
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("== Gerenciador De Tarefas ==");
                Console.WriteLine("1. Adicionar nova tarefa");
                Console.WriteLine("2. Exibir tarefas ativas");
                Console.WriteLine("3. Remover tarefa");
                Console.WriteLine("4. Marcar tarefa como concluída");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                // Validando a entrada do usuário
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção incorreta! Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o título da nova tarefa: ");
                        string titulo = Console.ReadLine();
                        tarefaService.AdicionarTarefas(titulo);
                        break;

                    case 2:
                        tarefaService.ListarTarefas();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Write("Digite o número da tarefa que deseja excluir: ");
                        if (int.TryParse(Console.ReadLine(), out int indiceRemover))
                        {
                            tarefaService.RemoverTarefas(indiceRemover);
                        }
                        else
                        {
                            Console.WriteLine("Número inválido! Pressione qualquer tecla para continuar...");
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Write("Digite o número da tarefa a ser concluída: ");
                        if (int.TryParse(Console.ReadLine(), out int indiceConcluir))
                        {
                            tarefaService.ConcluirTarefas(indiceConcluir);
                        }
                        else
                        {
                            Console.WriteLine("Número inválido! Pressione qualquer tecla para continuar...");
                        }
                        Console.ReadKey();
                        break;

                    case 0:
                        Console.WriteLine("Obrigado por utilizar o gerenciador de tarefas.");
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 0);
        }
    }
}
