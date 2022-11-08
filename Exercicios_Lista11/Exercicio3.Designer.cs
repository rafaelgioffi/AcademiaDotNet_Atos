namespace Exercicios_Lista11
{
    partial class frmEx3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCriptos = new System.Windows.Forms.ListView();
            this.clnNome = new System.Windows.Forms.ColumnHeader();
            this.clnSigla = new System.Windows.Forms.ColumnHeader();
            this.clnPreco = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBusca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.stsInfo = new System.Windows.Forms.StatusStrip();
            this.lblQuant = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.stsInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSigla);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lstCriptos);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 358);
            this.panel1.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(58, 54);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(81, 23);
            this.txtValor.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor:";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(302, 27);
            this.txtSigla.MaxLength = 3;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(118, 23);
            this.txtSigla.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sigla:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(176, 23);
            this.txtNome.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome: ";
            // 
            // lstCriptos
            // 
            this.lstCriptos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnNome,
            this.clnSigla,
            this.clnPreco});
            this.lstCriptos.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstCriptos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstCriptos.FullRowSelect = true;
            this.lstCriptos.GridLines = true;
            this.lstCriptos.LabelWrap = false;
            this.lstCriptos.Location = new System.Drawing.Point(6, 127);
            this.lstCriptos.Name = "lstCriptos";
            this.lstCriptos.Size = new System.Drawing.Size(414, 218);
            this.lstCriptos.TabIndex = 2;
            this.lstCriptos.UseCompatibleStateImageBehavior = false;
            this.lstCriptos.View = System.Windows.Forms.View.Details;
            this.lstCriptos.SelectedIndexChanged += new System.EventHandler(this.lstCriptos_SelectedIndexChanged);
            // 
            // clnNome
            // 
            this.clnNome.Text = "Nome";
            this.clnNome.Width = 175;
            // 
            // clnSigla
            // 
            this.clnSigla.Text = "Sigla";
            // 
            // clnPreco
            // 
            this.clnPreco.Text = "Preço";
            this.clnPreco.Width = 170;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnCadastro, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 90);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 31);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCadastro
            // 
            this.btnCadastro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCadastro.Location = new System.Drawing.Point(3, 3);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(133, 25);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Listar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(283, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(134, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro,
            this.menuBusca,
            this.menuRemove});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastro
            // 
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(142, 20);
            this.menuCadastro.Text = "Cadastrar Criptomoeda";
            this.menuCadastro.Click += new System.EventHandler(this.menuCadastro_Click);
            // 
            // menuBusca
            // 
            this.menuBusca.Name = "menuBusca";
            this.menuBusca.Size = new System.Drawing.Size(120, 20);
            this.menuBusca.Text = "Listar Criptomoeda";
            // 
            // menuRemove
            // 
            this.menuRemove.ForeColor = System.Drawing.Color.Red;
            this.menuRemove.Name = "menuRemove";
            this.menuRemove.Size = new System.Drawing.Size(139, 20);
            this.menuRemove.Text = "Remover Criptomoeda";
            this.menuRemove.Click += new System.EventHandler(this.menuRemove_Click);
            // 
            // stsInfo
            // 
            this.stsInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblQuant,
            this.lblInfo});
            this.stsInfo.Location = new System.Drawing.Point(0, 354);
            this.stsInfo.Name = "stsInfo";
            this.stsInfo.Size = new System.Drawing.Size(438, 22);
            this.stsInfo.TabIndex = 1;
            // 
            // lblQuant
            // 
            this.lblQuant.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(161, 17);
            this.lblQuant.Text = "Criptomoedas Cadastradas: 0";
            // 
            // lblInfo
            // 
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmEx3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 376);
            this.Controls.Add(this.stsInfo);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEx3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercicio3";
            this.Activated += new System.EventHandler(this.frmEx3_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEx3_FormClosed);
            this.Load += new System.EventHandler(this.frmEx3_Load);
            this.Leave += new System.EventHandler(this.frmEx3_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.stsInfo.ResumeLayout(false);
            this.stsInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnCadastro;
        private Button button2;
        private Button btnRemove;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuCadastro;
        private ToolStripMenuItem menuBusca;
        private ToolStripMenuItem menuRemove;
        private ListView lstCriptos;
        private TextBox txtValor;
        private Label label3;
        private TextBox txtSigla;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private ColumnHeader clnNome;
        private ColumnHeader clnSigla;
        private ColumnHeader clnPreco;
        private StatusStrip stsInfo;
        private ToolStripStatusLabel lblQuant;
        private ToolStripStatusLabel lblInfo;
    }
}