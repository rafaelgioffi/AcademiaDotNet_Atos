namespace PrimeiroAppADO.NET
{
    public partial class frmCadEmpregados : Form
    {
        Thread thr;
        public frmCadEmpregados()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Empregados empregado = new Empregados();
            empregado.nome = txtNome.Text;
            empregado.funcao = cbFuncao.Text;
            empregado.idDepartamento = int.Parse(txtDepartamento.Text);
            empregado.salario = decimal.Parse(txtSalario.Text);

            //valida o gerente...
            if (string.IsNullOrWhiteSpace(txtGerente.Text))
            {
                empregado.idGerente = null;
            }
            else
            {
                empregado.idGerente = int.Parse(txtGerente.Text);
            }

            //valida a data...
            string dia = dtAdmissao.Text.Substring(0, 2);
            string mes = dtAdmissao.Text.Substring(3, 2);
            string ano = dtAdmissao.Text.Substring(6, 4);
            empregado.admissao = ano + "-" + mes + "-" + dia;

            //valida a comissão
            if (string.IsNullOrWhiteSpace(txtComissao.Text))
            {
                empregado.comissao = null;
            }
            else
            {
                empregado.comissao = decimal.Parse(txtComissao.Text);
            }

            bool retorno = empregado.gravarEmpregado();
            if (retorno)
            {
                lblStatus.ForeColor = Color.Blue;
                lblStatus.Text = $"{cbFuncao.Text} {txtNome.Text} cadastrado com sucesso!";
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = $"Erro ao cadastrar o(a) {cbFuncao.Text} {txtNome.Text}.";
            }
        }

        private void btnNCadastrar_Click(object sender, EventArgs e)
        {
            //frmPrincipal principal = new frmPrincipal();
            //principal.Show();
            //this.Close();

            this.Close();
            thr = new Thread(abrirPrincipal);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
        }

        private void abrirPrincipal(object obj)
        {
            Application.Run(new frmPrincipal());
        }

        private void frmCadEmpregados_FormClosed(object sender, FormClosedEventArgs e)
        {

            thr = new Thread(abrirPrincipal);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
        }
    }
}
