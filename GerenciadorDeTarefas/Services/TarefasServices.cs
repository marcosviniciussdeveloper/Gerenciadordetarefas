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
        
        Console.Writeline("Aqui est� todas as suas tarefas :")
        if (tarefas.Count == 0)
        {
            Console.WriteLine("N�o ha tarefas a serem realizadas")
            return Tarefas;
         
            
          foreach (var tarefas in tarefas) 
            {

                Console.WriteLine($"T�tulo: {tarefa.Titulo}, Conclu�da: {tarefa.Concluida}");

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
          Console.WriteLine("Posi��o do Indice  invalida")
        }



        public void ConcluirTarefas(int numero)
        {
          if (numero < 0 || numero >= tarefa.Length)
          {
        Console.WriteLine("Erro: N�mero de tarefa inv�lido.");
        return;
          }

    tarefa[numero].Concluida = true;
    Console.WriteLine("Tarefa conclu�da com sucesso!");
        }

            




   


}