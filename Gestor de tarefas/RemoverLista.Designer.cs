﻿namespace Gestor_de_tarefas
{
    partial class RemoverLista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listat = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            removert = new Button();
            removertudo = new Button();
            cancelar = new Button();
            Column3 = new DataGridViewTextBoxColumn();
            Prazo = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)listat).BeginInit();
            SuspendLayout();
            // 
            // listat
            // 
            listat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listat.Columns.AddRange(new DataGridViewColumn[] { Column3, Prazo, Column1, Column2 });
            listat.Location = new Point(353, 3);
            listat.Name = "listat";
            listat.Size = new Size(444, 178);
            listat.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(335, 21);
            label1.TabIndex = 2;
            label1.Text = "Selecione oTitulo da Tarefa que deseja remover";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(131, 23);
            comboBox1.TabIndex = 3;
            // 
            // removert
            // 
            removert.Location = new Point(12, 62);
            removert.Name = "removert";
            removert.Size = new Size(104, 51);
            removert.TabIndex = 4;
            removert.Text = "Remover Tarefa";
            removert.UseVisualStyleBackColor = true;
            removert.Click += removert_Click;
            // 
            // removertudo
            // 
            removertudo.Location = new Point(12, 130);
            removertudo.Name = "removertudo";
            removertudo.Size = new Size(104, 51);
            removertudo.TabIndex = 5;
            removertudo.Text = "Remover Todas As Tarefas";
            removertudo.UseVisualStyleBackColor = true;
            removertudo.Click += removertudo_Click;
            // 
            // cancelar
            // 
            cancelar.Location = new Point(122, 130);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(104, 51);
            cancelar.TabIndex = 6;
            cancelar.Text = "Cancelar";
            cancelar.UseVisualStyleBackColor = true;
            cancelar.Click += cancelar_Click;
            // 
            // Column3
            // 
            Column3.HeaderText = "Titulo da Tarefa";
            Column3.Name = "Column3";
            // 
            // Prazo
            // 
            Prazo.HeaderText = "Prazo";
            Prazo.Name = "Prazo";
            // 
            // Column1
            // 
            Column1.HeaderText = "Prioridade";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tarefa";
            Column2.Name = "Column2";
            // 
            // RemoverLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 188);
            Controls.Add(cancelar);
            Controls.Add(removertudo);
            Controls.Add(removert);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(listat);
            Name = "RemoverLista";
            Text = "RemoverLista";
            Load += RemoverLista_Load;
            ((System.ComponentModel.ISupportInitialize)listat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView listat;
        private Label label1;
        private ComboBox comboBox1;
        private Button removert;
        private Button removertudo;
        private Button cancelar;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Prazo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}