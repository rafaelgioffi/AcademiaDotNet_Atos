namespace PrimeiroAppADO.NET
{
    public partial class frmPrincipal : Form
    {
        Thread thr;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmDepartamentos frmDep = new frmDepartamentos();
            //frmPrincipal frmPrinc = new frmPrincipal();
            //frmDep.Show();
            //this.Hide();

            //frmPrinc.MdiParent = frmPrincipal;
            //frmPrinc.Hide();
            //frmDep.Show();

            this.Close();
            thr = new Thread(abrirDepartamento);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //frmCadEmpregados frmEmp = new frmCadEmpregados();
            //frmPrincipal frmPrinc = new frmPrincipal();
            //frmPrincipal.ActiveForm.Hide();
            //frmEmp.Show();

            this.Close();
            thr = new Thread(abrirEmpregados);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
        }
        private void abrirEmpregados(object obj)
        {
            Application.Run(new frmCadEmpregados());
        }
        private void abrirDepartamento(object obj)
        {
            Application.Run(new frmDepartamentos());
        }
    }
}
