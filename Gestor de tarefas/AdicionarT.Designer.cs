namespace Gestor_de_tarefas
{
    partial class AdicionarT
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
            tarefa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            prazo = new DateTimePicker();
            label3 = new Label();
            AddT = new Button();
            Fechar = new Button();
            SuspendLayout();
            // 
            // tarefa
            // 
            tarefa.Location = new Point(12, 174);
            tarefa.Name = "tarefa";
            tarefa.Size = new Size(212, 23);
            tarefa.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 146);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 1;
            label1.Text = "Tarefa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 2;
            label2.Text = "Data Prazo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Baixo", "Médio", "Alto" });
            comboBox1.Location = new Point(12, 108);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // prazo
            // 
            prazo.Location = new Point(12, 37);
            prazo.Name = "prazo";
            prazo.Size = new Size(200, 23);
            prazo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 5;
            label3.Text = "Prioridade";
            // 
            // AddT
            // 
            AddT.Location = new Point(12, 203);
            AddT.Name = "AddT";
            AddT.Size = new Size(97, 43);
            AddT.TabIndex = 6;
            AddT.Text = "Adicionar Tarefa";
            AddT.UseVisualStyleBackColor = true;
            AddT.Click += AddT_Click;
            // 
            // Fechar
            // 
            Fechar.Location = new Point(115, 203);
            Fechar.Name = "Fechar";
            Fechar.Size = new Size(97, 43);
            Fechar.TabIndex = 7;
            Fechar.Text = "Cancelar";
            Fechar.UseVisualStyleBackColor = true;
            Fechar.Click += Fechar_Click;
            // 
            // AdicionarT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Fechar);
            Controls.Add(AddT);
            Controls.Add(label3);
            Controls.Add(prazo);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tarefa);
            Name = "AdicionarT";
            Text = "AdicionarT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tarefa;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private DateTimePicker prazo;
        private Label label3;
        private Button AddT;
        private Button Fechar;
    }
}