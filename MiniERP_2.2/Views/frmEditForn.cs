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
    public partial class frmEditForn : Form
    {
        AtosUfnContext context = new AtosUfnContext();
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
            if (string.IsNullOrWhiteSpace(txtNomeForn.Text))
            {
                MessageBox.Show("O campo Nome é de preenchimento obrigatório", "Erro");
                txtNomeForn.Focus();
            }
            else
            {
                try
                {
                    Fornecedores updForn = context.Fornecedores.Find(int.Parse(txtFornId.Text));
                    updForn.FornNome = txtNomeForn.Text;

                    context.Fornecedores.Update(updForn);
                    context.SaveChanges();

                    MessageBox.Show($"'{txtNomeForn.Text}' atualizado com sucesso!", "Atualização OK");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar o fornecedor '{txtNomeForn.Text}'. \nTente novamente.", "Falha ao atualizar");
                }
            }
        }
    }
}
