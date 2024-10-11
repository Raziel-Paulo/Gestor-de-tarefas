using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Gestor_de_tarefas.Tarefa;

namespace Gestor_de_tarefas
{
    public partial class RemoverLista : Form
    {
        List<Tarefa> _listadoremover = new List<Tarefa>();
        public RemoverLista()
        {
            InitializeComponent();
        }
        public void LoadData(List<Tarefa> _tarefa1)
        {
            _listadoremover = _tarefa1;
            
        }
        private void RemoverLista_Load(object sender, EventArgs e)
        {
  
            foreach (var numerot in _listadoremover)
            {
                comboBox1.Items.Add(numerot.Numt);
            }
            foreach (var tarefa in _listadoremover)
            {
                this.listat.Rows.Add(tarefa.Numt, tarefa.Prazo, tarefa.Prioridade, tarefa.Tarefa1);
            }
        }

        private void removert_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                foreach (var numero in _listadoremover)
                {
                    if(comboBox1.SelectedIndex == numero.Numt )
                    {
                        _listadoremover.Remove(numero);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Falta selecionar o número da tarefa que quer remover");
                    }
                }
            }
        }
    }
}
