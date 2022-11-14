using System.Data;

namespace Aula_14_11_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = txtNome.Text;
            pessoa.peso = float.Parse(txtPeso.Text);

            if(pessoa.gravar())
            {
                MessageBox.Show("Pessoa cadastrada com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar a Pessoa...");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("SELECT * FROM Pessoas");

            dgvPessoas.DataSource = dt;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("SELECT * FROM Pessoas WHERE nome LIKE '%" + txtBusca.Text + "%'");

            dgvPessoas.DataSource = dt;
        }
    }
}