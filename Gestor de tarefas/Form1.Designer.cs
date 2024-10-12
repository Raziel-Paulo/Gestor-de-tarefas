namespace Gestor_de_tarefas
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listat = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Prazo = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Abrir = new Button();
            atualizar = new Button();
            removert = new Button();
            ((System.ComponentModel.ISupportInitialize)listat).BeginInit();
            SuspendLayout();
            // 
            // listat
            // 
            listat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listat.Columns.AddRange(new DataGridViewColumn[] { Column3, Prazo, Column1, Column2 });
            listat.Location = new Point(54, 252);
            listat.Name = "listat";
            listat.Size = new Size(444, 150);
            listat.TabIndex = 0;
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
            // Abrir
            // 
            Abrir.Location = new Point(386, 88);
            Abrir.Name = "Abrir";
            Abrir.Size = new Size(112, 55);
            Abrir.TabIndex = 1;
            Abrir.Text = "Add Tarefa";
            Abrir.UseVisualStyleBackColor = true;
            Abrir.Click += Abrir_Click;
            // 
            // atualizar
            // 
            atualizar.Location = new Point(386, 174);
            atualizar.Name = "atualizar";
            atualizar.Size = new Size(112, 55);
            atualizar.TabIndex = 2;
            atualizar.Text = "Atualizar Tabela";
            atualizar.UseVisualStyleBackColor = true;
            atualizar.Click += atualizar_Click;
            // 
            // removert
            // 
            removert.Location = new Point(191, 128);
            removert.Name = "removert";
            removert.Size = new Size(112, 55);
            removert.TabIndex = 3;
            removert.Text = "Remover Tarefas";
            removert.UseVisualStyleBackColor = true;
            removert.Click += removert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(removert);
            Controls.Add(atualizar);
            Controls.Add(Abrir);
            Controls.Add(listat);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)listat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView listat;
        private Button Abrir;
        private Button atualizar;
        private Button removert;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Prazo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}