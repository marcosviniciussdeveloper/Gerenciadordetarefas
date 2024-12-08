using System;
using System.Windows.Forms;

namespace GerenciadorDeTarefas2._0
{
    partial class Form1
    {
        /// <summary>
        /// Variável necessária para o designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //private System.Windows.Forms.Panel menuPanel; // Remover esta linha
        private TextBox txtTitulo;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se os recursos gerenciados devem ser descartados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Windows Forms

        /// <summary>
        /// Método necessário para o suporte ao Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtTitulo = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();

            // txtTitulo
            txtTitulo.Location = new Point(16, 18);
            txtTitulo.Margin = new Padding(4, 5, 4, 5);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(345, 27);
            txtTitulo.TabIndex = 0;

            // button1 (Adicionar)
            button1.Location = new Point(16, 58);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 1;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            // button2 (Concluir)
            button2.Location = new Point(124, 58);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 2;
            button2.Text = "Concluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;

            // button3 (Remover)
            button3.Location = new Point(232, 58);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(100, 35);
            button3.TabIndex = 3;
            button3.Text = "Remover";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;

            // listBox1
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(13, 103);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(345, 264);
            listBox1.TabIndex = 4;

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 402);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTitulo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Gerenciador de Tarefas";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
