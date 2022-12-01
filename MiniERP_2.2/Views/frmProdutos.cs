using MiniERP_2_2.Classes;
using System.Data;

namespace MiniERP
{
    public partial class frmProdutos : Form
    {
        AtosUfnContext context = new AtosUfnContext();

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
                DataTable dt = new DataTable();
                List<Produtos> produto = (from Produtos p in context.Produtos select p).ToList<Produtos>();

                dgvProd.DataSource = produto;

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
                decimal valor;
                decimal quant;
                decimal.TryParse(txtValProd.Text, out valor);
                decimal.TryParse(txtQuantProd.Text, out quant);

                if (valor <= 0)
                {
                    MessageBox.Show("Favor inserir um valor válido");
                    txtValProd.Focus();
                }
                else if (quant < 0)
                {
                    MessageBox.Show("Não é possível definir valores negativos na quantidade");
                    txtQuantProd.Focus();
                }
                else
                {
                    try
                    {
                        Produtos prod = new Produtos();
                        prod.FornId = int.Parse(txtIdForn.Value.ToString());
                        prod.ProdNome = txtNomeProd.Text;
                        prod.ProdDesc = txtDescProd.Text;
                        prod.ProdValUnit = valor;
                        prod.ProdQuant = int.Parse(txtQuantProd.Text);

                        context.Produtos.Add(prod);
                        context.SaveChanges();

                        MessageBox.Show($"Produto '{txtNomeProd.Text}' cadastrado com sucesso!");

                        AtualizaProd();

                        grpCadProd.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao cadastrar o produto '{txtNomeProd.Text}'... Verifique os dados e tente novamente", "Falha ao cadastrar");
                    }
                }
            }
        }

        private void dgvProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnExcluiProd.Enabled = true;
            btnEditarProd.Enabled = true;
        }

        private void btnExcluiProd_Click(object sender, EventArgs e)
        {
            string CliNomeEx = dgvProd.SelectedRows[0].Cells[2].Value.ToString();
            if (MessageBox.Show($"Tem certeza que deseja excluir o produto '{CliNomeEx}' do ID {dgvProd.SelectedRows[0].Cells[0].Value.ToString()}?", "Exclusão de produto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Produtos prodId = context.Produtos.Find(
                    dgvProd.SelectedRows[0].Cells[0].Value);
                context.Produtos.Remove(prodId);
                context.SaveChanges();

                AtualizaProd();

                MessageBox.Show($"Produto '{CliNomeEx}' excluído com sucesso!");
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
                DataTable dt = new DataTable();
                List<Produtos> produto = context.Produtos.Where(prod => prod.ProdNome.Contains(txtPesquisa.Text)).ToList<Produtos>();

                dgvProd.DataSource = produto;

                lblStatus.Text = $"{dgvProd.RowCount} produtos encontrados";
            }

            else
            {
                AtualizaProd();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
            AtualizaProd();
        }
    }
}
