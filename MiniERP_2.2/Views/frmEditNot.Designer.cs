namespace MiniERP.Views
{
    partial class frmEditNot
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInfoNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdNot = new System.Windows.Forms.TextBox();
            this.btnCancelNot = new System.Windows.Forms.Button();
            this.btnEdtNot = new System.Windows.Forms.Button();
            this.txtIdCli = new System.Windows.Forms.TextBox();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.rdCompra = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rdVenda = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID do Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID do Cliente:";
            // 
            // txtInfoNota
            // 
            this.txtInfoNota.Location = new System.Drawing.Point(85, 6);
            this.txtInfoNota.MaxLength = 60;
            this.txtInfoNota.Name = "txtInfoNota";
            this.txtInfoNota.Size = new System.Drawing.Size(460, 23);
            this.txtInfoNota.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Observações:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "ID:";
            // 
            // txtIdNot
            // 
            this.txtIdNot.Location = new System.Drawing.Point(584, 6);
            this.txtIdNot.MaxLength = 60;
            this.txtIdNot.Name = "txtIdNot";
            this.txtIdNot.ReadOnly = true;
            this.txtIdNot.Size = new System.Drawing.Size(116, 23);
            this.txtIdNot.TabIndex = 25;
            // 
            // btnCancelNot
            // 
            this.btnCancelNot.AutoSize = true;
            this.btnCancelNot.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelNot.ForeColor = System.Drawing.Color.Red;
            this.btnCancelNot.Location = new System.Drawing.Point(328, 150);
            this.btnCancelNot.Name = "btnCancelNot";
            this.btnCancelNot.Size = new System.Drawing.Size(124, 33);
            this.btnCancelNot.TabIndex = 28;
            this.btnCancelNot.Text = "Cancelar";
            this.btnCancelNot.UseVisualStyleBackColor = true;
            this.btnCancelNot.Click += new System.EventHandler(this.btnCancelNot_Click);
            // 
            // btnEdtNot
            // 
            this.btnEdtNot.AutoSize = true;
            this.btnEdtNot.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdtNot.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEdtNot.Location = new System.Drawing.Point(187, 150);
            this.btnEdtNot.Name = "btnEdtNot";
            this.btnEdtNot.Size = new System.Drawing.Size(101, 33);
            this.btnEdtNot.TabIndex = 26;
            this.btnEdtNot.Text = "Salvar";
            this.btnEdtNot.UseVisualStyleBackColor = true;
            this.btnEdtNot.Click += new System.EventHandler(this.btnEdtNot_Click);
            // 
            // txtIdCli
            // 
            this.txtIdCli.Location = new System.Drawing.Point(381, 43);
            this.txtIdCli.MaxLength = 60;
            this.txtIdCli.Name = "txtIdCli";
            this.txtIdCli.ReadOnly = true;
            this.txtIdCli.Size = new System.Drawing.Size(97, 23);
            this.txtIdCli.TabIndex = 29;
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(584, 48);
            this.txtIdProd.MaxLength = 60;
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.ReadOnly = true;
            this.txtIdProd.Size = new System.Drawing.Size(116, 23);
            this.txtIdProd.TabIndex = 30;
            // 
            // rdCompra
            // 
            this.rdCompra.AutoSize = true;
            this.rdCompra.Enabled = false;
            this.rdCompra.Location = new System.Drawing.Point(85, 44);
            this.rdCompra.Name = "rdCompra";
            this.rdCompra.Size = new System.Drawing.Size(68, 19);
            this.rdCompra.TabIndex = 33;
            this.rdCompra.TabStop = true;
            this.rdCompra.Text = "Compra";
            this.rdCompra.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tipo:";
            // 
            // rdVenda
            // 
            this.rdVenda.AutoSize = true;
            this.rdVenda.Enabled = false;
            this.rdVenda.Location = new System.Drawing.Point(162, 44);
            this.rdVenda.Name = "rdVenda";
            this.rdVenda.Size = new System.Drawing.Size(57, 19);
            this.rdVenda.TabIndex = 31;
            this.rdVenda.TabStop = true;
            this.rdVenda.Text = "Venda";
            this.rdVenda.UseVisualStyleBackColor = true;
            // 
            // frmEditNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 201);
            this.Controls.Add(this.rdCompra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdVenda);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.txtIdCli);
            this.Controls.Add(this.btnCancelNot);
            this.Controls.Add(this.btnEdtNot);
            this.Controls.Add(this.txtIdNot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInfoNota);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditNot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar nota";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditNot_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button btnCancelNot;
        private Button btnEdtNot;
        public TextBox txtInfoNota;
        public TextBox txtIdNot;
        public TextBox txtIdCli;
        public TextBox txtIdProd;
        private Label label5;
        public RadioButton rdCompra;
        public RadioButton rdVenda;
    }
}