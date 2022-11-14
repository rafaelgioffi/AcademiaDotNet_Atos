namespace WF_Glicemia_BD
{
    partial class frmPacientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPac = new System.Windows.Forms.ListView();
            this.idPaciente = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnConectPac = new System.Windows.Forms.Button();
            this.btnCadPac = new System.Windows.Forms.Button();
            this.btnExcluiPac = new System.Windows.Forms.Button();
            this.btnEditPac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPac = new System.Windows.Forms.TextBox();
            this.txtNomePac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMailPac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQuantPacs = new System.Windows.Forms.Label();
            this.panCadPac = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSalvaPac = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panCadPac.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPac
            // 
            this.lstPac.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idPaciente,
            this.columnHeader2,
            this.columnHeader3});
            this.lstPac.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstPac.FullRowSelect = true;
            this.lstPac.GridLines = true;
            this.lstPac.Location = new System.Drawing.Point(0, 0);
            this.lstPac.MultiSelect = false;
            this.lstPac.Name = "lstPac";
            this.lstPac.Size = new System.Drawing.Size(624, 310);
            this.lstPac.TabIndex = 0;
            this.lstPac.UseCompatibleStateImageBehavior = false;
            this.lstPac.View = System.Windows.Forms.View.Details;
            this.lstPac.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstPac_ItemSelectionChanged);
            // 
            // idPaciente
            // 
            this.idPaciente.Text = "ID Paciente";
            this.idPaciente.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 270;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "E-Mail";
            this.columnHeader3.Width = 260;
            // 
            // btnConectPac
            // 
            this.btnConectPac.AutoSize = true;
            this.btnConectPac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConectPac.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnConectPac.Location = new System.Drawing.Point(0, 316);
            this.btnConectPac.Name = "btnConectPac";
            this.btnConectPac.Size = new System.Drawing.Size(142, 40);
            this.btnConectPac.TabIndex = 1;
            this.btnConectPac.Text = "Atualizar Lista";
            this.btnConectPac.UseVisualStyleBackColor = true;
            this.btnConectPac.Click += new System.EventHandler(this.btnConectPac_Click);
            // 
            // btnCadPac
            // 
            this.btnCadPac.AutoSize = true;
            this.btnCadPac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadPac.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadPac.Location = new System.Drawing.Point(147, 317);
            this.btnCadPac.Name = "btnCadPac";
            this.btnCadPac.Size = new System.Drawing.Size(155, 40);
            this.btnCadPac.TabIndex = 2;
            this.btnCadPac.Text = "Cadastrar Paciente";
            this.btnCadPac.UseVisualStyleBackColor = true;
            this.btnCadPac.Click += new System.EventHandler(this.btnCadPac_Click);
            // 
            // btnExcluiPac
            // 
            this.btnExcluiPac.AutoSize = true;
            this.btnExcluiPac.Enabled = false;
            this.btnExcluiPac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluiPac.ForeColor = System.Drawing.Color.Red;
            this.btnExcluiPac.Location = new System.Drawing.Point(308, 316);
            this.btnExcluiPac.Name = "btnExcluiPac";
            this.btnExcluiPac.Size = new System.Drawing.Size(155, 40);
            this.btnExcluiPac.TabIndex = 3;
            this.btnExcluiPac.Text = "Excluir Paciente";
            this.btnExcluiPac.UseVisualStyleBackColor = true;
            this.btnExcluiPac.Click += new System.EventHandler(this.btnExcluiPac_Click);
            // 
            // btnEditPac
            // 
            this.btnEditPac.AutoSize = true;
            this.btnEditPac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditPac.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditPac.Location = new System.Drawing.Point(469, 316);
            this.btnEditPac.Name = "btnEditPac";
            this.btnEditPac.Size = new System.Drawing.Size(155, 40);
            this.btnEditPac.TabIndex = 4;
            this.btnEditPac.Text = "Editar Paciente";
            this.btnEditPac.UseVisualStyleBackColor = true;
            this.btnEditPac.Click += new System.EventHandler(this.btnEditPac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Paciente";
            // 
            // txtIdPac
            // 
            this.txtIdPac.Enabled = false;
            this.txtIdPac.Location = new System.Drawing.Point(75, 7);
            this.txtIdPac.Name = "txtIdPac";
            this.txtIdPac.ReadOnly = true;
            this.txtIdPac.Size = new System.Drawing.Size(58, 23);
            this.txtIdPac.TabIndex = 6;
            // 
            // txtNomePac
            // 
            this.txtNomePac.Location = new System.Drawing.Point(75, 45);
            this.txtNomePac.Name = "txtNomePac";
            this.txtNomePac.Size = new System.Drawing.Size(528, 23);
            this.txtNomePac.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // txtMailPac
            // 
            this.txtMailPac.Location = new System.Drawing.Point(75, 86);
            this.txtMailPac.Name = "txtMailPac";
            this.txtMailPac.Size = new System.Drawing.Size(528, 23);
            this.txtMailPac.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "E-Mail";
            // 
            // lblQuantPacs
            // 
            this.lblQuantPacs.Location = new System.Drawing.Point(469, 526);
            this.lblQuantPacs.Name = "lblQuantPacs";
            this.lblQuantPacs.Size = new System.Drawing.Size(155, 17);
            this.lblQuantPacs.TabIndex = 11;
            this.lblQuantPacs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panCadPac
            // 
            this.panCadPac.Controls.Add(this.btnCancel);
            this.panCadPac.Controls.Add(this.btnSalvaPac);
            this.panCadPac.Controls.Add(this.label1);
            this.panCadPac.Controls.Add(this.txtIdPac);
            this.panCadPac.Controls.Add(this.txtMailPac);
            this.panCadPac.Controls.Add(this.label2);
            this.panCadPac.Controls.Add(this.label3);
            this.panCadPac.Controls.Add(this.txtNomePac);
            this.panCadPac.Enabled = false;
            this.panCadPac.Location = new System.Drawing.Point(0, 370);
            this.panCadPac.Name = "panCadPac";
            this.panCadPac.Size = new System.Drawing.Size(624, 153);
            this.panCadPac.TabIndex = 12;
            this.panCadPac.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(360, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 31);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancelar Cadastro";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalvaPac
            // 
            this.btnSalvaPac.AutoSize = true;
            this.btnSalvaPac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvaPac.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvaPac.Location = new System.Drawing.Point(147, 115);
            this.btnSalvaPac.Name = "btnSalvaPac";
            this.btnSalvaPac.Size = new System.Drawing.Size(190, 31);
            this.btnSalvaPac.TabIndex = 11;
            this.btnSalvaPac.Text = "Cadastrar Novo Paciente";
            this.btnSalvaPac.UseVisualStyleBackColor = true;
            this.btnSalvaPac.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(3, 526);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(460, 17);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 541);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panCadPac);
            this.Controls.Add(this.lblQuantPacs);
            this.Controls.Add(this.btnEditPac);
            this.Controls.Add(this.btnExcluiPac);
            this.Controls.Add(this.btnCadPac);
            this.Controls.Add(this.btnConectPac);
            this.Controls.Add(this.lstPac);
            this.Name = "frmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: Sistema de Cadastro de Pacientes ::.";
            this.panCadPac.ResumeLayout(false);
            this.panCadPac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lstPac;
        private ColumnHeader idPaciente;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnConectPac;
        private Button btnCadPac;
        private Button btnExcluiPac;
        private Button btnEditPac;
        private Label label1;
        private TextBox txtIdPac;
        private TextBox txtNomePac;
        private Label label2;
        private TextBox txtMailPac;
        private Label label3;
        private Label lblQuantPacs;
        private Panel panCadPac;
        private Button btnCancel;
        private Button btnSalvaPac;
        private Label lblStatus;
    }
}