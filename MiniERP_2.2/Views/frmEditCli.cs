
using MiniERP_2_2.Classes;

namespace MiniERP.Views
{
    public partial class frmEditCli : Form
    {
        AtosUfnContext context = new AtosUfnContext();
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
            if (string.IsNullOrWhiteSpace(txtNomeCli.Text))
            {
                MessageBox.Show("O campo Nome é de preenchimento obrigatório", "Erro");
                txtNomeCli.Focus();
            }                 
            else
            {
                try
                {
                    Clientes updCli = context.Clientes.Find(int.Parse(txtCliId.Text));
                    updCli.CliNome = txtNomeCli.Text;
                    updCli.CliTel = txtTelCli.Text;

                    context.Clientes.Update(updCli);
                    context.SaveChanges();

                    MessageBox.Show($"'{txtNomeCli.Text}' atualizado com sucesso!", "Atualização OK");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar o cliente '{txtNomeCli.Text}'. \nTente novamente.", "Falha ao atualizar");
                }
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
