using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_tarefas
{
    public partial class EditarT : Form
    {
        List<Tarefa> _EditarT = new List<Tarefa>();
        public void LoadData(List<Tarefa> _tarefa1)
        {
            _EditarT = _tarefa1;
        }
        public EditarT()
        {
            InitializeComponent();
        }
        private void EditarT_Load(object sender, EventArgs e)
        {
            foreach (var mostrartarefa in _EditarT)
            {
                this.comboBox1.Items.Add(mostrartarefa.Ttarefa);
            }
            foreach (var tarefa in _EditarT)
            {
                this.listat.Rows.Add(tarefa.Tarefa1, tarefa.Prazo, tarefa.Prioridade, tarefa.Tarefa1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var tarefas in _EditarT)
            {
                if (comboBox1.Text == tarefas.Ttarefa)
                {
                   titulot.Text = tarefas.Tarefa1;
                    dateTimePicker1.Value = Convert.ToDateTime(tarefas.Prazo);
                    comboBox2.Text = tarefas.Prioridade;
                    tarefa.Text= tarefas.Tarefa1;
                }
            }
        }
    }
}
