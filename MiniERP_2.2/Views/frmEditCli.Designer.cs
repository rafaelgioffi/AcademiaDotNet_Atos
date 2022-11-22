namespace MiniERP.Views
{
    partial class frmEditCli
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
            this.txtCliId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEdtCancelCli = new System.Windows.Forms.Button();
            this.btnEdtCli = new System.Windows.Forms.Button();
            this.txtTelCli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCliId
            // 
            this.txtCliId.Location = new System.Drawing.Point(630, 6);
            this.txtCliId.MaxLength = 60;
            this.txtCliId.Name = "txtCliId";
            this.txtCliId.ReadOnly = true;
            this.txtCliId.Size = new System.Drawing.Size(62, 23);
            this.txtCliId.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(603, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 51;
            this.label7.Text = "ID:";
            // 
            // btnEdtCancelCli
            // 
            this.btnEdtCancelCli.AutoSize = true;
            this.btnEdtCancelCli.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdtCancelCli.ForeColor = System.Drawing.Color.Red;
            this.btnEdtCancelCli.Location = new System.Drawing.Point(328, 150);
            this.btnEdtCancelCli.Name = "btnEdtCancelCli";
            this.btnEdtCancelCli.Size = new System.Drawing.Size(124, 33);
            this.btnEdtCancelCli.TabIndex = 50;
            this.btnEdtCancelCli.Text = "Cancelar";
            this.btnEdtCancelCli.UseVisualStyleBackColor = true;
            this.btnEdtCancelCli.Click += new System.EventHandler(this.btnEdtCancelCli_Click);
            // 
            // btnEdtCli
            // 
            this.btnEdtCli.AutoSize = true;
            this.btnEdtCli.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdtCli.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEdtCli.Location = new System.Drawing.Point(187, 150);
            this.btnEdtCli.Name = "btnEdtCli";
            this.btnEdtCli.Size = new System.Drawing.Size(101, 33);
            this.btnEdtCli.TabIndex = 49;
            this.btnEdtCli.Text = "Salvar";
            this.btnEdtCli.UseVisualStyleBackColor = true;
            this.btnEdtCli.Click += new System.EventHandler(this.btnEdtCli_Click);
            // 
            // txtTelCli
            // 
            this.txtTelCli.Location = new System.Drawing.Point(59, 48);
            this.txtTelCli.MaxLength = 60;
            this.txtTelCli.Name = "txtTelCli";
            this.txtTelCli.Size = new System.Drawing.Size(248, 23);
            this.txtTelCli.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Telefone:";
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Location = new System.Drawing.Point(59, 6);
            this.txtNomeCli.MaxLength = 60;
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(467, 23);
            this.txtNomeCli.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nome:";
            // 
            // frmEditCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 201);
            this.Controls.Add(this.txtCliId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEdtCancelCli);
            this.Controls.Add(this.btnEdtCli);
            this.Controls.Add(this.txtTelCli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeCli);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditCli_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox txtCliId;
        private Label label7;
        private Button btnEdtCancelCli;
        private Button btnEdtCli;
        public TextBox txtTelCli;
        private Label label4;
        public TextBox txtNomeCli;
        private Label label1;
    }
}