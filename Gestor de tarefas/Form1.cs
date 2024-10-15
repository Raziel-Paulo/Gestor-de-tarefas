using static Gestor_de_tarefas.Tarefa;

namespace Gestor_de_tarefas
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Lista que armazena todas as tarefas criadas pelo usuário
        /// Esta lista é usada para gerenciar e exibir as tarefas
        /// </summary>
        List<Tarefa> _tarefa1 = new List<Tarefa>();
        public Form1()
        {

            InitializeComponent();
            listat.AutoGenerateColumns = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Abre a janela para adicionar uma nova tarefa
        /// Esta ação permite que o usuário adicione um nova tarefa, especificando detalhes como título, prazo e prioridade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Abrir_Click(object sender, EventArgs e)
        {
            var AdicionarT = new AdicionarT();
            AdicionarT.LoadData(_tarefa1);
            AdicionarT.ShowDialog(this);
            listat.DataSource = null;
            listat.DataSource = _tarefa1;
            listat.Refresh();
        }

        /// <summary>
        /// Atualiza a lista de tarefas visível na interface do usuário
        /// Percorre todas as tarefas na lista e exibe suas propriedades na tabela 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void atualizar_Click(object sender, EventArgs e)
        {
            this.listat.Rows.Clear();

            foreach (var tarefa in _tarefa1)
            {
                this.listat.Rows.Add(tarefa.Done, tarefa.Ttarefa, tarefa.Prazo, tarefa.Prioridade, tarefa.Tarefa1);
            }
        }

        /// <summary>
        /// Abre a janela para remover uma tarefa existente
        /// Se não houver tarefas na lista, exibe uma mensagem informando que não há tarefas para remover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removert_Click(object sender, EventArgs e)
        {
            if (_tarefa1.Count == 0)
            {
                MessageBox.Show("Não tens tarefas para remover");
            }
            else
            {
                var RemoverLista = new RemoverLista();
                RemoverLista.LoadData(_tarefa1);
                RemoverLista.ShowDialog(this);
                listat.DataSource = null;
                listat.DataSource = _tarefa1;
                listat.Refresh();
            }
        }

        /// <summary>
        /// Abre a janela para editar uma tarefa existente
        /// Se não houver tarefas na lista, exibe uma mensagem informando que não há tarefas para editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditarT_Click(object sender, EventArgs e)
        {
            if (_tarefa1.Count == 0)
            {
                MessageBox.Show("Não tens tarefas para Editar");
            }
            else
            {
                var EditarT = new EditarT();
                EditarT.LoadData(_tarefa1);
                EditarT.ShowDialog(this);
                listat.DataSource = null;
                listat.DataSource = _tarefa1;
                listat.Refresh();
            }
        }
    }
}