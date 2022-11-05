namespace Aula_04_11_2022
{
    public partial class Form1 : Form
    {
        List<string> listaNomes = new List<string>();

        string arq = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "pessoas.csv");
        public Form1()
        {
            InitializeComponent();
            Modelo.lerArquivo(listaNomes, arq);
            atualizarListaNomes();
        }

        private void atualizarListaNomes()
        {
            txtNomes.Clear();
            foreach (var l in listaNomes)
            {
                txtNomes.AppendText(l + Environment.NewLine);
            }
            lblQuantidade.Text = "Total: " + listaNomes.Count();
        }

        private void btnMaiusculo_Click(object sender, EventArgs e)
        {
            nomeMaiusculo();
        }

        private void nomeMaiusculo()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Digite algo primeiro", "Alerta");
            }
            else
            {
                txtNome.Text = txtNome.Text.ToUpper();
            }
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter)
            {
                cadastrarNome();
            }
        }

        private void txtLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNomes.Clear();
            listaNomes.Clear();
            lblQuantidade.Text = "Total: 0";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            cadastrarNome();
        }

        private void cadastrarNome()
        {
            //cria um e-mail                    
            string nomeCompleto = txtNome.Text.ToUpper();
            string[] geraEmail = nomeCompleto.Split(' ');

            if (geraEmail.Length < 2)
            {
                MessageBox.Show("Favor inserir um nome completo antes de cadastrar", "Alerta");
            }
            else
            {
                string email = $"{geraEmail[0]}.{geraEmail.Last()}@ufn.edu.br".ToUpper();

                if (listaNomes.Contains(txtNome.Text + ";" + email))
                {
                    MessageBox.Show("Nome já existente na lista", "Alerta");
                }
                else
                {
                    //guardando nomes no front..
                    listaNomes.Add(nomeCompleto + ";" + email);

                    //ordena a lista
                    listaNomes.Sort();

                    //atualiza componente gráfico a partir da lista
                    atualizarListaNomes();

                    //persistir a lista na base de dados..
                    Modelo.gravarLista(listaNomes, arq);

                    //atualizando total de nomes
                    lblQuantidade.Text = "Total: " + listaNomes.Count();
                }
                txtNome.Clear();
                txtNome.Focus();
            }
        }
    }
}


