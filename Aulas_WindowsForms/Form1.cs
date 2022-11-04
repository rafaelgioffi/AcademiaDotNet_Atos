namespace Exercicios_Lista11
{
    public partial class frmPrincipal : Form
    {
        List<string> nomes = new List<string>();
        int quant = 0;
        public frmPrincipal()
        {
            InitializeComponent();
            lblQuant.Text = $"{quant} nomes cadastrados";
        }

        //m�todo que trata evento de um componente
        private void btnAddList_Click(object sender, EventArgs e)
        {
            inserirTextBox_lista();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                inserirTextBox_lista();
            }
        }

        private void inserirTextBox_lista()
        {
            string nome = txtNome.Text.ToUpper() + Environment.NewLine;
            

            if (txtNome.Text == "")
            {
                MessageBox.Show("Para adicionar nome, � preciso digitar algo!", "ATEN��O!");
            }
            else
            {
                if (nomes.Contains(nome))
                {
                    MessageBox.Show($"'{nome}' j� existe na lista!");
                }
                else
                {
                    nomes.Add(nome);
                    nomes.Sort();
                }
            }
            //txtLista.Text += txtNome.Text.ToUpper() + Environment.NewLine;
            quant = nomes.Count;
            txtLista.Clear();
            foreach(var n in nomes)
            {
                txtLista.Text += n;
            }
            txtNome.Clear();
            lblQuant.Text = $"{quant} nomes cadastrados";
            txtNome.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            lblHora.Text = dt.ToString();
        }
    }
}