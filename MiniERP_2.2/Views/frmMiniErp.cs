using MiniERP.Views;

namespace MiniERP
{
    public partial class frmMiniErp : Form
    {
        public frmMiniErp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            frmFornecedores frmForn = new frmFornecedores();            
            frmForn.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmClientes frmUser = new frmClientes();
            frmUser.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmNotas frmNot = new frmNotas();
            frmNot.Show();
            this.Hide();
        }
    }
}