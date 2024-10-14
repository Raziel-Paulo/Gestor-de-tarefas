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
                this.listat.Rows.Add(tarefa.Ttarefa, tarefa.Prazo, tarefa.Prioridade, tarefa.Tarefa1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var tarefas in _EditarT)
            {
                if (comboBox1.Text == tarefas.Ttarefa)
                {
                    titulot.Text = tarefas.Tarefa1;
                    dateTimePicker1.Value = Convert.ToDateTime(tarefas.Prazo);
                    tarefa.Text = tarefas.Tarefa1;
                    if (tarefas.Prioridade == " (Baixa)")
                    {
                        comboBox2.SelectedIndex = 0;
                    }
                    else if (tarefas.Prioridade == " (Média)")
                    {
                        comboBox2.SelectedIndex = 1;
                    }
                    else if (tarefas.Prioridade == " (Alta)")
                    {
                        comboBox2.SelectedIndex = 2;
                    }
                }
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Não selecionaste o que queres editar");
            }
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Falta preencher o grau da prioridade");
            }
            if (tarefa.Text == "")
            {
                MessageBox.Show("Falta preencher o que é a tarefa");
            }
            if (titulot.Text == "")
            {
                MessageBox.Show("Falta preencher o que é a titulo da tarefa");
            }
            bool tarefaigual = false;
            if (comboBox2.SelectedIndex != -1 && tarefa.Text != "" && titulot.Text != "" && comboBox1.SelectedIndex != -1)
            {
                var novaTarefa = new Tarefa
                {
                    Ttarefa = titulot.Text,
                    Prazo = Convert.ToDateTime(dateTimePicker1.Text),
                    Tarefa1 = tarefa.Text,
                };
                if (comboBox2.SelectedIndex == 0)
                {
                    novaTarefa.Prioridade += " (Baixa)";
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    novaTarefa.Prioridade += " (Média)";
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    novaTarefa.Prioridade += " (Alta)";
                }
                if (comboBox1.SelectedIndex >= 0)
                {
                    Tarefa numeroParaRemover = null;
                    bool encrontrado = false;
                    foreach (var numero in _EditarT)
                    {
                        if (comboBox1.Text == numero.Ttarefa)
                        {
                            numeroParaRemover = numero;
                            encrontrado = true;
                            break;
                        }
                    }
                    if (encrontrado = true)
                    {
                        _EditarT.Remove(numeroParaRemover);
                    }
                }
                tarefaigual = false;
                foreach (var ttarefa in _EditarT)
                {
                    if (ttarefa.Ttarefa == titulot.Text)
                    {
                        tarefaigual = true;
                        break;
                    }
                }
                if (tarefaigual == false)
                {
                    _EditarT.Add(novaTarefa);
                    Close();
                }
                else
                {
                    MessageBox.Show("Estas a tentar editar o tiltulo que ja tens igual na tabela");
                }
            }
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
