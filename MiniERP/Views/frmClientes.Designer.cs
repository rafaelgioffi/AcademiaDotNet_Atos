namespace MiniERP.Views
{
    partial class frmClientes
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
            this.btnCadastrarCli = new System.Windows.Forms.Button();
            this.btnEditarCli = new System.Windows.Forms.Button();
            this.btnExcluiUser = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpCadUsr = new System.Windows.Forms.GroupBox();
            this.btnCancelCli = new System.Windows.Forms.Button();
            this.btnLimpaCli = new System.Windows.Forms.Button();
            this.btnCadUser = new System.Windows.Forms.Button();
            this.txtTelUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.grpCadUsr.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrarCli
            // 
            this.btnCadastrarCli.AutoSize = true;
            this.btnCadastrarCli.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarCli.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrarCli.Location = new System.Drawing.Point(4, 560);
            this.btnCadastrarCli.Name = "btnCadastrarCli";
            this.btnCadastrarCli.Size = new System.Drawing.Size(230, 33);
            this.btnCadastrarCli.TabIndex = 29;
            this.btnCadastrarCli.Text = "Cadastrar cliente";
            this.btnCadastrarCli.UseVisualStyleBackColor = true;
            this.btnCadastrarCli.Click += new System.EventHandler(this.btnCadastrarUser_Click);
            // 
            // btnEditarCli
            // 
            this.btnEditarCli.AutoSize = true;
            this.btnEditarCli.Enabled = false;
            this.btnEditarCli.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarCli.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEditarCli.Location = new System.Drawing.Point(237, 560);
            this.btnEditarCli.Name = "btnEditarCli";
            this.btnEditarCli.Size = new System.Drawing.Size(230, 33);
            this.btnEditarCli.TabIndex = 28;
            this.btnEditarCli.Text = "Editar cliente";
            this.btnEditarCli.UseVisualStyleBackColor = true;
            // 
            // btnExcluiUser
            // 
            this.btnExcluiUser.AutoSize = true;
            this.btnExcluiUser.Enabled = false;
            this.btnExcluiUser.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluiUser.ForeColor = System.Drawing.Color.Red;
            this.btnExcluiUser.Location = new System.Drawing.Point(473, 560);
            this.btnExcluiUser.Name = "btnExcluiUser";
            this.btnExcluiUser.Size = new System.Drawing.Size(230, 33);
            this.btnExcluiUser.TabIndex = 27;
            this.btnExcluiUser.Text = "Excluir cliente";
            this.btnExcluiUser.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLimpar.Location = new System.Drawing.Point(604, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 25);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStatus.Location = new System.Drawing.Point(576, 599);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(112, 15);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "0 cliente cadastrado";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.Location = new System.Drawing.Point(6, 31);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(695, 523);
            this.dgvClientes.TabIndex = 24;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(114, 5);
            this.txtPesquisa.MaxLength = 60;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(484, 23);
            this.txtPesquisa.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Pesquisar cliente:";
            // 
            // grpCadUsr
            // 
            this.grpCadUsr.Controls.Add(this.btnCancelCli);
            this.grpCadUsr.Controls.Add(this.btnLimpaCli);
            this.grpCadUsr.Controls.Add(this.btnCadUser);
            this.grpCadUsr.Controls.Add(this.txtTelUser);
            this.grpCadUsr.Controls.Add(this.label2);
            this.grpCadUsr.Controls.Add(this.txtNomeCli);
            this.grpCadUsr.Controls.Add(this.label1);
            this.grpCadUsr.Location = new System.Drawing.Point(0, 617);
            this.grpCadUsr.Name = "grpCadUsr";
            this.grpCadUsr.Size = new System.Drawing.Size(705, 110);
            this.grpCadUsr.TabIndex = 21;
            this.grpCadUsr.TabStop = false;
            this.grpCadUsr.Text = "Cadastro de novo cliente";
            this.grpCadUsr.Visible = false;
            // 
            // btnCancelCli
            // 
            this.btnCancelCli.AutoSize = true;
            this.btnCancelCli.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelCli.ForeColor = System.Drawing.Color.Red;
            this.btnCancelCli.Location = new System.Drawing.Point(444, 68);
            this.btnCancelCli.Name = "btnCancelCli";
            this.btnCancelCli.Size = new System.Drawing.Size(124, 33);
            this.btnCancelCli.TabIndex = 13;
            this.btnCancelCli.Text = "Cancelar";
            this.btnCancelCli.UseVisualStyleBackColor = true;
            this.btnCancelCli.Click += new System.EventHandler(this.btnCancelUser_Click);
            // 
            // btnLimpaCli
            // 
            this.btnLimpaCli.AutoSize = true;
            this.btnLimpaCli.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpaCli.ForeColor = System.Drawing.Color.Red;
            this.btnLimpaCli.Location = new System.Drawing.Point(282, 68);
            this.btnLimpaCli.Name = "btnLimpaCli";
            this.btnLimpaCli.Size = new System.Drawing.Size(124, 33);
            this.btnLimpaCli.TabIndex = 11;
            this.btnLimpaCli.Text = "Limpar Campos";
            this.btnLimpaCli.UseVisualStyleBackColor = true;
            // 
            // btnCadUser
            // 
            this.btnCadUser.AutoSize = true;
            this.btnCadUser.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadUser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadUser.Location = new System.Drawing.Point(133, 67);
            this.btnCadUser.Name = "btnCadUser";
            this.btnCadUser.Size = new System.Drawing.Size(101, 33);
            this.btnCadUser.TabIndex = 10;
            this.btnCadUser.Text = "Cadastrar";
            this.btnCadUser.UseVisualStyleBackColor = true;
            // 
            // txtTelUser
            // 
            this.txtTelUser.Location = new System.Drawing.Point(513, 27);
            this.txtTelUser.MaxLength = 60;
            this.txtTelUser.Name = "txtTelUser";
            this.txtTelUser.Size = new System.Drawing.Size(188, 23);
            this.txtTelUser.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone:";
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Location = new System.Drawing.Point(55, 27);
            this.txtNomeCli.MaxLength = 60;
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(392, 23);
            this.txtNomeCli.TabIndex = 2;
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
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 729);
            this.Controls.Add(this.btnCadastrarCli);
            this.Controls.Add(this.btnEditarCli);
            this.Controls.Add(this.btnExcluiUser);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpCadUsr);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUsuarios_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.grpCadUsr.ResumeLayout(false);
            this.grpCadUsr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCadastrarCli;
        private Button btnEditarCli;
        private Button btnExcluiUser;
        private Button btnLimpar;
        private Label lblStatus;
        private DataGridView dgvClientes;
        private TextBox txtPesquisa;
        private Label label6;
        private GroupBox grpCadUsr;
        private Button btnCancelCli;
        private Button btnLimpaCli;
        private Button btnCadUser;
        private TextBox txtTelUser;
        private Label label2;
        private TextBox txtNomeCli;
        private Label label1;
    }
}