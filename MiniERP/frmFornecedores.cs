namespace MiniERP
{
    public partial class frmFornecedores : Form
    {
        public frmFornecedores()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void dgvForn_SelectionChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dgvForn.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void frmFornecedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMiniErp frmPrincipal = new frmMiniErp();
            frmPrincipal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMiniErp frmPrincipal = new frmMiniErp();
            frmPrincipal.Show();
        }
    }
}
