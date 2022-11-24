using MiniERP.Views;
using MiniERP_2_2.Classes;

namespace MiniERP
{
    public partial class frmMiniErp : Form
    {
        public frmMiniErp()
        {
            InitializeComponent();
        }

        public void CarregaTela(string tela)
        {
            lblStatusBar.Text = $"Carregando {tela}, aguarde...";
            
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CarregaTela("os Produtos");

            frmProdutos frmProd = new frmProdutos();
            frmMiniErp frmPrincipal = new frmMiniErp();
            frmProd.Show();
            this.Hide();
        }

        private void frmMiniErp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarregaTela("os Fornecedores");
            frmFornecedores frmForn = new frmFornecedores();            
            frmForn.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarregaTela("os Clientes");
            frmClientes frmUser = new frmClientes();
            frmUser.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarregaTela("as Notas Fiscais");
            frmNotas frmNot = new frmNotas();
            frmNot.Show();
            this.Hide();
        }
    }
}