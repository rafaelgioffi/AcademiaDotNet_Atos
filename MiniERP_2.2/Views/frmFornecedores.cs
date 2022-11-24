using MiniERP_2_2.Classes;
using System.Data;

namespace MiniERP
{
    public partial class frmFornecedores : Form
    {
        AtosUfnContext context = new AtosUfnContext();
        public frmFornecedores()
        {
            InitializeComponent();
            AtualizaForn();
        }

        private void AtualizaForn()
        {
            try
            {
                List<Fornecedores> fornecedor = (from Fornecedores f in context.Fornecedores select f).ToList<Fornecedores>();

                dgvForn.DataSource = fornecedor;

                lblStatus.Text = $"{dgvForn.RowCount} fornecedores cadastrados";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao recuperar os dados do banco de dados...\nFeche a janela e tente novamente...");
            }
        }

        private void LimparCampos()
        {
            txtNomeForn.Clear();
            txtCnpjForn.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            AtualizaForn();
            txtPesquisa.Clear();
        }

        private void frmFornecedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMiniErp frmPrincipal = new frmMiniErp();
            frmPrincipal.Show();
        }

        private void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPesquisa.Text.Length > 3)
            {
                List<Fornecedores> fornecedor = context.Fornecedores.Where(forn => forn.FornNome.Contains(txtPesquisa.Text)).ToList<Fornecedores>();

                dgvForn.DataSource = fornecedor;

                lblStatus.Text = $"{dgvForn.RowCount} fornecedores encontrados";
            }
            else
            {
                AtualizaForn();
            }
        }

        private void dgvForn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnExcluiForn.Enabled = true;
            btnEditarForn.Enabled = true;
        }

        private void btnCadastrarForn_Click(object sender, EventArgs e)
        {
            grpCadForn.Visible = true;
        }

        private void btnEditarForn_Click(object sender, EventArgs e)
        {
            frmEditForn fornecedor = new frmEditForn();
            fornecedor.txtFornId.Text = dgvForn.SelectedRows[0].Cells[0].Value.ToString();
            fornecedor.txtNomeForn.Text = dgvForn.SelectedRows[0].Cells[1].Value.ToString();
            fornecedor.txtCnpjForn.Text = dgvForn.SelectedRows[0].Cells[2].Value.ToString();

            fornecedor.Show();
            this.Hide();
        }

        private void btnCadForn_Click(object sender, EventArgs e)
        {
            string cnpj = txtCnpjForn.Text;
            cnpj = cnpj.Replace(" ", "");

            if (string.IsNullOrWhiteSpace(txtNomeForn.Text))
            {
                MessageBox.Show("O campo Nome é de preenchimento obrigatório");
                txtNomeForn.Focus();
            }
            else if (cnpj.Length < 18)
            {
                MessageBox.Show("O campo CNPJ é de preenchimento obrigatório");
                txtCnpjForn.Focus();
            }
            else
            {
                try
                {
                    Fornecedores forn = new Fornecedores();
                    forn.FornNome = txtNomeForn.Text;
                    forn.FornCnpj = txtCnpjForn.Text;

                    context.Fornecedores.Add(forn);
                    context.SaveChanges();

                    MessageBox.Show($"'{txtNomeForn.Text}' cadastrado com sucesso!", "Sucesso");

                    AtualizaForn();

                    grpCadForn.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cadastrar o fornecedor '{txtNomeForn.Text}'... Verifique os dados e tente novamente", "Falha ao cadastrar");
                }
            }
        }

        private void btnExcluiForn_Click(object sender, EventArgs e)
        {
            string fornNomeEx = dgvForn.SelectedRows[0].Cells[0].Value.ToString();
            if (MessageBox.Show($"Tem certeza que deseja excluir o fornecedor '{dgvForn.SelectedRows[0].Cells[1].Value.ToString()}' do ID {fornNomeEx}?", "Exclusão de fornecedor", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Fornecedores fornId = context.Fornecedores.Find(dgvForn.SelectedRows[0].Cells[0].Value);

                context.Fornecedores.Remove(fornId);
                context.SaveChanges();

                AtualizaForn();

                MessageBox.Show($"Fornecedor '{fornNomeEx}' excluído com sucesso!", "Sucesso ao excluir");
            }
        }

        private void btnCancelForn_Click(object sender, EventArgs e)
        {
            frmMiniErp frmPrincipal = new frmMiniErp();
            frmPrincipal.Show();
            this.Close();
        }

        
    }
}

