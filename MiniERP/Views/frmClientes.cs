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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtNomeCli.Clear();
            txtTelUser.Clear();
        }

        private void AtualizaUser()
        {
            try
            {
                Banco bd = new Banco();
                DataTable dt = new DataTable();
                dt = bd.Consulta("SELECT CliId 'ID', CliNome 'Nome', ProdDesc 'Descrição', ProdValUnit 'Valor', ProdQuant 'Quantidade' FROM Produtos");

                dgvProd.DataSource = dt;

                lblStatus.Text = $"{dgvProd.RowCount} produtos cadastrados";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMiniErp frmPrincipal = new frmMiniErp();
            frmPrincipal.Show();
        }

        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            frmMiniErp frmPrincipal = new frmMiniErp();
            frmPrincipal.Show();
            this.Close();
        }

        private void btnCadastrarUser_Click(object sender, EventArgs e)
        {
            grpCadUsr.Visible = true;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarCli.Enabled = true;
            btnExcluiUser.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
        }
    }
}
