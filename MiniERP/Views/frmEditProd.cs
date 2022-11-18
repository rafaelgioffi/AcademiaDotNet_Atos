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
        
        public frmEditProd()
        {
            InitializeComponent();
        }

        private void btnEdtProd_Click(object sender, EventArgs e)
        {
            Produtos produto = new Produtos();
            produto.ProdId = int.Parse(txtProdId.Text);
            produto.FornId = int.Parse(txtIdForn.Value.ToString());
            produto.ProdNome = txtNomeProd.Text;
            produto.ProdDesc = txtDescProd.Text;
            produto.ProdValUnit = float.Parse(txtValProd.Text);
            produto.ProdQuant = int.Parse(txtQuantProd.Value.ToString());

            bool atualizar = produto.EditaProd();

            if (atualizar)
            {
                MessageBox.Show($"'{txtNomeProd.Text}' atualizado com sucesso!","Sucesso");
                frmProdutos frmProd = new frmProdutos();
                frmProd.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show($"Falha ao atualizar o produto '{txtNomeProd.Text}'... Tente novamente.","Falha");
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
