using static Gestor_de_tarefas.Tarefa;

namespace Gestor_de_tarefas
{
    public partial class Form1 : Form
    {

        List<Tarefa> _tarefa1 = new List<Tarefa>();
        int numtarefa1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Abrir_Click(object sender, EventArgs e)
        {
            var AdicionarT = new AdicionarT();
            
            AdicionarT.LoadData(_tarefa1);
            AdicionarT.ShowDialog(this);
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            this.listat.Rows.Clear();

            foreach (var tarefa in _tarefa1)
            {
                this.listat.Rows.Add(tarefa.Ttarefa, tarefa.Prazo, tarefa.Prioridade, tarefa.Tarefa1);
            }
        }

        private void removert_Click(object sender, EventArgs e)
        {
            if(_tarefa1.Count == 0)
            {
                MessageBox.Show("Não tens tarefas para remover");
            }
            else
            {
                var RemoverLista = new RemoverLista();
                RemoverLista.LoadData(_tarefa1);
                RemoverLista.ShowDialog(this);
            }
        }
    }
}