using MiniERP_2_2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP
{
    public partial class frmEditProd : Form
    {
        AtosUfnContext context = new AtosUfnContext();
        public frmEditProd()
        {
            InitializeComponent();
        }

        private void btnEdtProd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdForn.Value.ToString()))
            {
                MessageBox.Show("O campo Fornecedor é de preenchimento obrigatório", "Erro");
                txtIdForn.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtNomeProd.Text))
            {
                MessageBox.Show("O campo Nome é de preenchimento obrigatório", "Erro");
                txtNomeProd.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtValProd.Text))
            {
                MessageBox.Show("O campo Valor do produto é de preenchimento obrigatório","Erro");
                txtValProd.Focus();
            }
            else
            {
                try
                {
                    decimal valor;
                    int quant;
                    decimal.TryParse(txtValProd.Text, out valor);
                    int.TryParse(txtQuantProd.Text, out quant);

                    if (valor <= 0)
                    {
                        MessageBox.Show("Favor inserir um valor válido");
                        txtValProd.Focus();
                    }
                    else if (quant < 0)
                    {
                        MessageBox.Show("Não é possível definir valores negativos na quantidade","Erro");
                        txtQuantProd.Focus();
                    }
                    else
                    {
                        Produto updProd = context.Produtos.Find(int.Parse(txtProdId.Text));
                        updProd.ProdDesc = txtDescProd.Text;
                        updProd.ProdValUnit = decimal.Parse(txtValProd.Text);
                        updProd.ProdQuant = int.Parse(txtQuantProd.Value.ToString());

                        context.Produtos.Update(updProd);
                        context.SaveChanges();

                        MessageBox.Show($"'{txtNomeProd.Text}' atualizado com sucesso!", "Atualização OK");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                        MessageBox.Show($"Erro ao atualizar o produto '{txtNomeProd.Text}'. \nTente novamente.","Falha ao atualizar");
                }
            }
        }

        private void frmEditProd_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmProdutos frmProd = new frmProdutos();
            frmProd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProdutos frmProd = new frmProdutos();
            frmProd.Show();
            this.Close();
        }
    }
}
