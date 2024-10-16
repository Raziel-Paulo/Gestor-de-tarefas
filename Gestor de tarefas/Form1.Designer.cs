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
            Ttarefa = new DataGridViewTextBoxColumn();
            Prazo = new DataGridViewTextBoxColumn();
            Prioridade = new DataGridViewTextBoxColumn();
            Tarefa1 = new DataGridViewTextBoxColumn();
            Abrir = new Button();
            removert = new Button();
            EditarT = new Button();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            HabilidatarFiltro = new Button();
            RemoverFiltro = new Button();
            ((System.ComponentModel.ISupportInitialize)listat).BeginInit();
            SuspendLayout();
            // 
            // listat
            // 
            listat.AllowUserToAddRows = false;
            listat.AllowUserToOrderColumns = true;
            listat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listat.Columns.AddRange(new DataGridViewColumn[] { Column4, Ttarefa, Prazo, Prioridade, Tarefa1 });
            listat.Location = new Point(10, 64);
            listat.Name = "listat";
            listat.Size = new Size(644, 269);
            listat.TabIndex = 0;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Done";
            Column4.HeaderText = "Feito";
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Ttarefa
            // 
            Ttarefa.DataPropertyName = "Ttarefa";
            Ttarefa.HeaderText = "Titulo da Tarefa";
            Ttarefa.Name = "Ttarefa";
            // 
            // Prazo
            // 
            Prazo.DataPropertyName = "Prazo";
            Prazo.HeaderText = "Prazo";
            Prazo.Name = "Prazo";
            // 
            // Prioridade
            // 
            Prioridade.DataPropertyName = "Prioridade";
            Prioridade.HeaderText = "Prioridade";
            Prioridade.Name = "Prioridade";
            // 
            // Tarefa1
            // 
            Tarefa1.DataPropertyName = "Tarefa1";
            Tarefa1.HeaderText = "Tarefa";
            Tarefa1.Name = "Tarefa1";
            Tarefa1.Width = 200;
            // 
            // Abrir
            // 
            Abrir.Location = new Point(10, 12);
            Abrir.Name = "Abrir";
            Abrir.Size = new Size(208, 46);
            Abrir.TabIndex = 1;
            Abrir.Text = "Adicionar Tarefa";
            Abrir.UseVisualStyleBackColor = true;
            Abrir.Click += Abrir_Click;
            // 
            // removert
            // 
            removert.Location = new Point(438, 12);
            removert.Name = "removert";
            removert.Size = new Size(216, 46);
            removert.TabIndex = 3;
            removert.Text = "Remover Tarefas";
            removert.UseVisualStyleBackColor = true;
            removert.Click += removert_Click;
            // 
            // EditarT
            // 
            EditarT.Location = new Point(224, 12);
            EditarT.Name = "EditarT";
            EditarT.Size = new Size(208, 46);
            EditarT.TabIndex = 4;
            EditarT.Text = "Editar Tarefa";
            EditarT.UseVisualStyleBackColor = true;
            EditarT.Click += EditarT_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(660, 118);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 9;
            label4.Text = "Prazo";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(661, 146);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Baixa", "Média", "Alta" });
            comboBox1.Location = new Point(660, 200);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(660, 172);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 12;
            label1.Text = "Prioridade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(661, 226);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 13;
            label2.Text = "Feito";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Sim", "Não" });
            comboBox2.Location = new Point(661, 254);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 14;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // HabilidatarFiltro
            // 
            HabilidatarFiltro.Location = new Point(660, 64);
            HabilidatarFiltro.Name = "HabilidatarFiltro";
            HabilidatarFiltro.Size = new Size(201, 50);
            HabilidatarFiltro.TabIndex = 16;
            HabilidatarFiltro.Text = "Habilitar Filtro";
            HabilidatarFiltro.UseVisualStyleBackColor = true;
            HabilidatarFiltro.Click += HabilidatarFiltro_Click;
            // 
            // RemoverFiltro
            // 
            RemoverFiltro.Location = new Point(661, 283);
            RemoverFiltro.Name = "RemoverFiltro";
            RemoverFiltro.Size = new Size(93, 50);
            RemoverFiltro.TabIndex = 17;
            RemoverFiltro.Text = "Remover Filtro";
            RemoverFiltro.UseVisualStyleBackColor = true;
            RemoverFiltro.Click += RemoverFiltro_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 340);
            Controls.Add(RemoverFiltro);
            Controls.Add(HabilidatarFiltro);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(EditarT);
            Controls.Add(removert);
            Controls.Add(Abrir);
            Controls.Add(listat);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)listat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView listat;
        private Button Abrir;
        private Button removert;
        private Button EditarT;
        private DataGridViewCheckBoxColumn Column4;
        private DataGridViewTextBoxColumn Ttarefa;
        private DataGridViewTextBoxColumn Prazo;
        private DataGridViewTextBoxColumn Prioridade;
        private DataGridViewTextBoxColumn Tarefa1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button HabilidatarFiltro;
        private Button RemoverFiltro;
    }
}