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
    public partial class frmEditForn : Form
    {
        public frmEditForn()
        {
            InitializeComponent();
        }

        private void frmEditForn_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmFornecedores frmForn = new frmFornecedores();
            frmForn.Show();
        }

        private void btnEdtCancelForn_Click(object sender, EventArgs e)
        {
            frmFornecedores frmForn = new frmFornecedores();
            frmForn.Show();
            this.Close();
        }

        private void btnEdtForn_Click(object sender, EventArgs e)
        {
            Fornecedores fornecedor = new Fornecedores();
            fornecedor.FornId = int.Parse(txtFornId.Text);            
            fornecedor.FornNome = txtNomeForn.Text;            
            fornecedor.FornCnpj = txtCnpjForn.Text;            

            bool atualizar = fornecedor.EditaForn();

            if (atualizar)
            {
                MessageBox.Show($"'{txtNomeForn.Text}' atualizado com sucesso!", "Sucesso");
                frmFornecedores frmForn = new frmFornecedores();
                frmForn.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show($"Falha ao atualizar o fornecedor '{txtNomeForn.Text}'... Tente novamente.", "Falha");
            }
        }
    }
}
