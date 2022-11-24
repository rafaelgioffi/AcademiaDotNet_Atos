namespace MiniERP
{
    partial class frmEditForn
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
            this.txtFornId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEdtCancelForn = new System.Windows.Forms.Button();
            this.btnEdtForn = new System.Windows.Forms.Button();
            this.txtCnpjForn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeForn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFornId
            // 
            this.txtFornId.Location = new System.Drawing.Point(629, 15);
            this.txtFornId.MaxLength = 60;
            this.txtFornId.Name = "txtFornId";
            this.txtFornId.ReadOnly = true;
            this.txtFornId.Size = new System.Drawing.Size(62, 23);
            this.txtFornId.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "ID:";
            // 
            // btnEdtCancelForn
            // 
            this.btnEdtCancelForn.AutoSize = true;
            this.btnEdtCancelForn.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdtCancelForn.ForeColor = System.Drawing.Color.Red;
            this.btnEdtCancelForn.Location = new System.Drawing.Point(336, 156);
            this.btnEdtCancelForn.Name = "btnEdtCancelForn";
            this.btnEdtCancelForn.Size = new System.Drawing.Size(124, 33);
            this.btnEdtCancelForn.TabIndex = 42;
            this.btnEdtCancelForn.Text = "Cancelar";
            this.btnEdtCancelForn.UseVisualStyleBackColor = true;
            this.btnEdtCancelForn.Click += new System.EventHandler(this.btnEdtCancelForn_Click);
            // 
            // btnEdtForn
            // 
            this.btnEdtForn.AutoSize = true;
            this.btnEdtForn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdtForn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEdtForn.Location = new System.Drawing.Point(195, 156);
            this.btnEdtForn.Name = "btnEdtForn";
            this.btnEdtForn.Size = new System.Drawing.Size(101, 33);
            this.btnEdtForn.TabIndex = 40;
            this.btnEdtForn.Text = "Salvar";
            this.btnEdtForn.UseVisualStyleBackColor = true;
            this.btnEdtForn.Click += new System.EventHandler(this.btnEdtForn_Click);
            // 
            // txtCnpjForn
            // 
            this.txtCnpjForn.Location = new System.Drawing.Point(67, 54);
            this.txtCnpjForn.MaxLength = 60;
            this.txtCnpjForn.Name = "txtCnpjForn";
            this.txtCnpjForn.ReadOnly = true;
            this.txtCnpjForn.Size = new System.Drawing.Size(248, 23);
            this.txtCnpjForn.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "CNPJ:";
            // 
            // txtNomeForn
            // 
            this.txtNomeForn.Location = new System.Drawing.Point(67, 12);
            this.txtNomeForn.MaxLength = 60;
            this.txtNomeForn.Name = "txtNomeForn";
            this.txtNomeForn.Size = new System.Drawing.Size(467, 23);
            this.txtNomeForn.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nome:";
            // 
            // frmEditForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 201);
            this.Controls.Add(this.txtFornId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEdtCancelForn);
            this.Controls.Add(this.btnEdtForn);
            this.Controls.Add(this.txtCnpjForn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeForn);
            this.Controls.Add(this.label1);
            this.Name = "frmEditForn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar fornecedor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditForn_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox txtFornId;
        private Label label7;
        private Button btnEdtCancelForn;
        private Button btnEdtForn;
        public TextBox txtCnpjForn;
        private Label label4;
        public TextBox txtNomeForn;
        private Label label1;
    }
}