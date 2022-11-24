
namespace MiniERP.Views
{
    public partial class frmEditCli : Form
    {
        public frmEditCli()
        {
            InitializeComponent();
        }

        private void frmEditCli_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.Show();
        }

        private void btnEdtCli_Click(object sender, EventArgs e)
        {
            

            
                MessageBox.Show($"Falha ao atualizar o cliente '{txtNomeCli.Text}'... Tente novamente.", "Falha");
            
        }

        private void btnEdtCancelCli_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.Show();
            this.Close();
        }
    }
}
