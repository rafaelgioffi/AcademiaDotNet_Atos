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
            frmMiniErp frmPrincipal = new frmMiniErp();
            frmForn.Show();
            this.Hide();
        }
    }
}