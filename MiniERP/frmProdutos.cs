using System.Data;

namespace MiniERP
{
    public partial class frmProdutos : Form
    {
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
                
                if(valor <= 0)
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

                    if (produto.cadastrarProduto())
                    {
                        MessageBox.Show("Produto cadastrado com sucesso!");
                        AtualizaProd();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao cadastrar o produto. Tente novamente...");
                        AtualizaProd();
                    }
                }
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            frmMiniErp frmPrincipal = new frmMiniErp();
            frmPrincipal.Show();
            this.Close();
        }
    }
}
