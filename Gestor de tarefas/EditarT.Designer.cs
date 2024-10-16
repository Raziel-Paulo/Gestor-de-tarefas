namespace Gestor_de_tarefas
{
    partial class EditarT
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
            Column4 = new DataGridViewCheckBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Prazo = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            titulot = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            tarefa = new TextBox();
            editar = new Button();
            Fechar = new Button();
            label5 = new Label();
            label6 = new Label();
            feito = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)listat).BeginInit();
            SuspendLayout();
            // 
            // listat
            // 
            listat.AllowUserToAddRows = false;
            listat.AllowUserToDeleteRows = false;
            listat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listat.Columns.AddRange(new DataGridViewColumn[] { Column4, Column3, Prazo, Column1, Column2 });
            listat.Location = new Point(322, 2);
            listat.Name = "listat";
            listat.ReadOnly = true;
            listat.Size = new Size(525, 254);
            listat.TabIndex = 1;
            // 
            // Column4
            // 
            Column4.HeaderText = "Feito";
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // titulot
            // 
            titulot.Location = new Point(12, 101);
            titulot.Name = "titulot";
            titulot.Size = new Size(212, 23);
            titulot.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 73);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 16;
            label4.Text = "Titulo da Tarefa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 181);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 15;
            label3.Text = "Prioridade";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 155);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Baixa", "Média", "Alta" });
            comboBox2.Location = new Point(12, 205);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 127);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 12;
            label2.Text = "Data Prazo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 231);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 11;
            label1.Text = "Tarefa";
            // 
            // tarefa
            // 
            tarefa.Location = new Point(12, 259);
            tarefa.Name = "tarefa";
            tarefa.Size = new Size(212, 23);
            tarefa.TabIndex = 10;
            // 
            // editar
            // 
            editar.Location = new Point(634, 352);
            editar.Name = "editar";
            editar.Size = new Size(110, 46);
            editar.TabIndex = 18;
            editar.Text = "Editar";
            editar.UseVisualStyleBackColor = true;
            editar.Click += editar_Click;
            // 
            // Fechar
            // 
            Fechar.Location = new Point(750, 352);
            Fechar.Name = "Fechar";
            Fechar.Size = new Size(97, 43);
            Fechar.TabIndex = 19;
            Fechar.Text = "Cancelar";
            Fechar.UseVisualStyleBackColor = true;
            Fechar.Click += Fechar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 8);
            label5.Name = "label5";
            label5.Size = new Size(245, 25);
            label5.TabIndex = 20;
            label5.Text = "Seleciona o que queres editar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 296);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 21;
            label6.Text = "Feito?";
            // 
            // feito
            // 
            feito.FormattingEnabled = true;
            feito.Items.AddRange(new object[] { "Sim", "Não" });
            feito.Location = new Point(12, 324);
            feito.Name = "feito";
            feito.Size = new Size(121, 23);
            feito.TabIndex = 22;
            // 
            // EditarT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 407);
            Controls.Add(feito);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Fechar);
            Controls.Add(editar);
            Controls.Add(titulot);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tarefa);
            Controls.Add(comboBox1);
            Controls.Add(listat);
            Name = "EditarT";
            Text = "Editar Tarefas";
            Load += EditarT_Load;
            ((System.ComponentModel.ISupportInitialize)listat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView listat;
        private ComboBox comboBox1;
        private TextBox titulot;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label1;
        private TextBox tarefa;
        private Button editar;
        private Button Fechar;
        private Label label5;
        private Label label6;
        private ComboBox feito;
        private DataGridViewCheckBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Prazo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}