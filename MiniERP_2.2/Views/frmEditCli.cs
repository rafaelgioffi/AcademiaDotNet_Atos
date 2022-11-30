using Microsoft.IdentityModel.Tokens;
using MiniERP_2_2.Classes;

namespace MiniERP
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
            string cel = txtCliTel.Text;
            cel = cel.Replace(" ", "");
            cel = cel.Replace("(", "");
            cel = cel.Replace(")", "");
            cel = cel.Replace("-", "");
            
            if (string.IsNullOrWhiteSpace(txtNomeCli.Text))
            {
                MessageBox.Show("O campo Nome é de preenchimento obrigatório");
                txtNomeCli.Focus();
            }
            else if (cel.Length > 0 && cel.Length < 11)
            {
                MessageBox.Show("Favor preencha o número do telefone celular completo ou deixe vazio.");
                txtCliTel.Focus();
            }
            else
            {
                try
                {
                    Clientes updCli = context.Clientes.Find(int.Parse(txtCliId.Text));
                    updCli.CliNome = txtNomeCli.Text;
                    if (cel.Length == 0)
                    {
                        updCli.CliTel = "";
                    }
                    else
                    {
                        updCli.CliTel = txtCliTel.Text;
                    }                    

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
