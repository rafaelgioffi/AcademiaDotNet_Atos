namespace PrimeiroAppADO.NET
{
    partial class frmCadEmpregados
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtGerente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFuncao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtAdmissao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNCadastrar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(90, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(191, 23);
            this.txtNome.TabIndex = 0;
            // 
            // txtGerente
            // 
            this.txtGerente.Location = new System.Drawing.Point(90, 39);
            this.txtGerente.MaxLength = 2;
            this.txtGerente.Name = "txtGerente";
            this.txtGerente.Size = new System.Drawing.Size(62, 23);
            this.txtGerente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gerente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Função";
            // 
            // cbFuncao
            // 
            this.cbFuncao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cbFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncao.FormattingEnabled = true;
            this.cbFuncao.Items.AddRange(new object[] {
            "Balconista",
            "Gerente",
            "Operário",
            "Presidente",
            "Vendedor"});
            this.cbFuncao.Location = new System.Drawing.Point(90, 84);
            this.cbFuncao.Name = "cbFuncao";
            this.cbFuncao.Size = new System.Drawing.Size(121, 23);
            this.cbFuncao.Sorted = true;
            this.cbFuncao.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Departamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Admissão";
            // 
            // dtAdmissao
            // 
            this.dtAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAdmissao.Location = new System.Drawing.Point(90, 159);
            this.dtAdmissao.Name = "dtAdmissao";
            this.dtAdmissao.Size = new System.Drawing.Size(97, 23);
            this.dtAdmissao.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Salário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Comissão";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrar.Location = new System.Drawing.Point(1, 283);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(151, 28);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNCadastrar
            // 
            this.btnNCadastrar.ForeColor = System.Drawing.Color.Red;
            this.btnNCadastrar.Location = new System.Drawing.Point(172, 283);
            this.btnNCadastrar.Name = "btnNCadastrar";
            this.btnNCadastrar.Size = new System.Drawing.Size(109, 28);
            this.btnNCadastrar.TabIndex = 8;
            this.btnNCadastrar.Text = "Não Cadastrar";
            this.btnNCadastrar.UseVisualStyleBackColor = true;
            this.btnNCadastrar.Click += new System.EventHandler(this.btnNCadastrar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 316);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(289, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(90, 200);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(97, 23);
            this.txtSalario.TabIndex = 5;
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(90, 238);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(97, 23);
            this.txtComissao.TabIndex = 6;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(90, 125);
            this.txtDepartamento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(62, 23);
            this.txtDepartamento.TabIndex = 18;
            this.txtDepartamento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmCadEmpregados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 338);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnNCadastrar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtAdmissao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFuncao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGerente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmCadEmpregados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Empregados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadEmpregados_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtGerente;
        private Label label2;
        private Label label3;
        private ComboBox cbFuncao;
        private Label label4;
        private Label label5;
        private DateTimePicker dtAdmissao;
        private Label label6;
        private Label label7;
        private Button btnCadastrar;
        private Button btnNCadastrar;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private TextBox txtSalario;
        private TextBox txtComissao;
        private NumericUpDown txtDepartamento;
    }
}