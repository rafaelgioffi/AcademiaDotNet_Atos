<<<<<<< HEAD
namespace Exercicios_Lista11
{
    public partial class frmEx1 : Form
=======
<<<<<<< HEAD
namespace Exercicios_Lista11
{
    public partial class frmPrincipal : Form
>>>>>>> 383c10d (Updating eleventh list of exercises)
    {
        /*
         * 1. Fazer um programa em VS e com Windows Forms.
         * A interface gr�fica precisa ter 
         * - Labels
         * - TextBox
         * - Button
         * - Panel
         * - List 
         * - Classe espec�fica
         * 
         * O programa dever permitir que o usu�rio cadastre nomes completos obrigatoriamente.
         * Ao cadastrar o nome na lista, o nome deve ser validado para que tenha no m�nimo 
         * duas palavras e que n�o esteja na lista. Ao final, caso o nome n�o esteja na lista,
         * cadastra-lo em mai�sculo e exibir a lista ordenada em um componente gr�fico equivalente.
        */

        List<string> nomes = new List<string>();
        int quant = 0;
<<<<<<< HEAD
        public frmEx1()
=======
        public frmPrincipal()
>>>>>>> 383c10d (Updating eleventh list of exercises)
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
            string nome = txtNome.Text.ToUpper();
            string[] validaNome = nome.Split(" ");

            if (validaNome.Length < 2)
            {
                MessageBox.Show("Favor preencha o nome completo no campo 'nome completo'", "ATEN��O!");
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
            
            quant = nomes.Count;
            txtLista.Clear();
            foreach(var n in nomes)
            {
                txtLista.Text += n + Environment.NewLine;
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
<<<<<<< HEAD
=======
=======
namespace Exercicios_Lista11
{
    public partial class frmEx1 : Form
    {
        /*
         * 1. Fazer um programa em VS e com Windows Forms.
         * A interface gr�fica precisa ter 
         * - Labels
         * - TextBox
         * - Button
         * - Panel
         * - List 
         * - Classe espec�fica
         * 
         * O programa dever permitir que o usu�rio cadastre nomes completos obrigatoriamente.
         * Ao cadastrar o nome na lista, o nome deve ser validado para que tenha no m�nimo 
         * duas palavras e que n�o esteja na lista. Ao final, caso o nome n�o esteja na lista,
         * cadastra-lo em mai�sculo e exibir a lista ordenada em um componente gr�fico equivalente.
        */

        List<string> nomes = new List<string>();
        int quant = 0;
        public frmEx1()
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
            string nome = txtNome.Text.ToUpper();
            string[] validaNome = nome.Split(" ");

            if (validaNome.Length < 2)
            {
                MessageBox.Show("Favor preencha o nome completo no campo 'nome completo'", "ATEN��O!");
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
            
            quant = nomes.Count;
            txtLista.Clear();
            foreach(var n in nomes)
            {
                txtLista.Text += n + Environment.NewLine;
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
>>>>>>> 21b3bfb (Updating eleventh list of exercises.)
>>>>>>> 383c10d (Updating eleventh list of exercises)
}