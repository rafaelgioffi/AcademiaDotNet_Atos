namespace MiniERP
{
    partial class frmProdutos
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
            this.txtDescProd = new System.Windows.Forms.RichTextBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.grpCadProd = new System.Windows.Forms.GroupBox();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelCadProd = new System.Windows.Forms.Button();
            this.txtQuantProd = new System.Windows.Forms.NumericUpDown();
            this.btnCancelProd = new System.Windows.Forms.Button();
            this.btnCadProd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdForn = new System.Windows.Forms.NumericUpDown();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExcluiProd = new System.Windows.Forms.Button();
            this.btnEditarProd = new System.Windows.Forms.Button();
            this.btnCadastrarProd = new System.Windows.Forms.Button();
            this.grpCadProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdForn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtDescProd
            // 
            this.txtDescProd.Location = new System.Drawing.Point(71, 68);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.Size = new System.Drawing.Size(467, 76);
            this.txtDescProd.TabIndex = 1;
            this.txtDescProd.Text = "";
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(71, 27);
            this.txtNomeProd.MaxLength = 60;
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(467, 23);
            this.txtNomeProd.TabIndex = 2;
            // 
            // grpCadProd
            // 
            this.grpCadProd.Controls.Add(this.txtProdId);
            this.grpCadProd.Controls.Add(this.label7);
            this.grpCadProd.Controls.Add(this.btnCancelCadProd);
            this.grpCadProd.Controls.Add(this.txtQuantProd);
            this.grpCadProd.Controls.Add(this.btnCancelProd);
            this.grpCadProd.Controls.Add(this.btnCadProd);
            this.grpCadProd.Controls.Add(this.label5);
            this.grpCadProd.Controls.Add(this.txtValProd);
            this.grpCadProd.Controls.Add(this.label4);
            this.grpCadProd.Controls.Add(this.label3);
            this.grpCadProd.Controls.Add(this.label2);
            this.grpCadProd.Controls.Add(this.txtIdForn);
            this.grpCadProd.Controls.Add(this.txtNomeProd);
            this.grpCadProd.Controls.Add(this.label1);
            this.grpCadProd.Controls.Add(this.txtDescProd);
            this.grpCadProd.Location = new System.Drawing.Point(3, 538);
            this.grpCadProd.Name = "grpCadProd";
            this.grpCadProd.Size = new System.Drawing.Size(699, 193);
            this.grpCadProd.TabIndex = 4;
            this.grpCadProd.TabStop = false;
            this.grpCadProd.Text = "Cadastro de novo produto";
            this.grpCadProd.Visible = false;
            // 
            // txtProdId
            // 
            this.txtProdId.Location = new System.Drawing.Point(620, 30);
            this.txtProdId.MaxLength = 60;
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.ReadOnly = true;
            this.txtProdId.Size = new System.Drawing.Size(62, 23);
            this.txtProdId.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(593, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID:";
            // 
            // btnCancelCadProd
            // 
            this.btnCancelCadProd.AutoSize = true;
            this.btnCancelCadProd.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelCadProd.ForeColor = System.Drawing.Color.Red;
            this.btnCancelCadProd.Location = new System.Drawing.Point(405, 154);
            this.btnCancelCadProd.Name = "btnCancelCadProd";
            this.btnCancelCadProd.Size = new System.Drawing.Size(124, 33);
            this.btnCancelCadProd.TabIndex = 13;
            this.btnCancelCadProd.Text = "Cancelar";
            this.btnCancelCadProd.UseVisualStyleBackColor = true;
            this.btnCancelCadProd.Click += new System.EventHandler(this.btnCancelCadProd_Click);
            // 
            // txtQuantProd
            // 
            this.txtQuantProd.Location = new System.Drawing.Point(620, 121);
            this.txtQuantProd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtQuantProd.Name = "txtQuantProd";
            this.txtQuantProd.Size = new System.Drawing.Size(58, 23);
            this.txtQuantProd.TabIndex = 12;
            this.txtQuantProd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCancelProd
            // 
            this.btnCancelProd.AutoSize = true;
            this.btnCancelProd.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelProd.ForeColor = System.Drawing.Color.Red;
            this.btnCancelProd.Location = new System.Drawing.Point(266, 154);
            this.btnCancelProd.Name = "btnCancelProd";
            this.btnCancelProd.Size = new System.Drawing.Size(124, 33);
            this.btnCancelProd.TabIndex = 11;
            this.btnCancelProd.Text = "Limpar Campos";
            this.btnCancelProd.UseVisualStyleBackColor = true;
            this.btnCancelProd.Click += new System.EventHandler(this.btnCancelProd_Click);
            // 
            // btnCadProd
            // 
            this.btnCadProd.AutoSize = true;
            this.btnCadProd.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadProd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadProd.Location = new System.Drawing.Point(149, 153);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(101, 33);
            this.btnCadProd.TabIndex = 10;
            this.btnCadProd.Text = "Cadastrar";
            this.btnCadProd.UseVisualStyleBackColor = true;
            this.btnCadProd.Click += new System.EventHandler(this.btnCadProd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantidade:";
            // 
            // txtValProd
            // 
            this.txtValProd.Location = new System.Drawing.Point(620, 92);
            this.txtValProd.MaxLength = 60;
            this.txtValProd.Name = "txtValProd";
            this.txtValProd.Size = new System.Drawing.Size(73, 23);
            this.txtValProd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fornecedor:";
            // 
            // txtIdForn
            // 
            this.txtIdForn.Location = new System.Drawing.Point(620, 60);
            this.txtIdForn.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtIdForn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtIdForn.Name = "txtIdForn";
            this.txtIdForn.Size = new System.Drawing.Size(58, 23);
            this.txtIdForn.TabIndex = 3;
            this.txtIdForn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(115, 6);
            this.txtPesquisa.MaxLength = 60;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(480, 23);
            this.txtPesquisa.TabIndex = 6;
            this.txtPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pesquisar produto:";
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.AllowUserToResizeColumns = false;
            this.dgvProd.AllowUserToResizeRows = false;
            this.dgvProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProd.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProd.Location = new System.Drawing.Point(3, 35);
            this.dgvProd.MultiSelect = false;
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.RowHeadersVisible = false;
            this.dgvProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProd.RowTemplate.Height = 25;
            this.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProd.Size = new System.Drawing.Size(699, 443);
            this.dgvProd.TabIndex = 7;
            this.dgvProd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellClick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStatus.Location = new System.Drawing.Point(572, 520);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(130, 15);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "0 produtos cadastrados";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(601, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExcluiProd
            // 
            this.btnExcluiProd.AutoSize = true;
            this.btnExcluiProd.Enabled = false;
            this.btnExcluiProd.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluiProd.ForeColor = System.Drawing.Color.Red;
            this.btnExcluiProd.Location = new System.Drawing.Point(472, 484);
            this.btnExcluiProd.Name = "btnExcluiProd";
            this.btnExcluiProd.Size = new System.Drawing.Size(230, 33);
            this.btnExcluiProd.TabIndex = 14;
            this.btnExcluiProd.Text = "Excluir produto";
            this.btnExcluiProd.UseVisualStyleBackColor = true;
            this.btnExcluiProd.Click += new System.EventHandler(this.btnExcluiProd_Click);
            // 
            // btnEditarProd
            // 
            this.btnEditarProd.AutoSize = true;
            this.btnEditarProd.Enabled = false;
            this.btnEditarProd.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarProd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEditarProd.Location = new System.Drawing.Point(236, 484);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.Size = new System.Drawing.Size(230, 33);
            this.btnEditarProd.TabIndex = 15;
            this.btnEditarProd.Text = "Editar produto";
            this.btnEditarProd.UseVisualStyleBackColor = true;
            this.btnEditarProd.Click += new System.EventHandler(this.btnEditarProd_Click);
            // 
            // btnCadastrarProd
            // 
            this.btnCadastrarProd.AutoSize = true;
            this.btnCadastrarProd.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarProd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrarProd.Location = new System.Drawing.Point(3, 484);
            this.btnCadastrarProd.Name = "btnCadastrarProd";
            this.btnCadastrarProd.Size = new System.Drawing.Size(230, 33);
            this.btnCadastrarProd.TabIndex = 16;
            this.btnCadastrarProd.Text = "Cadastrar produto";
            this.btnCadastrarProd.UseVisualStyleBackColor = true;
            this.btnCadastrarProd.Click += new System.EventHandler(this.btnCadastrarProd_Click);
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 729);
            this.Controls.Add(this.btnCadastrarProd);
            this.Controls.Add(this.btnEditarProd);
            this.Controls.Add(this.btnExcluiProd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpCadProd);
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProdutos_FormClosed);
            this.grpCadProd.ResumeLayout(false);
            this.grpCadProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdForn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RichTextBox txtDescProd;
        private TextBox txtNomeProd;
        private GroupBox grpCadProd;
        private NumericUpDown txtQuantProd;
        private Button btnCancelProd;
        private Button btnCadProd;
        private Label label5;
        private TextBox txtValProd;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown txtIdForn;
        private TextBox txtPesquisa;
        private Label label6;
        private DataGridView dgvProd;
        private Label lblStatus;
        private Button button1;
        private Button btnCancelCadProd;
        private Button btnExcluiProd;
        private Button btnEditarProd;
        private Button btnCadastrarProd;
        private TextBox txtProdId;
        private Label label7;
    }
}