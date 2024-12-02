using System;
using System.Windows.Forms;
using GerenciadorDeTarefas.Services;

namespace GerenciadorDeTarefas2._0
{
    public partial class Form1 : Form
    {
        private readonly GerenciadorTarefasService tarefaService;

        public Form1()
        {
            InitializeComponent();
            tarefaService = new GerenciadorTarefasService();
            AtualizarListaDeTarefas();
        }

        private void button1_Click(object sender, EventArgs e) => AdicionarTarefa();

        private void button2_Click(object sender, EventArgs e) => MarcarTarefaComoConcluida();

        private void button3_Click(object sender, EventArgs e) => RemoverTarefa();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) => AtualizarCamposDaTarefaSelecionada();

        private void AdicionarTarefa()
        {
            var titulo = txtTitulo.Text.Trim();
            if (string.IsNullOrEmpty(titulo)) return;
            MessageBox.Show(tarefaService.AdicionarTarefa(titulo));
            AtualizarListaDeTarefas();
        }

        private void MarcarTarefaComoConcluida()
        {
            if (listBox1.SelectedItem == null) return;
            MessageBox.Show(tarefaService.ConcluirTarefa(listBox1.SelectedIndex));
            AtualizarListaDeTarefas();
        }

        private void RemoverTarefa()
        {
            if (listBox1.SelectedItem == null) return;
            MessageBox.Show(tarefaService.RemoverTarefa(listBox1.SelectedIndex));
            AtualizarListaDeTarefas();
        }

        private void AtualizarListaDeTarefas()
        {
            listBox1.Items.Clear();
            foreach (var tarefa in tarefaService.ListarTarefas())
                listBox1.Items.Add(tarefa.Titulo);
        }

        private void AtualizarCamposDaTarefaSelecionada()
        {
            if (listBox1.SelectedIndex == -1) return;
            txtTitulo.Text = tarefaService.ListarTarefas()[listBox1.SelectedIndex].Titulo;
        }
    }
}
