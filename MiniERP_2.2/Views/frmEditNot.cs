using MiniERP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.Views
{
    public partial class frmEditNot : Form
    {
        public frmEditNot()
        {
            InitializeComponent();
        }

        private void frmEditNot_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmNotas frmNot = new frmNotas();
            frmNot.Show();
        }

        private void btnCancelCli_Click(object sender, EventArgs e)
        {
            frmNotas frmNot = new frmNotas();
            frmNot.Show();
            this.Close();
        }

        private void btnEdtNot_Click(object sender, EventArgs e)
        {
            Notas nota = new Notas();
            nota.NotId = txtIdNot.Text;
            nota.NotInfo = txtInfoNota.Text;            

            bool atualizar = nota.EditaNot();

            if (atualizar)
            {
                MessageBox.Show($"Nota '{txtIdNot.Text}' atualizada com sucesso!", "Sucesso");
                frmNotas frmForn = new frmNotas();
                frmForn.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show($"Falha ao atualizar a nota '{txtIdNot.Text}'... Tente novamente.", "Falha");
            }
        }

        private void btnCancelNot_Click(object sender, EventArgs e)
        {
            frmNotas frmForn = new frmNotas();
            frmForn.Show();
            this.Close();
        }
    }
}
