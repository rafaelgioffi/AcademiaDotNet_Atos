namespace MiniERP.Views
{
    partial class frmNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrarNota = new System.Windows.Forms.Button();
            this.btnEditarNota = new System.Windows.Forms.Button();
            this.btnExcluiNota = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpCadNota = new System.Windows.Forms.GroupBox();
            this.rdCompra = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rdVenda = new System.Windows.Forms.RadioButton();
            this.txtIdProd = new System.Windows.Forms.NumericUpDown();
            this.txtIdCli = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelCli = new System.Windows.Forms.Button();
            this.btnLimpaCli = new System.Windows.Forms.Button();
            this.btnCadCli = new System.Windows.Forms.Button();
            this.txtInfoNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerarPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.grpCadNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCli)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarNota
            // 
            this.btnCadastrarNota.AutoSize = true;
            this.btnCadastrarNota.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarNota.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrarNota.Location = new System.Drawing.Point(6, 523);
            this.btnCadastrarNota.Name = "btnCadastrarNota";
            this.btnCadastrarNota.Size = new System.Drawing.Size(170, 33);
            this.btnCadastrarNota.TabIndex = 38;
            this.btnCadastrarNota.Text = "Emitir nota";
            this.btnCadastrarNota.UseVisualStyleBackColor = true;
            this.btnCadastrarNota.Click += new System.EventHandler(this.btnCadastrarNota_Click);
            // 
            // btnEditarNota
            // 
            this.btnEditarNota.AutoSize = true;
            this.btnEditarNota.Enabled = false;
            this.btnEditarNota.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarNota.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEditarNota.Location = new System.Drawing.Point(180, 523);
            this.btnEditarNota.Name = "btnEditarNota";
            this.btnEditarNota.Size = new System.Drawing.Size(170, 33);
            this.btnEditarNota.TabIndex = 37;
            this.btnEditarNota.Text = "Editar nota";
            this.btnEditarNota.UseVisualStyleBackColor = true;
            this.btnEditarNota.Click += new System.EventHandler(this.btnEditarNota_Click);
            // 
            // btnExcluiNota
            // 
            this.btnExcluiNota.AutoSize = true;
            this.btnExcluiNota.Enabled = false;
            this.btnExcluiNota.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluiNota.ForeColor = System.Drawing.Color.Red;
            this.btnExcluiNota.Location = new System.Drawing.Point(356, 523);
            this.btnExcluiNota.Name = "btnExcluiNota";
            this.btnExcluiNota.Size = new System.Drawing.Size(170, 33);
            this.btnExcluiNota.TabIndex = 36;
            this.btnExcluiNota.Text = "Excluir nota";
            this.btnExcluiNota.UseVisualStyleBackColor = true;
            this.btnExcluiNota.Click += new System.EventHandler(this.btnExcluiNota_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLimpar.Location = new System.Drawing.Point(604, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 25);
            this.btnLimpar.TabIndex = 35;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStatus.Location = new System.Drawing.Point(554, 562);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(149, 15);
            this.lblStatus.TabIndex = 34;
            this.lblStatus.Text = "0 notas cadastradas";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToAddRows = false;
            this.dgvNotas.AllowUserToDeleteRows = false;
            this.dgvNotas.AllowUserToResizeColumns = false;
            this.dgvNotas.AllowUserToResizeRows = false;
            this.dgvNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNotas.Location = new System.Drawing.Point(6, 29);
            this.dgvNotas.MultiSelect = false;
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.RowHeadersVisible = false;
            this.dgvNotas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvNotas.RowTemplate.Height = 25;
            this.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotas.Size = new System.Drawing.Size(695, 488);
            this.dgvNotas.TabIndex = 33;
            this.dgvNotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotas_CellClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(114, 3);
            this.txtPesquisa.MaxLength = 60;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(484, 23);
            this.txtPesquisa.TabIndex = 32;
            this.txtPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Pesquisar nota:";
            // 
            // grpCadNota
            // 
            this.grpCadNota.Controls.Add(this.rdCompra);
            this.grpCadNota.Controls.Add(this.label4);
            this.grpCadNota.Controls.Add(this.rdVenda);
            this.grpCadNota.Controls.Add(this.txtIdProd);
            this.grpCadNota.Controls.Add(this.txtIdCli);
            this.grpCadNota.Controls.Add(this.label3);
            this.grpCadNota.Controls.Add(this.label2);
            this.grpCadNota.Controls.Add(this.btnCancelCli);
            this.grpCadNota.Controls.Add(this.btnLimpaCli);
            this.grpCadNota.Controls.Add(this.btnCadCli);
            this.grpCadNota.Controls.Add(this.txtInfoNota);
            this.grpCadNota.Controls.Add(this.label1);
            this.grpCadNota.Location = new System.Drawing.Point(0, 580);
            this.grpCadNota.Name = "grpCadNota";
            this.grpCadNota.Size = new System.Drawing.Size(705, 145);
            this.grpCadNota.TabIndex = 30;
            this.grpCadNota.TabStop = false;
            this.grpCadNota.Text = "Cadastro de nova nota fiscal";
            this.grpCadNota.Visible = false;
            // 
            // rdCompra
            // 
            this.rdCompra.AutoSize = true;
            this.rdCompra.Location = new System.Drawing.Point(89, 67);
            this.rdCompra.Name = "rdCompra";
            this.rdCompra.Size = new System.Drawing.Size(68, 19);
            this.rdCompra.TabIndex = 20;
            this.rdCompra.TabStop = true;
            this.rdCompra.Text = "Compra";
            this.rdCompra.UseVisualStyleBackColor = true;
            this.rdCompra.CheckedChanged += new System.EventHandler(this.rdCompra_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tipo:";
            // 
            // rdVenda
            // 
            this.rdVenda.AutoSize = true;
            this.rdVenda.Location = new System.Drawing.Point(166, 67);
            this.rdVenda.Name = "rdVenda";
            this.rdVenda.Size = new System.Drawing.Size(57, 19);
            this.rdVenda.TabIndex = 18;
            this.rdVenda.TabStop = true;
            this.rdVenda.Text = "Venda";
            this.rdVenda.UseVisualStyleBackColor = true;
            this.rdVenda.CheckedChanged += new System.EventHandler(this.rdVenda_CheckedChanged);
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(559, 67);
            this.txtIdProd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtIdProd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(58, 23);
            this.txtIdProd.TabIndex = 17;
            this.txtIdProd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtIdCli
            // 
            this.txtIdCli.Location = new System.Drawing.Point(356, 67);
            this.txtIdCli.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtIdCli.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtIdCli.Name = "txtIdCli";
            this.txtIdCli.Size = new System.Drawing.Size(68, 23);
            this.txtIdCli.TabIndex = 16;
            this.txtIdCli.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID do Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID do Cliente:";
            // 
            // btnCancelCli
            // 
            this.btnCancelCli.AutoSize = true;
            this.btnCancelCli.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelCli.ForeColor = System.Drawing.Color.Red;
            this.btnCancelCli.Location = new System.Drawing.Point(444, 106);
            this.btnCancelCli.Name = "btnCancelCli";
            this.btnCancelCli.Size = new System.Drawing.Size(124, 33);
            this.btnCancelCli.TabIndex = 13;
            this.btnCancelCli.Text = "Cancelar";
            this.btnCancelCli.UseVisualStyleBackColor = true;
            // 
            // btnLimpaCli
            // 
            this.btnLimpaCli.AutoSize = true;
            this.btnLimpaCli.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpaCli.ForeColor = System.Drawing.Color.Red;
            this.btnLimpaCli.Location = new System.Drawing.Point(282, 106);
            this.btnLimpaCli.Name = "btnLimpaCli";
            this.btnLimpaCli.Size = new System.Drawing.Size(124, 33);
            this.btnLimpaCli.TabIndex = 11;
            this.btnLimpaCli.Text = "Limpar Campos";
            this.btnLimpaCli.UseVisualStyleBackColor = true;
            // 
            // btnCadCli
            // 
            this.btnCadCli.AutoSize = true;
            this.btnCadCli.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadCli.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadCli.Location = new System.Drawing.Point(133, 105);
            this.btnCadCli.Name = "btnCadCli";
            this.btnCadCli.Size = new System.Drawing.Size(101, 33);
            this.btnCadCli.TabIndex = 10;
            this.btnCadCli.Text = "Cadastrar";
            this.btnCadCli.UseVisualStyleBackColor = true;
            this.btnCadCli.Click += new System.EventHandler(this.btnCadCli_Click);
            // 
            // txtInfoNota
            // 
            this.txtInfoNota.Location = new System.Drawing.Point(89, 27);
            this.txtInfoNota.MaxLength = 60;
            this.txtInfoNota.Name = "txtInfoNota";
            this.txtInfoNota.Size = new System.Drawing.Size(610, 23);
            this.txtInfoNota.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Observações:";
            // 
            // btnGerarPdf
            // 
            this.btnGerarPdf.AutoSize = true;
            this.btnGerarPdf.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGerarPdf.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGerarPdf.Location = new System.Drawing.Point(531, 523);
            this.btnGerarPdf.Name = "btnGerarPdf";
            this.btnGerarPdf.Size = new System.Drawing.Size(170, 33);
            this.btnGerarPdf.TabIndex = 39;
            this.btnGerarPdf.Text = "Gerar PDF";
            this.btnGerarPdf.UseVisualStyleBackColor = true;
            this.btnGerarPdf.Click += new System.EventHandler(this.btnGerarPdf_Click);
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 729);
            this.Controls.Add(this.btnGerarPdf);
            this.Controls.Add(this.btnCadastrarNota);
            this.Controls.Add(this.btnEditarNota);
            this.Controls.Add(this.btnExcluiNota);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpCadNota);
            this.Name = "frmNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de Notas Fiscais";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNotas_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.grpCadNota.ResumeLayout(false);
            this.grpCadNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCadastrarNota;
        private Button btnEditarNota;
        private Button btnExcluiNota;
        private Button btnLimpar;
        private Label lblStatus;
        private DataGridView dgvNotas;
        private TextBox txtPesquisa;
        private Label label6;
        private GroupBox grpCadNota;
        private Label label3;
        private Label label2;
        private Button btnCancelCli;
        private Button btnLimpaCli;
        private Button btnCadCli;
        private TextBox txtInfoNota;
        private Label label1;
        private NumericUpDown txtIdProd;
        private NumericUpDown txtIdCli;
        private Button btnGerarPdf;
        private RadioButton rdCompra;
        private Label label4;
        private RadioButton rdVenda;
    }
}