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
            this.grpCadForn = new System.Windows.Forms.GroupBox();
            this.btnCancelForn = new System.Windows.Forms.Button();
            this.btnLimpaForn = new System.Windows.Forms.Button();
            this.btnCadForn = new System.Windows.Forms.Button();
            this.txtCnpjForn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeForn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarForn = new System.Windows.Forms.Button();
            this.btnEditarForn = new System.Windows.Forms.Button();
            this.btnExcluiForn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).BeginInit();
            this.grpCadForn.SuspendLayout();
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
            this.dgvForn.Size = new System.Drawing.Size(695, 523);
            this.dgvForn.TabIndex = 15;
            this.dgvForn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForn_CellClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(132, 4);
            this.txtPesquisa.MaxLength = 60;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(465, 23);
            this.txtPesquisa.TabIndex = 14;
            this.txtPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyUp);
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
            // grpCadForn
            // 
            this.grpCadForn.Controls.Add(this.btnCancelForn);
            this.grpCadForn.Controls.Add(this.btnLimpaForn);
            this.grpCadForn.Controls.Add(this.btnCadForn);
            this.grpCadForn.Controls.Add(this.txtCnpjForn);
            this.grpCadForn.Controls.Add(this.label2);
            this.grpCadForn.Controls.Add(this.txtNomeForn);
            this.grpCadForn.Controls.Add(this.label1);
            this.grpCadForn.Location = new System.Drawing.Point(-1, 619);
            this.grpCadForn.Name = "grpCadForn";
            this.grpCadForn.Size = new System.Drawing.Size(705, 110);
            this.grpCadForn.TabIndex = 12;
            this.grpCadForn.TabStop = false;
            this.grpCadForn.Text = "Cadastro de novo fornecedor";
            this.grpCadForn.Visible = false;
            // 
            // btnCancelForn
            // 
            this.btnCancelForn.AutoSize = true;
            this.btnCancelForn.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelForn.ForeColor = System.Drawing.Color.Red;
            this.btnCancelForn.Location = new System.Drawing.Point(444, 68);
            this.btnCancelForn.Name = "btnCancelForn";
            this.btnCancelForn.Size = new System.Drawing.Size(124, 33);
            this.btnCancelForn.TabIndex = 13;
            this.btnCancelForn.Text = "Cancelar";
            this.btnCancelForn.UseVisualStyleBackColor = true;
            this.btnCancelForn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLimpaForn
            // 
            this.btnLimpaForn.AutoSize = true;
            this.btnLimpaForn.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpaForn.ForeColor = System.Drawing.Color.Red;
            this.btnLimpaForn.Location = new System.Drawing.Point(282, 68);
            this.btnLimpaForn.Name = "btnLimpaForn";
            this.btnLimpaForn.Size = new System.Drawing.Size(124, 33);
            this.btnLimpaForn.TabIndex = 11;
            this.btnLimpaForn.Text = "Limpar Campos";
            this.btnLimpaForn.UseVisualStyleBackColor = true;
            // 
            // btnCadForn
            // 
            this.btnCadForn.AutoSize = true;
            this.btnCadForn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadForn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadForn.Location = new System.Drawing.Point(133, 67);
            this.btnCadForn.Name = "btnCadForn";
            this.btnCadForn.Size = new System.Drawing.Size(101, 33);
            this.btnCadForn.TabIndex = 10;
            this.btnCadForn.Text = "Cadastrar";
            this.btnCadForn.UseVisualStyleBackColor = true;
            this.btnCadForn.Click += new System.EventHandler(this.btnCadForn_Click);
            // 
            // txtCnpjForn
            // 
            this.txtCnpjForn.Location = new System.Drawing.Point(496, 27);
            this.txtCnpjForn.MaxLength = 60;
            this.txtCnpjForn.Name = "txtCnpjForn";
            this.txtCnpjForn.Size = new System.Drawing.Size(205, 23);
            this.txtCnpjForn.TabIndex = 7;
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
            // btnCadastrarForn
            // 
            this.btnCadastrarForn.AutoSize = true;
            this.btnCadastrarForn.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarForn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrarForn.Location = new System.Drawing.Point(3, 562);
            this.btnCadastrarForn.Name = "btnCadastrarForn";
            this.btnCadastrarForn.Size = new System.Drawing.Size(230, 33);
            this.btnCadastrarForn.TabIndex = 20;
            this.btnCadastrarForn.Text = "Cadastrar fornecedor";
            this.btnCadastrarForn.UseVisualStyleBackColor = true;
            this.btnCadastrarForn.Click += new System.EventHandler(this.btnCadastrarForn_Click);
            // 
            // btnEditarForn
            // 
            this.btnEditarForn.AutoSize = true;
            this.btnEditarForn.Enabled = false;
            this.btnEditarForn.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarForn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEditarForn.Location = new System.Drawing.Point(236, 562);
            this.btnEditarForn.Name = "btnEditarForn";
            this.btnEditarForn.Size = new System.Drawing.Size(230, 33);
            this.btnEditarForn.TabIndex = 19;
            this.btnEditarForn.Text = "Editar fornecedor";
            this.btnEditarForn.UseVisualStyleBackColor = true;
            this.btnEditarForn.Click += new System.EventHandler(this.btnEditarForn_Click);
            // 
            // btnExcluiForn
            // 
            this.btnExcluiForn.AutoSize = true;
            this.btnExcluiForn.Enabled = false;
            this.btnExcluiForn.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluiForn.ForeColor = System.Drawing.Color.Red;
            this.btnExcluiForn.Location = new System.Drawing.Point(472, 562);
            this.btnExcluiForn.Name = "btnExcluiForn";
            this.btnExcluiForn.Size = new System.Drawing.Size(230, 33);
            this.btnExcluiForn.TabIndex = 18;
            this.btnExcluiForn.Text = "Excluir fornecedor";
            this.btnExcluiForn.UseVisualStyleBackColor = true;
            this.btnExcluiForn.Click += new System.EventHandler(this.btnExcluiForn_Click);
            // 
            // frmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 729);
            this.Controls.Add(this.btnCadastrarForn);
            this.Controls.Add(this.btnEditarForn);
            this.Controls.Add(this.btnExcluiForn);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvForn);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpCadForn);
            this.Name = "frmFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFornecedores_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).EndInit();
            this.grpCadForn.ResumeLayout(false);
            this.grpCadForn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLimpar;
        private Label lblStatus;
        private DataGridView dgvForn;
        private TextBox txtPesquisa;
        private Label label6;
        private GroupBox grpCadForn;
        private Button btnCancelForn;
        private Button btnLimpaForn;
        private Button btnCadForn;
        private Label label2;
        private TextBox txtNomeForn;
        private Label label1;
        private TextBox txtCnpjForn;
        private Button btnCadastrarForn;
        private Button btnEditarForn;
        private Button btnExcluiForn;
    }
}