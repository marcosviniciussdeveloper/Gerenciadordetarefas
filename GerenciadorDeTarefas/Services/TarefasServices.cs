using GerenciadorDeTarefas.Models;
using System;
using System.Collections.Generic;

namespace GerenciadorDeTarefas.Services
{

   public class GerenciadorTarefasService
    { 

    private readonly List<Tarefa> tarefas = new List<Tarefa>();

    //Metodo para adicionar tarefa 
    public void AdicionarTarefas(string titulo)
    {

            var novaTarefa = new Tarefa
            {
                Titulo = titulo,
                Concluida = false
            };


        tarefas.Add(novaTarefa);
        Console.WriteLine("Tarefa adicionada com sucesso");
    }
        //Met�do para exibir o numero de  tarefas
        public void ListarTarefas()
        {

            Console.WriteLine("Aqui est� todas as suas tarefas :");
   

          if (tarefas.Count == 0)
            {
                Console.WriteLine("N�o h� tarefas a serem realizadas");
            return;
            }
            foreach (var tarefa in tarefas)
            {

                Console.WriteLine($"T�tulo: {tarefa.Titulo}, Conclu�da: {tarefa.Concluida}");

            }
        }

    public void RemoverTarefas(int remover)
    {
        if (remover >= 0 && remover < tarefas.Count)
        {
        tarefas.RemoveAt(remover);
        Console.WriteLine("Tarefa Removida com sucesso");
        }

        else
        {
        Console.WriteLine("Posi��o do Indice  invalida");
        }
   }


    public void ConcluirTarefas(int numero)
    {
       if (numero < 0 || numero >= tarefas.Count)
       {
        
       Console.WriteLine("Erro: N�mero de tarefa inv�lido.");
       return;
       }

       tarefas[numero].Concluida = true;
       Console.WriteLine("Tarefa conclu�da com sucesso!");


       }
    }
}