using Microsoft.IdentityModel.Tokens;
using MiniERP_2_2.Classes;
using System.Data;

namespace MiniERP
{
    public partial class frmClientes : Form
    {
        AtosUfnContext context = new AtosUfnContext();
        public frmClientes()
        {
            InitializeComponent();
            AtualizaClientes();
        }

        private void LimparCampos()
        {
            txtNomeCli.Clear();
            txtTelCli.Clear();
        }
        private void AtualizaClientes()
        {
            try
            {
                List<Clientes> cliente = (from Clientes c in context.Clientes select c).ToList<Clientes>();

                dgvClientes.DataSource = cliente;

                lblStatus.Text = $"{dgvClientes.RowCount} clientes cadastrados";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao recuperar os dados do banco de dados...\nFeche a janela e tente novamente...");
            }                       
        }

        private void frmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMiniErp frmPrincipal = new frmMiniErp();
            frmPrincipal.Show();
        }

        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            grpCadCli.Visible = false;
        }

        private void btnCadastrarUser_Click(object sender, EventArgs e)
        {
            grpCadCli.Visible = true;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            btnEditarCli.Enabled = true;
            btnExcluiCli.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            string cel = txtTelCli.Text;
            cel = cel.Replace(" ","");
            cel = cel.Replace("(","");
            cel = cel.Replace(")","");
            cel = cel.Replace("-","");
            
            if (string.IsNullOrWhiteSpace(txtNomeCli.Text))
            {
                MessageBox.Show("O campo Nome é de preenchimento obrigatório");
                txtNomeCli.Focus();
            }
            else if (cel.Length > 0 && cel.Length < 11)
            {
                MessageBox.Show("Favor preencha o número do telefone celular completo ou deixe vazio.");
                txtTelCli.Focus();
            }
            else
            {
                try
                {
                    Clientes cli = new Clientes();
                    cli.CliNome = txtNomeCli.Text;
                    if(cel.IsNullOrEmpty())
                    {
                        cli.CliTel = "";
                    } else
                    {
                        cli.CliTel = txtTelCli.Text;
                    }

                    context.Clientes.Add(cli);
                    context.SaveChanges();

                    MessageBox.Show($"'{txtNomeCli.Text}' cadastrado com sucesso!", "Sucesso");

                    AtualizaClientes();

                    grpCadCli.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cadastrar o cliente '{txtNomeCli.Text}'... Verifique os dados e tente novamente", "Falha ao cadastrar");
                }
            }
        }      
        private void btnExcluiCli_Click(object sender, EventArgs e)
        {
            string cliNomeEx = dgvClientes.SelectedRows[0].Cells[1].Value.ToString();
            if (MessageBox.Show($"Tem certeza que deseja excluir o cliente '{cliNomeEx}' do ID {dgvClientes.SelectedRows[0].Cells[0].Value.ToString()}?", "Exclusão de cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Clientes cliId = context.Clientes.Find(dgvClientes.SelectedRows[0].Cells[0].Value);

                context.Clientes.Remove(cliId);
                context.SaveChanges();

                AtualizaClientes();

                MessageBox.Show($"Cliente '{cliNomeEx}' excluído com sucesso!", "Sucesso ao excluir");
            }
        }

        private void btnLimpaCli_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPesquisa.Text.Length > 3)
            {

                List<Clientes> cliente = context.Clientes.Where(cli => cli.CliNome.Contains(txtPesquisa.Text)).ToList<Clientes>();

                dgvClientes.DataSource = cliente;

                lblStatus.Text = $"{dgvClientes.RowCount} Clientes encontrados";
            }
            else
            {
                AtualizaClientes();
            }
        }       

        private void btnEditarCli_Click(object sender, EventArgs e)
        {
            frmEditCli cli = new frmEditCli();
            cli.txtCliId.Text = dgvClientes.SelectedRows[0].Cells[0].Value.ToString();
            cli.txtNomeCli.Text = dgvClientes.SelectedRows[0].Cells[1].Value.ToString();            
            cli.txtCliTel.Text = dgvClientes.SelectedRows[0].Cells[2].Value.ToString();

            cli.Show();
            this.Hide();
        }
    }
}
