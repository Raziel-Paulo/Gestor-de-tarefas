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
        /// <summary>
        /// Lista local para armazenar as tarefas temporariamente enquanto são adicionadas
        /// Permite manipular as tarefas e confirmar a adição antes de atualizar a lista principal de tarefas
        /// </summary>
        List<Tarefa> _lista = new List<Tarefa>();

        /// <summary>
        /// Carrega a lista existente de tarefas para esta instância, permitindo que novas tarefas sejam adicionadas
        /// </summary>
        /// <param name="_tarefa1"></param>
        public void LoadData(List<Tarefa> _tarefa1)
        {
            _lista = _tarefa1;
        }
        public AdicionarT()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adiciona uma nova tarefa à lista após validar os campos de entrada
        /// Verifica se todas as informações necessárias foram preenchidas e se não há duplicação de título da tarefa antes de adicionar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddT_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
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
            foreach (var ttarefa in _lista)
            {
                if (ttarefa.Ttarefa == titulot.Text)
                {
                    tarefaigual = true;
                    break;
                }
            }
            if (tarefaigual == true)
            {
                MessageBox.Show("Tens um titulo ja com esse nome");
            }
            if (comboBox1.SelectedIndex != -1 && tarefa.Text != "" && titulot.Text != "" && tarefaigual == false)
            {

                // Cria uma nova instância de tarefa
                var novaTarefa = new Tarefa
                {
                    Ttarefa = titulot.Text,
                    Prazo = Convert.ToDateTime(prazo.Text),
                    Tarefa1 = tarefa.Text,
                    Done = false,
                };

                // Adiciona o grau de prioridade baseado na seleção
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

        private void AdicionarT_Load(object sender, EventArgs e)
        {

            comboBox1.SelectedIndex = 0;
        }

        private void titulot_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
