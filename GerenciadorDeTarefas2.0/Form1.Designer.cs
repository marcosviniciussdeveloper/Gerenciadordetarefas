using GerenciadorDeTarefas.Models;
using GerenciadorDeTarefas.Services;
using System;
using System.Collections.Generic;

namespace GerenciadorDeTarefas2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private GerenciadorTarefasService tarefasService = new GerenciadorTarefasService();

        private bool ConfirmarRemocao (string mensagem  , string titulo)
        {

        return MessageBox.Show(mensagem, titulo ,  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
 
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTitulo = new TextBox();  // Certifique-se de que txtTitulo é inicializado aqui
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(120, 147);  // Posicionei a caixa de texto
            txtTitulo.Name = "txtTitulo";  // Nome do controle é txtTitulo
            txtTitulo.Size = new Size(492, 27);  // Defina o tamanho
            txtTitulo.TabIndex = 0;  // Defina o índice
            // 
            // button1
            // 
            button1.Location = new Point(120, 222);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 1;
            button1.Text = "Adicionar Tarefa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(315, 222);
            button2.Name = "button2";
            button2.Size = new Size(130, 29);
            button2.TabIndex = 2;
            button2.Text = "Concluir Tarefa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(484, 222);
            button3.Name = "button3";
            button3.Size = new Size(128, 29);
            button3.TabIndex = 3;
            button3.Text = "Remover Tarefa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(295, 290);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTitulo);  
            Name = "Form1";
            Text = "Gerenciador de Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo; 
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
    }
}

