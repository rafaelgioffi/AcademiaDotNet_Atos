namespace PrimeiroAppADO.NET
{
    public partial class frmDepartamentos : Form
    {
        Thread thr;
        public frmDepartamentos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Departamento d = new Departamento(txtNomeDepart.Text, txtLocal.Text, txtOrcamento.Text);
            if (d.gravarDepartamento())
            {
                lblStatus.ForeColor = Color.Blue;
                lblStatus.Text = $"{txtNomeDepart.Text} cadastrado com sucesso!";
                //MessageBox.Show($"{txtNomeDepart.Text} cadastrado com sucesso!", "Sucesso");
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = $"Falha ao salvar o departamento {txtNomeDepart.Text}...";
                //MessageBox.Show($"Falha ao salvar o departamento {txtNomeDepart.Text}\nTente novamente", "Erro");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            thr = new Thread(abrirPrincipal);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
        }
        private void abrirPrincipal(object obj)
        {
            Application.Run(new frmPrincipal());
        }

        private void frmDepartamentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            thr = new Thread(abrirPrincipal);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
        }
    }
}