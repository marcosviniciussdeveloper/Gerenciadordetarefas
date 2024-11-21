using GerenciadorDeTarefas.Models;
using System;
using System.Collections.Generic;

namespace GerenciadorDeTarefas.Services
{
    private readonly List<Tarefas> tarefas = new List<Tarefas>();


    public void AdicionarTarefas(Tarefas tarefas)
    {
        Tarefas.Titulo = titulo;
        concluida = false; 
         tarefas.Add(tarefas);

    }
    private void listartarefas(Listar listar)
    {
        
        Console.Writeline("Aqui está todas as suas tarefas :")
        if (tarefas.Count == 0)
        {
            Console.WriteLine("Não ha tarefas a serem realizadas")
            return Tarefas;
         
            
          foreach (var tarefas in tarefas) 
            {

                Console.WriteLine($"Título: {tarefa.Titulo}, Concluída: {tarefa.Concluida}");

            }
        }

       
    }

    public void RemoverTarefas(Remover remover)  
    {
        if numnero >= 0 && numero < tarefas.Count)
        {
            tarefas.RemoverAt(numero);
        }
        else 
        }
          Console.WriteLine("Posição do Indice  invalida")
        }



        public void ConcluirTarefas(int numero)
        {
          if (numero < 0 || numero >= tarefa.Length)
          {
        Console.WriteLine("Erro: Número de tarefa inválido.");
        return;
          }

    tarefa[numero].Concluida = true;
    Console.WriteLine("Tarefa concluída com sucesso!");
        }

            




   


}