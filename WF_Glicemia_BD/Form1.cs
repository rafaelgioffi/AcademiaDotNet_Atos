using System.Configuration;
using System.Data.SqlClient;

namespace WF_Glicemia_BD
{
    public partial class frmPacientes : Form
    {
        int itemSel;
        public frmPacientes()
        {
            InitializeComponent();
            CarregarListView();
        }

        private void LimparCampos()
        {
            txtIdPac.Clear();
            txtNomePac.Clear();
            txtMailPac.Clear();
        }

        private string conexaoString = ConfigurationManager.ConnectionStrings["GlicemiaDBString"].ConnectionString;
        private void CarregarListView()
        {
            try
            {
                lblStatus.Text = "Carregando os dados, aguarde...";
                SqlConnection conexao = new SqlConnection(conexaoString);
                conexao.Open();

                string sqlQuery = "SELECT * FROM Paciente";
                SqlCommand comand = new SqlCommand(sqlQuery, conexao);
                SqlDataReader sdt = comand.ExecuteReader();

                lstPac.Items.Clear();
                int i = 0;
                while (sdt.Read())
                {
                    lstPac.Items.Add(sdt["idPaciente"].ToString());
                    lstPac.Items[i].SubItems.Add(sdt["nome"].ToString());
                    lstPac.Items[i].SubItems.Add(sdt["email"].ToString());
                    i++;
                }
                conexao.Close();
                lblStatus.Text = "";
                lblQuantPacs.Text = $"{lstPac.Items.Count.ToString()} pacientes cadastrados";
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao conectar a base de dados...", "Alerta");
            }
        }

        private void btnCadPac_Click(object sender, EventArgs e)
        {
            panCadPac.Enabled = true;
            panCadPac.Visible = true;

            SqlConnection conn = new SqlConnection(conexaoString);
            conn.Open();

            //para solucionar o "max"..
            //execute scalar
            string sqlSelMax = "SELECT Max(idPaciente) FROM Paciente";
            SqlCommand comand = new SqlCommand(sqlSelMax, conn);
                        
            int max = comand.ExecuteNonQuery();
            MessageBox.Show(max.ToString());

            txtIdPac.Text = (max).ToString();
            conn.Close();
        }

        private void btnConectPac_Click(object sender, EventArgs e)
        {
            CarregarListView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panCadPac.Enabled = false;
            panCadPac.Visible = false;
            this.LimparCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomePac.Text))
            {
                MessageBox.Show("O campo nome é obrigatório", "Erro ao cadastrar");
                txtNomePac.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtMailPac.Text))
            {
                MessageBox.Show("O campo e-mail é obrigatório", "Erro ao cadastrar");
                txtMailPac.Focus();
            }
            else
            {
                SqlConnection conn = new SqlConnection(conexaoString);
                conn.Open();

                try
                {
                    int idPaciente = int.Parse(txtIdPac.Text);
                    string nome = txtNomePac.Text;
                    string email = txtMailPac.Text;

                    //gerar query para update...
                    string sqlUpdQuery = "UPDATE Paciente SET nome = @nome, email = @email WHERE idPaciente = @idPaciente";
                    SqlCommand comand = new SqlCommand(sqlUpdQuery, conn);
                    comand.Parameters.AddWithValue("@idPaciente", idPaciente);
                    comand.Parameters.AddWithValue("@nome", nome);
                    comand.Parameters.AddWithValue("@email", email);

                    int contador = comand.ExecuteNonQuery();

                    //executar o update se existir o registro

                    if (contador < 1)
                    {
                        //faz um insert se o retorno for 0 ou  menos...
                        string sqlInsertQuery = "INSERT INTO Paciente(nome, email) VALUES (@nome, @email)";
                        comand = new SqlCommand(sqlInsertQuery, conn);
                        comand.Parameters.AddWithValue("@nome", nome);
                        comand.Parameters.AddWithValue("@email", email);

                        comand.ExecuteNonQuery();
                    }
                    conn.Close();
                    //manda a mensagem de sucesso e recarrega a ListView...
                    lblStatus.ForeColor = Color.Blue;
                    lblStatus.Text = $"{nome} cadastrado com sucesso!";
                    this.CarregarListView();
                    this.LimparCampos();
                    panCadPac.Enabled = false;
                    panCadPac.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Falha ao realizar o cadastro.\nErro: {ex.Message}", "Erro ao cadastrar");
                }
            }
        }

        private void lstPac_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                txtIdPac.Text = lstPac.SelectedItems[0].Text;
                txtNomePac.Text = lstPac.SelectedItems[0].SubItems[1].Text;
                txtMailPac.Text = lstPac.SelectedItems[0].SubItems[2].Text;
                btnExcluiPac.Enabled = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void btnEditPac_Click(object sender, EventArgs e)
        {
            try
            {
                panCadPac.Enabled = true;
                panCadPac.Visible = true;
                txtIdPac.Text = lstPac.SelectedItems[0].Text;
                txtNomePac.Text = lstPac.SelectedItems[0].SubItems[1].Text;
                txtMailPac.Text = lstPac.SelectedItems[0].SubItems[2].Text;
            }
            catch (Exception ex)
            {
                panCadPac.Enabled = false;
                panCadPac.Visible = false;
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = $"Selecione um paciente na lista antes de editar...";
            }
        }

        private void btnExcluiPac_Click(object sender, EventArgs e)
        {
            string paciente = lstPac.SelectedItems[0].SubItems[1].Text;
            DialogResult conf = MessageBox.Show($"Tem certeza que deseja remover o paciente {paciente}?", "Tem certeza?", MessageBoxButtons.YesNo);            

            if (conf == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(conexaoString);
                conn.Open();
                try
                {
                    int idPaciente = int.Parse(lstPac.SelectedItems[0].Text);

                    string sqlDelQuery = "DELETE FROM Paciente WHERE idPaciente = @idPaciente";

                    SqlCommand comand = new SqlCommand(sqlDelQuery, conn);
                    comand.Parameters.AddWithValue("@idPaciente", idPaciente);

                    comand.ExecuteNonQuery();
                    conn.Close();
                    lblStatus.ForeColor = Color.Blue;
                    lblStatus.Text = $"{paciente} excluído com sucesso!";
                    this.LimparCampos();
                    this.CarregarListView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha na operação de exclusão.\nErro: " + ex.Message, "Erro ao excluir paciente");
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = $"Falha na operação de exclusão do paciente {paciente}";
                }
            }
            else
            {
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = $"{paciente} mantido na base de dados";
            }

        }

    }
}