using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_Lista11
{
    public partial class frmEx3 : Form
    {
        /*
         * 3. Fazer um programa em VS e com windows Forms.
         * A interface gráfica precisa ter 
         * - Labels
         * - TextBox
         * - Button
         * - Panel
         * - Combo box
         * - Menu 
         * - List 
         * - Classe específica
         * 
         * O programa deve ter um Menu em que o usuário possa Inserir dados de uma criptomoeda
         * (sigla, nome e valor unidade), Consultar por criptomoeda via sigla, remover criptomoeda
         * via sigla, listar cripto moedas.
         */
        
        public frmEx3()
        {
            frmIndex frmindex = new frmIndex();
            frmindex.Close();
            InitializeComponent();
        }

        private void frmEx3_Leave(object sender, EventArgs e)
        {
            frmIndex frmindex = new frmIndex();
            frmindex.Show();
        }

        private void frmEx3_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmIndex frmindex = new frmIndex();
            frmindex.Close();
        }

        private void frmEx3_Load(object sender, EventArgs e)
        {
            frmIndex frmindex = new frmIndex();
            frmindex.Close();
        }

        private void frmEx3_Activated(object sender, EventArgs e)
        {
            frmIndex frmindex = new frmIndex();
            frmindex.Close();            
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sigla = txtSigla.Text;
            float preco = float.Parse(txtValor.Text);

            lstCriptos.Items.Add(nome, sigla, preco.ToString());
        }
    }
}
