// See https://aka.ms/new-console-template for more information
using System;
using GerenciadorDeTarefas.Services

namespace GerenciadorDeTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            var tarefaservice = new TarefasServices();
            int opção;


            do
            {

              Console.Clear();
                Console.WriteLine("==GerenciadorDeTarefas==");
                Console.WriteLine("1.Adicionar nova tarefa");
                Console.WriteLine("2.Exbir numeros de tarefas ativas");
                Console.WriteLine("3.Remover tarefa");
                Console.WriteLine("4.Marcar tarefa como concluida");






            }

