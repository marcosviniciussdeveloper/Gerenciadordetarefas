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
            tarefas.Add(new Tarefa { Titulo = titulo, Concluida = false });
            return "Tarefa adicionada com sucesso";
        }

        // Método para listar todas as tarefas
        public List<Tarefa> ListarTarefas() => tarefas;

        // Método para remover tarefa por índice
        public string RemoverTarefa(int indice)
        {
            if (indice < 0 || indice >= tarefas.Count) return "Índice inválido";
            tarefas.RemoveAt(indice);
            return "Tarefa removida com sucesso";
        }

        // Método para concluir tarefa por índice
        public string ConcluirTarefa(int indice)
        {
            if (indice < 0 || indice >= tarefas.Count) return "Índice inválido";
            var tarefa = tarefas[indice];
            if (tarefa.Concluida) return "Tarefa já concluída";
            tarefa.Concluida = true;
            return "Tarefa concluída com sucesso";
        }
    }
}
