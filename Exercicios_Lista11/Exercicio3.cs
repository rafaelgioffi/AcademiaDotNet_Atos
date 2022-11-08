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

        int indiceSelecionado;
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

        private void cadastraCripto()
        {
            if (txtNome.Text.Length < 3)
            {
                MessageBox.Show("Favor informar o nome da criptomoeda");
                txtNome.Focus();
            }
            else if (txtSigla.Text.Length < 3)
            {
                MessageBox.Show("Favor informar a sigla com 3 caracteres");
                txtSigla.Focus();
            }
            else if (txtValor.Text.Length < 1)
            {
                MessageBox.Show("É obrigatório informar o valor!");
                txtValor.Focus();
            }
            else
            {
                string nome = txtNome.Text.ToUpper();
                string sigla = txtSigla.Text.ToUpper();
                float preco = float.Parse(txtValor.Text);

                ListViewItem lvi = new ListViewItem(nome);
                lvi.SubItems.Add(sigla);
                lvi.SubItems.Add(preco.ToString("C"));

                lstCriptos.Items.Add(lvi);
                lblQuant.Text = $"Criptomoedas cadastradas: {lstCriptos.Items.Count.ToString()}";
                lblInfo.Text = $"'{sigla}' cadastrada com sucesso!";
                txtNome.Clear();
                txtSigla.Clear();
                txtValor.Clear();
            }
        }

        private void removeCripto()
        {
            DialogResult perg = MessageBox.Show($"Tem certeza que deseja remover a criptomoeda '{lstCriptos.Items[indiceSelecionado].SubItems[1].Text}'?", "Remover criptomoeda", MessageBoxButtons.YesNo);
            if (perg == DialogResult.Yes)
            {
                lstCriptos.Items.RemoveAt(indiceSelecionado);
            }
        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            cadastraCripto();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            removeCripto();
        }

        private void lstCriptos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;

            ListView.SelectedIndexCollection ids = lv.SelectedIndices;
            foreach (int i in ids)
            {
                indiceSelecionado = i;
            }
        }

        private void menuRemove_Click(object sender, EventArgs e)
        {
            removeCripto();
        }

        private void menuCadastro_Click(object sender, EventArgs e)
        {
            cadastraCripto();
        }
    }
}
