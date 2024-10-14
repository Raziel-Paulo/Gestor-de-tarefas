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
        /// <summary>
        /// Lista de tarefas a serem editadas
        /// Armazena temporariamente as tarefas existentes para permitir a edição
        /// </summary>
        List<Tarefa> _EditarT = new List<Tarefa>();

        /// <summary>
        /// Carrega as tarefas existentes para a interface de edição
        /// Esta lista é utilizada para exibir as tarefas disponíveis ao usuário para edição
        /// </summary>
        /// <param name="_tarefa1"></param>
        public void LoadData(List<Tarefa> _tarefa1)
        {
            _EditarT = _tarefa1;
        }

        public EditarT()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento chamado ao carregar o formulário, que preenche o comboBox e a tabela com as tarefas disponíveis para edição
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Evento chamado quando o índice selecionado do comboBox1 muda
        /// Carrega os detalhes da tarefa selecionada nos campos de texto para edição
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var tarefas in _EditarT)
            {

                // Preenche os campos de edição com os detalhes da tarefa selecionada
                if (comboBox1.Text == tarefas.Ttarefa)
                {
                    titulot.Text = tarefas.Ttarefa;
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

        /// <summary>
        /// Evento chamado ao clicar no botão de editar.
        /// Realiza a validação dos campos e atualiza a tarefa selecionada com as novas informações.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                // Remove a tarefa antiga da lista
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

                // Verifica se o título da nova tarefa já existe na lista
                foreach (var ttarefa in _EditarT)
                {
                    if (ttarefa.Ttarefa == titulot.Text)
                    {
                        tarefaigual = true;
                        break;
                    }
                }

                // Se o título da tarefa não existir, adiciona a nova tarefa e fecha o formulário
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
