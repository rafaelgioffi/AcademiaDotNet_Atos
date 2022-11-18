using System.Data;

namespace MiniERP
{
    public partial class frmProdutos : Form
    {
        public int selecionado;
        public frmProdutos()
        {
            InitializeComponent();
            AtualizaProd();
        }

        private void CancelarRegProd()
        {
            txtIdForn.Value = 1;
            txtQuantProd.Value = 1;
            txtNomeProd.Clear();
            txtDescProd.Clear();
            txtValProd.Clear();
        }

        private void btnCancelProd_Click(object sender, EventArgs e)
        {
            CancelarRegProd();
        }

        private void frmProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMiniErp frmPrincipal = new frmMiniErp();
            frmPrincipal.Show();
        }

        private void AtualizaProd()
        {
            try
            {
                Banco bd = new Banco();
                DataTable dt = new DataTable();
                dt = bd.Consulta("SELECT ProdId 'ID', FornId 'Fornecedor', ProdNome 'Nome', ProdDesc 'Descrição', ProdValUnit 'Valor', ProdQuant 'Quantidade' FROM Produtos");

                dgvProd.DataSource = dt;

                lblStatus.Text = $"{dgvProd.RowCount} produtos cadastrados";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdForn.Value.ToString()))
            {
                MessageBox.Show("O campo Fornecedor é de preenchimento obrigatório");
                txtIdForn.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtNomeProd.Text))
            {
                MessageBox.Show("O campo Nome é de preenchimento obrigatório");
                txtNomeProd.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtValProd.Text))
            {
                MessageBox.Show("O campo Valor do produto é de preenchimento obrigatório");
                txtValProd.Focus();
            }
            else
            {
                float valor;
                float.TryParse(txtValProd.Text, out valor);

                if (valor <= 0)
                {
                    MessageBox.Show("Favor inserir um valor válido");
                    txtValProd.Focus();
                }
                else
                {
                    Produtos produto = new Produtos();
                    produto.FornId = int.Parse(txtIdForn.Text);
                    produto.ProdNome = txtNomeProd.Text;
                    produto.ProdDesc = txtDescProd.Text;
                    produto.ProdValUnit = float.Parse(txtValProd.Text);
                    produto.ProdQuant = int.Parse(txtQuantProd.Text);

                    if (produto.CadastraProd())
                    {
                        MessageBox.Show("Produto cadastrado com sucesso!");
                        AtualizaProd();
                        CancelarRegProd();
                        grpCadProd.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Falha ao cadastrar o produto. Tente novamente...");
                        AtualizaProd();
                    }
                }
            }
        }

        private void dgvProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selecionado = int.Parse(dgvProd.SelectedRows[0].Cells[0].Value.ToString());
            btnExcluiProd.Enabled = true;
            btnEditarProd.Enabled = true;
        }

        private void btnExcluiProd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Tem certeza que deseja excluir o produto '{dgvProd.SelectedRows[0].Cells[2].Value.ToString()}' do ID {dgvProd.SelectedRows[0].Cells[0].Value.ToString()}?", "Exclusão de produto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Produtos produto = new Produtos();
                produto.ProdId = selecionado;
                produto.ProdNome = dgvProd.SelectedRows[0].Cells[2].Value.ToString();

                produto.ConsultaProd(produto.ProdId);

                if (produto == null)
                {
                    MessageBox.Show($"Erro ao excluir o produto '{produto.ProdNome}'.\nTente novamente");
                    return;
                }
                bool retorno = produto.ExcluiProd();

                if (retorno)
                {
                    AtualizaProd();
                    MessageBox.Show($"'{produto.ProdNome}' excluído com sucesso!", "Produto excluído");
                }
                else
                {
                    MessageBox.Show($"Erro ao excluir o produto '{produto.ProdNome}'.\nTente novamente");
                    AtualizaProd();
                }
            }
        }

        private void btnEditarProd_Click(object sender, EventArgs e)
        {
            frmEditProd produto = new frmEditProd();
            produto.txtProdId.Text = dgvProd.SelectedRows[0].Cells[0].Value.ToString();
            produto.txtNomeProd.Text = dgvProd.SelectedRows[0].Cells[2].Value.ToString();
            produto.txtIdForn.Value = decimal.Parse(dgvProd.SelectedRows[0].Cells[1].Value.ToString());
            produto.txtDescProd.Text = dgvProd.SelectedRows[0].Cells[3].Value.ToString();
            produto.txtValProd.Text = dgvProd.SelectedRows[0].Cells[4].Value.ToString();
            produto.txtQuantProd.Text = dgvProd.SelectedRows[0].Cells[5].Value.ToString();

            produto.Show();
            this.Hide();
        }

        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {
            grpCadProd.Visible = true;
        }

        private void btnCancelCadProd_Click(object sender, EventArgs e)
        {
            grpCadProd.Visible = false;
        }

        private void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPesquisa.Text.Length > 3)
            {
                Banco bd = new Banco();
                DataTable dt = new DataTable();
                dt = bd.Consulta("SELECT ProdId 'ID', FornId 'Fornecedor', ProdNome 'Nome', ProdDesc 'Descrição', ProdValUnit 'Valor', ProdQuant 'Quantidade' FROM Produtos WHERE ProdNome LIKE '%" + txtPesquisa.Text + "%'");

                dgvProd.DataSource = dt;
            }
            else
            {
                AtualizaProd();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
            AtualizaProd();
        }
    }
}
