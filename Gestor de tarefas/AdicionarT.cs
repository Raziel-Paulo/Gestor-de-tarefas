using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_tarefas
{
    public partial class AdicionarT : Form
    {
        List<add.Tarefa> _lista = new List<add.Tarefa>();
        public void LoadData(List<add.Tarefa> _tarefa1)
        {
            _lista = _tarefa1;
        }
        public AdicionarT()
        {
            InitializeComponent();
        }

        private void AddT_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex== -1)
            {
                MessageBox.Show("Falta preencher o grau da prioridade");
            }
            if (tarefa.Text== "")
            {
                MessageBox.Show("Falta preencher o que é a tarefa");
            }
            
            if(comboBox1.SelectedIndex != -1 && tarefa.Text != "")
            {
                var novaTarefa = new add.Tarefa
                {
                    Numt = _lista.Count +1,
                    Prazo = Convert.ToDateTime(prazo.Text),
                    Tarefa1 = tarefa.Text,
                };
                if (comboBox1.SelectedIndex == 0)
                {
                    novaTarefa.Prioridade += " (Baixa)";
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    novaTarefa.Prioridade += " (Média)";
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    novaTarefa.Prioridade += " (Alta)";
                }
                _lista.Add(novaTarefa);
                Close();
            }
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
