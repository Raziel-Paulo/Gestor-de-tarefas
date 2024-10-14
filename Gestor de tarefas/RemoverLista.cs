using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        /// <summary>
        /// Lista de tarefas para serem exibidas na interface de remoção
        /// Armazena temporariamente as tarefas existentes para possibilitar a remoção
        /// </summary>
        List<Tarefa> _listadoremover = new List<Tarefa>();

        /// <summary>
        /// Carrega as tarefas existentes para que possam ser removidas pelo usuário
        /// </summary>
        /// <param name="_tarefa1"></param>
        public void LoadData(List<Tarefa> _tarefa1)
        {
            _listadoremover = _tarefa1;

        }

        /// <summary>
        /// Atualiza e exibe a lista de tarefas na interface, permitindo ao usuário selecionar e remover tarefas específicas
        /// </summary>
        public void atualizarlista()
        {
            foreach (var numerot in _listadoremover)
            {
                comboBox1.Items.Add(numerot.Ttarefa);
            }
            foreach (var tarefa in _listadoremover)
            {
                this.listat.Rows.Add(tarefa.Ttarefa, tarefa.Prazo, tarefa.Prioridade, tarefa.Tarefa1);
            }
        }
        public RemoverLista()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento chamado ao carregar o formulário, que as tarefas disponíveis para remoção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoverLista_Load(object sender, EventArgs e)
        {
            atualizarlista();
        }

        /// <summary>
        /// Remove a tarefa selecionada da lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removert_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                Tarefa numeroParaRemover = null;
                bool encrontrado = false;
                foreach (var numero in _listadoremover)
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
                    _listadoremover.Remove(numeroParaRemover);
                }
                this.listat.Rows.Clear();
                comboBox1.Items.Clear();
                atualizarlista();
            }
            else
            {
                MessageBox.Show("Falta selecionar o número da tarefa que quer remover");
            }
            if (_listadoremover.Count == 0)
            {
                Close();
            }

        }

        /// <summary>
        /// Remove todas as tarefas da lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removertudo_Click(object sender, EventArgs e)
        {
            _listadoremover.Clear();
            this.listat.Rows.Clear();
            comboBox1.Items.Clear();
            atualizarlista();
            if (_listadoremover.Count == 0)
            {
                Close();
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
