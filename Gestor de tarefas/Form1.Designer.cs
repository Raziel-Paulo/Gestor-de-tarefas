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
            Column4 = new DataGridViewCheckBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Prazo = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Abrir = new Button();
            atualizar = new Button();
            removert = new Button();
            EditarT = new Button();
            ((System.ComponentModel.ISupportInitialize)listat).BeginInit();
            SuspendLayout();
            // 
            // listat
            // 
            listat.AllowUserToAddRows = false;
            listat.AllowUserToDeleteRows = false;
            listat.AllowUserToOrderColumns = true;
            listat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listat.Columns.AddRange(new DataGridViewColumn[] { Column4, Column3, Prazo, Column1, Column2 });
            listat.Location = new Point(10, 172);
            listat.Name = "listat";
            listat.ReadOnly = true;
            listat.Size = new Size(542, 150);
            listat.TabIndex = 0;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Done";
            Column4.HeaderText = "Done";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            Column3.HeaderText = "Titulo da Tarefa";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Prazo
            // 
            Prazo.HeaderText = "Prazo";
            Prazo.Name = "Prazo";
            Prazo.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Prioridade";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tarefa";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Abrir
            // 
            Abrir.Location = new Point(10, 12);
            Abrir.Name = "Abrir";
            Abrir.Size = new Size(110, 46);
            Abrir.TabIndex = 1;
            Abrir.Text = "Add Tarefa";
            Abrir.UseVisualStyleBackColor = true;
            Abrir.Click += Abrir_Click;
            // 
            // atualizar
            // 
            atualizar.Location = new Point(358, 12);
            atualizar.Name = "atualizar";
            atualizar.Size = new Size(110, 46);
            atualizar.TabIndex = 2;
            atualizar.Text = "Atualizar Tabela";
            atualizar.UseVisualStyleBackColor = true;
            atualizar.Click += atualizar_Click;
            // 
            // removert
            // 
            removert.Location = new Point(126, 12);
            removert.Name = "removert";
            removert.Size = new Size(110, 46);
            removert.TabIndex = 3;
            removert.Text = "Remover Tarefas";
            removert.UseVisualStyleBackColor = true;
            removert.Click += removert_Click;
            // 
            // EditarT
            // 
            EditarT.Location = new Point(242, 12);
            EditarT.Name = "EditarT";
            EditarT.Size = new Size(110, 46);
            EditarT.TabIndex = 4;
            EditarT.Text = "Editar Tarefa";
            EditarT.UseVisualStyleBackColor = true;
            EditarT.Click += EditarT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EditarT);
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
        private Button EditarT;
        private DataGridViewCheckBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Prazo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}