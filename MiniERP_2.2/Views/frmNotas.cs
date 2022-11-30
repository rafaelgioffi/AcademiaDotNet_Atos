using iTextSharp.text;
using iTextSharp.text.pdf;
using MiniERP_2_2.Classes;
using System.Data;

namespace MiniERP.Views
{
    public partial class frmNotas : Form
    {
        AtosUfnContext context = new AtosUfnContext();
        public frmNotas()
        {
            InitializeComponent();
            AtualizaNotas();
        }
        private void AtualizaNotas()
        {
            try
            {
                List<Notas> notas = (from Notas n in context.Notas select n).ToList<Notas>();
                dgvNotas.DataSource = notas;

                lblStatus.Text = $"{dgvNotas.RowCount} notas cadastradas";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao recuperar os dados do banco de dados...");
            }
        }

        private void LimparCampos()
        {
            txtInfoNota.Clear();
            txtIdCli.Value = 1;
            txtIdProd.Value = 1;
        }

        private void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPesquisa.Text.Length > 3)
            {
               
                DataTable dt = new DataTable();
                //dt = bd.Consulta($"SELECT NotId 'ID', NotInfo 'Observações', NotDataHora 'Data e Hora', NotTipo 'Tipo', CliId 'ID do Cliente', ProdId 'ID do Produto' FROM Notas WHERE NotInfo LIKE '%{txtPesquisa.Text}%'");

                dgvNotas.DataSource = dt;
            }
            else
            {
                AtualizaNotas();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            AtualizaNotas();
            txtPesquisa.Clear();
        }

        private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarNota.Enabled = true;
            btnExcluiNota.Enabled = true;
        }

        private void btnCadastrarNota_Click(object sender, EventArgs e)
        {
            grpCadNota.Visible = true;
            btnCadastrarNota.Enabled = false;
        }

        private void btnEditarNota_Click(object sender, EventArgs e)
        {
            frmEditNot nota = new frmEditNot();
            nota.txtIdNot.Text = dgvNotas.SelectedRows[0].Cells[0].Value.ToString();
            nota.txtInfoNota.Text = dgvNotas.SelectedRows[0].Cells[1].Value.ToString();
            if (dgvNotas.SelectedRows[0].Cells[3].Value.ToString() == "Compra")
            {
                nota.rdCompra.Checked = true;
            }
            else if (dgvNotas.SelectedRows[0].Cells[3].Value.ToString() == "Venda")
            {
                nota.rdVenda.Checked = true;
            }
            nota.txtIdCli.Text = dgvNotas.SelectedRows[0].Cells[4].Value.ToString();
            nota.txtIdProd.Text = dgvNotas.SelectedRows[0].Cells[5].Value.ToString();

            nota.Show();
            this.Hide();
        }

        private void btnExcluiNota_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Tem certeza que deseja excluir a nota ID '{dgvNotas.SelectedRows[0].Cells[0].Value.ToString()}'?", "Exclusão de nota", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
            }
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            //tentar converter os id's do cliente e prooduto
            int cliId, prodId;
            int.TryParse(txtIdCli.Text, out cliId);
            int.TryParse(txtIdProd.Text, out prodId);

            //tratar a data e hora
            DateTime datahora = DateTime.Now;
            string datahoraFormat = $"{datahora.Day}-{datahora.Month}-{datahora.Year} {datahora.Hour}:{datahora.Minute}:{datahora.Second}";

            //criar a primary key...
            string NotId = datahora.ToString();
            NotId = NotId.Replace("/", "");
            NotId = NotId.Replace(":", "");
            NotId = NotId.Replace(" ", "");
            NotId += cliId.ToString() + prodId.ToString();

            if (cliId <= 0)
            {
                MessageBox.Show("O campo 'ID do Cliente' é de preenchimento obrigatório");
                txtIdCli.Focus();
            }
            else if (prodId <= 0)
            {
                MessageBox.Show("O campo 'ID do Produto' é de preenchimento obrigatório");
                txtIdProd.Focus();
            }
            else if (rdCompra.Checked == false && rdVenda.Checked == false)
            {
                MessageBox.Show("É necessário marcar um tipo de nota");
                rdVenda.Focus();
            }
            else
            {
                string compraVenda = "";
                if (rdCompra.Checked)
                {
                    compraVenda = rdCompra.Text;
                }
                else if (rdVenda.Checked)
                {
                    compraVenda = rdVenda.Text;
                }

                try
                {
                    Notas nota = new Notas();

                    nota.NotId = NotId;
                    nota.NotInfo = txtInfoNota.Text;
                    nota.NotDataHora = datahora;
                    nota.NotInfo = compraVenda;
                    nota.CliId = cliId;
                    nota.ProdId = prodId;

                    context.Notas.Add(nota);
                    context.SaveChanges();
                    
                    MessageBox.Show("Nota cadastrada com sucesso!");
                    AtualizaNotas();
                    LimparCampos();
                    grpCadNota.Visible = false;
                    btnCadastrarNota.Enabled = true;

                } catch (Exception ex)
                {
                    MessageBox.Show($"Falha ao cadastrar a nota '{NotId}'...","Erro");
                }


                
            }
        }

        private void frmNotas_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMiniErp frmMini = new frmMiniErp();
            frmMini.Show();
        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            btnGerarPdf.Enabled = false;
            btnGerarPdf.Text = "Gerando PDF...";

            DateTime data = DateTime.Now;
            string novaData = $"{data.Day}-{data.Month}-{data.Year}";

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF (*.pdf)|*.pdf";
            save.FileName = "Nota Fiscal " + novaData + ".pdf";
            save.ShowDialog();

            string arq = save.FileNames[0].ToString();

            FileStream pdf = new FileStream(arq, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escPdf = PdfWriter.GetInstance(doc, pdf);

            string dados = "";

            for (int i = 0; i < dgvNotas.RowCount; i++)
            {
                Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
                paragrafo.Alignment = Element.ALIGN_LEFT;
                paragrafo.Add($"Nota Fiscal {dgvNotas.Rows[i].Cells[0].Value}\n");

                paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14);
                paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                paragrafo.Add($"Observações: {dgvNotas.Rows[i].Cells[1].Value}\n");

                paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14);
                paragrafo.Alignment = Element.ALIGN_LEFT;
                paragrafo.Add($"Gerado {dgvNotas.Rows[i].Cells[2].Value}h\n");
                
                paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14);
                paragrafo.Alignment = Element.ALIGN_LEFT;
                paragrafo.Add($"Tipo de nota: {dgvNotas.Rows[i].Cells[3].Value}\n");

                paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14);
                paragrafo.Alignment = Element.ALIGN_LEFT;
                paragrafo.Add($"ID do Cliente: {dgvNotas.Rows[i].Cells[4].Value}\n");

                paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14);
                paragrafo.Alignment = Element.ALIGN_LEFT;
                paragrafo.Add($"ID do Produto: {dgvNotas.Rows[i].Cells[5].Value}\n\n");

                doc.Open();
                doc.Add(paragrafo);
            }

            doc.Close();
            MessageBox.Show($"Relatório gerado com sucesso em {arq}!");
            btnGerarPdf.Text = "Gerar PDF";
            btnGerarPdf.Enabled = true;            
        }

        private void rdCompra_CheckedChanged(object sender, EventArgs e)
        {
            if(rdCompra.Checked)
            {
                txtInfoNota.Text = "Compra";
            }
        }

        private void rdVenda_CheckedChanged(object sender, EventArgs e)
        {
            if(rdVenda.Checked)
            {
                txtInfoNota.Text = "Venda";
            }
        }
    }
}
