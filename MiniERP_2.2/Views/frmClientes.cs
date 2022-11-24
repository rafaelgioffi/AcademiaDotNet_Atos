using System.Data;

namespace MiniERP.Views
{
    public partial class frmClientes : Form
    {
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
            

                lblStatus.Text = $"{dgvClientes.RowCount} clientes cadastrados";
            
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
            if (string.IsNullOrWhiteSpace(txtNomeCli.Text))
            {
                MessageBox.Show("O campo Nome é de preenchimento obrigatório");
                txtNomeCli.Focus();
            }
            else
            {
                

                
            }
        }

        private void btnEditarCli_Click(object sender, EventArgs e)
        {
            frmEditCli cliente = new frmEditCli();
            cliente.txtCliId.Text = dgvClientes.SelectedRows[0].Cells[0].Value.ToString();
            cliente.txtNomeCli.Text = dgvClientes.SelectedRows[0].Cells[1].Value.ToString();
            cliente.txtTelCli.Text = dgvClientes.SelectedRows[0].Cells[2].Value.ToString();

            cliente.Show();
            this.Hide();
        }

        private void btnExcluiCli_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Tem certeza que deseja excluir o cliente '{dgvClientes.SelectedRows[0].Cells[1].Value.ToString()}' do ID {dgvClientes.SelectedRows[0].Cells[0].Value.ToString()}?", "Exclusão de cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {             
                

                

                
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
                
                DataTable dt = new DataTable();
                //dt = bd.Consulta($"SELECT CliId 'ID', CliNome 'Nome', CliTel 'Telefone' FROM Clientes WHERE CliNome LIKE '%{txtPesquisa.Text}%'");

                dgvClientes.DataSource = dt;
            }
            else
            {
                AtualizaClientes();
            }
        }

    }
}
