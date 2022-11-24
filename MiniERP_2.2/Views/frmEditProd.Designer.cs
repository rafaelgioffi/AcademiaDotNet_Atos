namespace MiniERP
{
    partial class frmEditProd
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
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtQuantProd = new System.Windows.Forms.NumericUpDown();
            this.btnEdtProd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdForn = new System.Windows.Forms.NumericUpDown();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescProd = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdForn)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProdId
            // 
            this.txtProdId.Location = new System.Drawing.Point(628, 15);
            this.txtProdId.MaxLength = 60;
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.ReadOnly = true;
            this.txtProdId.Size = new System.Drawing.Size(62, 23);
            this.txtProdId.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(601, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "ID:";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(335, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 33);
            this.button2.TabIndex = 28;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtQuantProd
            // 
            this.txtQuantProd.Location = new System.Drawing.Point(628, 127);
            this.txtQuantProd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtQuantProd.Name = "txtQuantProd";
            this.txtQuantProd.Size = new System.Drawing.Size(58, 23);
            this.txtQuantProd.TabIndex = 27;
            this.txtQuantProd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEdtProd
            // 
            this.btnEdtProd.AutoSize = true;
            this.btnEdtProd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdtProd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEdtProd.Location = new System.Drawing.Point(194, 156);
            this.btnEdtProd.Name = "btnEdtProd";
            this.btnEdtProd.Size = new System.Drawing.Size(101, 33);
            this.btnEdtProd.TabIndex = 25;
            this.btnEdtProd.Text = "Salvar";
            this.btnEdtProd.UseVisualStyleBackColor = true;
            this.btnEdtProd.Click += new System.EventHandler(this.btnEdtProd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Quantidade:";
            // 
            // txtValProd
            // 
            this.txtValProd.Location = new System.Drawing.Point(628, 89);
            this.txtValProd.MaxLength = 60;
            this.txtValProd.Name = "txtValProd";
            this.txtValProd.Size = new System.Drawing.Size(73, 23);
            this.txtValProd.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fornecedor:";
            // 
            // txtIdForn
            // 
            this.txtIdForn.Enabled = false;
            this.txtIdForn.Location = new System.Drawing.Point(628, 51);
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
            this.txtIdForn.ReadOnly = true;
            this.txtIdForn.Size = new System.Drawing.Size(58, 23);
            this.txtIdForn.TabIndex = 19;
            this.txtIdForn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(66, 12);
            this.txtNomeProd.MaxLength = 60;
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.ReadOnly = true;
            this.txtNomeProd.Size = new System.Drawing.Size(467, 23);
            this.txtNomeProd.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome:";
            // 
            // txtDescProd
            // 
            this.txtDescProd.Location = new System.Drawing.Point(66, 53);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.Size = new System.Drawing.Size(467, 97);
            this.txtDescProd.TabIndex = 17;
            this.txtDescProd.Text = "";
            // 
            // frmEditProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 201);
            this.Controls.Add(this.txtProdId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtQuantProd);
            this.Controls.Add(this.btnEdtProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdForn);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescProd);
            this.Name = "frmEditProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar produto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditProd_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdForn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label7;
        private Button button2;
        private Button btnEdtProd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox txtProdId;
        public NumericUpDown txtQuantProd;
        public TextBox txtValProd;
        public NumericUpDown txtIdForn;
        public TextBox txtNomeProd;
        public RichTextBox txtDescProd;
    }
}