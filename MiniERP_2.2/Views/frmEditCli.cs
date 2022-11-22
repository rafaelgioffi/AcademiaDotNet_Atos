using MiniERP.Classes;

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
            Clientes cliente = new Clientes();
            cliente.CliId = int.Parse(txtCliId.Text);
            cliente.CliNome = txtNomeCli.Text;
            cliente.CliTel = txtTelCli.Text;

            bool atualizar = cliente.EditaCli();

            if (atualizar)
            {
                MessageBox.Show($"'{txtNomeCli.Text}' atualizado com sucesso!", "Sucesso");
                frmClientes frmCli = new frmClientes();
                frmCli.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show($"Falha ao atualizar o cliente '{txtNomeCli.Text}'... Tente novamente.", "Falha");
            }
        }

        private void btnEdtCancelCli_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.Show();
            this.Close();
        }
    }
}
