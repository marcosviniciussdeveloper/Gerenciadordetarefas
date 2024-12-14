
namespace GerenciadorDeTarefas2._0
{
    public static class DesignerHelper
    {
        public static void AplicarEstiloBotao(Button botao)
        {
            botao.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            botao.ForeColor = System.Drawing.Color.White;
            botao.FlatStyle = FlatStyle.Flat;
            botao.FlatAppearance.BorderSize = 0;
            botao.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
        }

        public static void AplicarEstiloFormulario(Form form)
        {
            form.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            form.Font = new System.Drawing.Font("Segoe UI", 10);
            form.ForeColor = System.Drawing.Color.White;
        }

        public static void AplicarEstiloLista(ListBox listbox)
        {
            listbox.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            listbox.ForeColor = System.Drawing.Color.White;
            listbox.BorderStyle = BorderStyle.None;
        }

        public static void AplicarEstiloNoTExto(TextBox textBox)
        {
            textBox.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            textBox.ForeColor = System.Drawing.Color.White;
            textBox.BorderStyle = BorderStyle.FixedSingle;
        }

        public static void AjustarLayout(Form form, TextBox txtTitulo, Button button1, Button button2, Button button3, ListBox listBox1)
        {
            txtTitulo.Width = form.ClientSize.Width - 32;

            button1.Width = button2.Width = button3.Width = (form.ClientSize.Width - 48) / 3;

            listBox1.Width = form.ClientSize.Width - 32;

            listBox1.Height = form.ClientSize.Height - listBox1.Top - 48;
        }
    }
}