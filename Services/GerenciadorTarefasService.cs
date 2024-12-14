using GerenciadorDeTarefas.Models;
using System;
using System.Collections.Generic;

namespace GerenciadorDeTarefas.Services
{
    public class GerenciadorTarefasService
    {
        private readonly List<Tarefa> tarefas = new List<Tarefa>();

        // Método para adicionar tarefa
        public string AdicionarTarefa(string titulo)
        {
<<<<<<< HEAD
=======
            if (string.IsNullOrWhiteSpace(titulo))
                throw new ArgumentException("O título da tarefa não pode ser vazio.");

>>>>>>> main
            tarefas.Add(new Tarefa { Titulo = titulo, Concluida = false });
            return "Tarefa adicionada com sucesso";
        }

        // Método para listar todas as tarefas
        public List<Tarefa> ListarTarefas() => tarefas;

        // Método para remover tarefa por índice
        public string RemoverTarefa(int indice)
        {
<<<<<<< HEAD
            if (indice < 0 || indice >= tarefas.Count) return "Índice inválido";
=======
            if (indice < 0 || indice >= tarefas.Count)
                throw new ArgumentOutOfRangeException("Índice inválido");

>>>>>>> main
            tarefas.RemoveAt(indice);
            return "Tarefa removida com sucesso";
        }

        // Método para concluir tarefa por índice
        public string ConcluirTarefa(int indice)
        {
<<<<<<< HEAD
            if (indice < 0 || indice >= tarefas.Count) return "Índice inválido";
            var tarefa = tarefas[indice];
            if (tarefa.Concluida) return "Tarefa já concluída";
=======
            if (indice < 0 || indice >= tarefas.Count)
                throw new ArgumentOutOfRangeException("Índice inválido");

            var tarefa = tarefas[indice];
            if (tarefa.Concluida)
                return "Tarefa já concluída";

>>>>>>> main
            tarefa.Concluida = true;
            return "Tarefa concluída com sucesso";
        }
    }
}
