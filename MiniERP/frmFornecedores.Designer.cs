namespace MiniERP
{
    partial class frmFornecedores
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvForn = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCancelProd = new System.Windows.Forms.Button();
            this.btnCadProd = new System.Windows.Forms.Button();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeForn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLimpar.Location = new System.Drawing.Point(603, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 25);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStatus.Location = new System.Drawing.Point(553, 601);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(151, 15);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "0 fornecedores cadastrados";
            // 
            // dgvForn
            // 
            this.dgvForn.AllowUserToAddRows = false;
            this.dgvForn.AllowUserToDeleteRows = false;
            this.dgvForn.AllowUserToResizeColumns = false;
            this.dgvForn.AllowUserToResizeRows = false;
            this.dgvForn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvForn.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvForn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForn.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvForn.Location = new System.Drawing.Point(5, 33);
            this.dgvForn.MultiSelect = false;
            this.dgvForn.Name = "dgvForn";
            this.dgvForn.ReadOnly = true;
            this.dgvForn.RowHeadersVisible = false;
            this.dgvForn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvForn.RowTemplate.Height = 25;
            this.dgvForn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvForn.Size = new System.Drawing.Size(695, 565);
            this.dgvForn.TabIndex = 15;
            this.dgvForn.SelectionChanged += new System.EventHandler(this.dgvForn_SelectionChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(132, 4);
            this.txtPesquisa.MaxLength = 60;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(465, 23);
            this.txtPesquisa.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pesquisar fornecedor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnCancelProd);
            this.groupBox1.Controls.Add(this.btnCadProd);
            this.groupBox1.Controls.Add(this.txtCnpj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNomeForn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, 619);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 110);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de novo fornecedor";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(444, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancelProd
            // 
            this.btnCancelProd.AutoSize = true;
            this.btnCancelProd.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelProd.ForeColor = System.Drawing.Color.Red;
            this.btnCancelProd.Location = new System.Drawing.Point(282, 68);
            this.btnCancelProd.Name = "btnCancelProd";
            this.btnCancelProd.Size = new System.Drawing.Size(124, 33);
            this.btnCancelProd.TabIndex = 11;
            this.btnCancelProd.Text = "Limpar Campos";
            this.btnCancelProd.UseVisualStyleBackColor = true;
            // 
            // btnCadProd
            // 
            this.btnCadProd.AutoSize = true;
            this.btnCadProd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadProd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadProd.Location = new System.Drawing.Point(133, 67);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(101, 33);
            this.btnCadProd.TabIndex = 10;
            this.btnCadProd.Text = "Cadastrar";
            this.btnCadProd.UseVisualStyleBackColor = true;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(496, 27);
            this.txtCnpj.MaxLength = 60;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(205, 23);
            this.txtCnpj.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "CNPJ:";
            // 
            // txtNomeForn
            // 
            this.txtNomeForn.Location = new System.Drawing.Point(55, 27);
            this.txtNomeForn.MaxLength = 60;
            this.txtNomeForn.Name = "txtNomeForn";
            this.txtNomeForn.Size = new System.Drawing.Size(392, 23);
            this.txtNomeForn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // frmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 729);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvForn);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFornecedores_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLimpar;
        private Label lblStatus;
        private DataGridView dgvForn;
        private TextBox txtPesquisa;
        private Label label6;
        private GroupBox groupBox1;
        private Button button2;
        private Button btnCancelProd;
        private Button btnCadProd;
        private Label label2;
        private TextBox txtNomeForn;
        private Label label1;
        private TextBox txtCnpj;
    }
}