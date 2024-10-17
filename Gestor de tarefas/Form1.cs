using static Gestor_de_tarefas.Tarefa;
using System.Xml.Serialization; // Para trabalhar com XML
using System.IO; // Para manipulação de arquivos
namespace Gestor_de_tarefas
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Lista que armazena todas as tarefas criadas pelo usuário
        /// Esta lista é usada para gerenciar e exibir as tarefas
        /// </summary>
        List<Tarefa> _tarefa1 = new List<Tarefa>();
        private const string FilePath = "tarefas.xml"; // Caminho do arquivo XML

        public Form1()
        {

            InitializeComponent();
            listat.AutoGenerateColumns = false;
            LoadTasks(); // Carregar tarefas ao iniciar o formulário
        }

        /// <summary>
        /// Esconde e desabilita elementos de filtro inicialmente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Hide();
            label2.Hide();
            label1.Hide();
            dateTimePicker1.Hide();
            dateTimePicker1.Enabled = false;
            comboBox1.Hide();
            comboBox1.Enabled = false;
            comboBox2.Hide();
            comboBox2.Enabled = false;
            RemoverFiltro.Hide();
            RemoverFiltro.Enabled = false;
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
            SaveTasks(); // Salvar tarefas após adição
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
                SaveTasks(); // Salvar tarefas após adição
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
                SaveTasks(); // Salvar tarefas após adição
            }
        }

        /// <summary>
        /// Remove os filtros aplicados e restaura a lista completa de tarefas na tabela
        /// Esconde e desabilita os elementos de filtro após remover 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoverFiltro_Click(object sender, EventArgs e)
        {
            listat.DataSource = null;
            listat.Rows.Clear();
            foreach (var tarefa in _tarefa1)
            {
                this.listat.Rows.Add(tarefa.Done, tarefa.Ttarefa, tarefa.Prazo, tarefa.Prioridade, tarefa.Tarefa1);
            }
            label4.Hide();
            label2.Hide();
            label1.Hide();
            dateTimePicker1.Hide();
            dateTimePicker1.Enabled = false;
            comboBox1.Hide();
            comboBox1.Enabled = false;
            comboBox2.Hide();
            comboBox2.Enabled = false;
            RemoverFiltro.Hide();
            RemoverFiltro.Enabled = false;
        }

        /// <summary>
        /// Filtra e exibe as tarefas de acordo com a data selecionada no DateTimePicker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            listat.DataSource = null;
            listat.Rows.Clear();
            foreach (var filtroT in _tarefa1)
            {
                if (filtroT.Prazo == Convert.ToDateTime(dateTimePicker1.Text))
                {
                    listat.Rows.Add(filtroT.Done, filtroT.Ttarefa, filtroT.Prazo, filtroT.Prioridade, filtroT.Tarefa1);
                }
            }
        }

        /// <summary>
        /// Filtra e exibe as tarefas de acordo com a prioridade selecionada no comboBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listat.DataSource = null;
            listat.Rows.Clear();
            foreach (var filtroT in _tarefa1)
            {
                if (filtroT.Prioridade == comboBox1.Text)
                {
                    listat.Rows.Add(filtroT.Done, filtroT.Ttarefa, filtroT.Prazo, filtroT.Prioridade, filtroT.Tarefa1);
                }
            }
        }

        /// <summary>
        /// Filtra e exibe as tarefas de acordo com o status de conclusão selecionado no comboBox2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listat.DataSource = null;
            listat.Rows.Clear();
            bool endentificar = false;
            if (comboBox2.Text == "Sim")
            {
                endentificar = true;
            }
            foreach (var filtroT in _tarefa1)
            {
                if (filtroT.Done == endentificar)
                {
                    listat.Rows.Add(filtroT.Done, filtroT.Ttarefa, filtroT.Prazo, filtroT.Prioridade, filtroT.Tarefa1);
                }
            }
        }

        /// <summary>
        /// Habilita os controles para aplicação de filtros, permitindo que o usuário filtre tarefas por data, prioridade e status de conclusão 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HabilidatarFiltro_Click(object sender, EventArgs e)
        {
            if (_tarefa1.Count == 0)
            {
                MessageBox.Show("Não tens tarefas para filtrar");
            }
            else
            {
                label4.Show();
                label2.Show();
                label1.Show();
                dateTimePicker1.Show();
                dateTimePicker1.Enabled = true;
                comboBox1.Show();
                comboBox1.Enabled = true;
                comboBox2.Show();
                comboBox2.Enabled = true;
                RemoverFiltro.Show();
                RemoverFiltro.Enabled = true;
            }
        }

        /// <summary>
        /// Salva a lista de tarefas em um arquivo XML.
        /// </summary>
        private void SaveTasks()
        {
            // Cria uma instância do XmlSerializer para serializar uma lista do tipo Tarefa em XML.
            XmlSerializer serializer = new XmlSerializer(typeof(List<Tarefa>));

            // Abre um stream de escrita para o arquivo especificado por FilePath
            using (TextWriter writer = new StreamWriter(FilePath))
            {
                // Usa o serializer para converter a lista de tarefas (_tarefa1) em XML e gravar no arquivo
                serializer.Serialize(writer, _tarefa1);
            }
        }

        /// <summary>
        /// Carrega a lista de tarefas a partir de um arquivo XML.
        /// </summary>
        private void LoadTasks()
        {
            // Verifica se o arquivo especificado por FilePath existe
            if (File.Exists(FilePath))
            {
                // Cria uma instância do XmlSerializer para desserializar uma lista do tipo Tarefa a partir de XML
                XmlSerializer serializer = new XmlSerializer(typeof(List<Tarefa>));

                // Abre um stream de leitura para o arquivo especificado por FilePath
                using (TextReader reader = new StreamReader(FilePath))
                {
                    // Usa o serializer para converter o XML de volta para uma lista de tarefas e armazena em _tarefa1
                    _tarefa1 = (List<Tarefa>)serializer.Deserialize(reader);

                    // Define a lista de tarefas para ser exibida no DataGridView 'listat'
                    listat.DataSource = _tarefa1;
                }
            }
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}