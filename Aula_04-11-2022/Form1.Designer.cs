namespace Aula_04_11_2022
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtLimpar = new System.Windows.Forms.Button();
            this.txtNomes = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do jogador:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(111, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(198, 23);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Para Maiúsculo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtLimpar
            // 
            this.txtLimpar.Location = new System.Drawing.Point(545, 4);
            this.txtLimpar.Name = "txtLimpar";
            this.txtLimpar.Size = new System.Drawing.Size(75, 23);
            this.txtLimpar.TabIndex = 3;
            this.txtLimpar.Text = "Limpar";
            this.txtLimpar.UseVisualStyleBackColor = true;
            this.txtLimpar.Click += new System.EventHandler(this.txtLimpar_Click);
            // 
            // txtNomes
            // 
            this.txtNomes.Location = new System.Drawing.Point(3, 34);
            this.txtNomes.Multiline = true;
            this.txtNomes.Name = "txtNomes";
            this.txtNomes.ReadOnly = true;
            this.txtNomes.Size = new System.Drawing.Size(617, 380);
            this.txtNomes.TabIndex = 4;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(440, 4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(99, 23);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir Nome";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Location = new System.Drawing.Point(3, 417);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(617, 15);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Total: 0";
            this.lblQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtNomes);
            this.Controls.Add(this.txtLimpar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formulario Desktop Windows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Button button1;
        private Button txtLimpar;
        private TextBox txtNomes;
        private Button btnInserir;
        private Label lblQuantidade;
    }
}