using MiniERP;
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
            lblStatusBar.Visible = true;
            
            btnProd.Enabled = false;
            btnForn.Enabled = false;
            btnCli.Enabled = false;
            btnNot.Enabled = false;
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