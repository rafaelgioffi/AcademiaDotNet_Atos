namespace MiniERP
{
    partial class frmMiniErp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMiniErp));
            this.btnProd = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnForn = new System.Windows.Forms.Button();
            this.btnCli = new System.Windows.Forms.Button();
            this.btnNot = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProd
            // 
            this.btnProd.AutoSize = true;
            this.btnProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProd.ForeColor = System.Drawing.Color.Brown;
            this.btnProd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProd.ImageIndex = 0;
            this.btnProd.ImageList = this.imageList1;
            this.btnProd.Location = new System.Drawing.Point(0, 0);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(117, 91);
            this.btnProd.TabIndex = 0;
            this.btnProd.Text = "Produtos";
            this.btnProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "produtos.png");
            this.imageList1.Images.SetKeyName(1, "fornecedores.png");
            this.imageList1.Images.SetKeyName(2, "usuarios.png");
            this.imageList1.Images.SetKeyName(3, "notas.png");
            // 
            // btnForn
            // 
            this.btnForn.AutoSize = true;
            this.btnForn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnForn.ForeColor = System.Drawing.Color.Brown;
            this.btnForn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnForn.ImageIndex = 1;
            this.btnForn.ImageList = this.imageList1;
            this.btnForn.Location = new System.Drawing.Point(123, 0);
            this.btnForn.Name = "btnForn";
            this.btnForn.Size = new System.Drawing.Size(122, 91);
            this.btnForn.TabIndex = 1;
            this.btnForn.Text = "Fornecedores";
            this.btnForn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnForn.UseVisualStyleBackColor = true;
            this.btnForn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCli
            // 
            this.btnCli.AutoSize = true;
            this.btnCli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCli.ForeColor = System.Drawing.Color.Brown;
            this.btnCli.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCli.ImageIndex = 2;
            this.btnCli.ImageList = this.imageList1;
            this.btnCli.Location = new System.Drawing.Point(261, 0);
            this.btnCli.Name = "btnCli";
            this.btnCli.Size = new System.Drawing.Size(122, 91);
            this.btnCli.TabIndex = 2;
            this.btnCli.Text = "Clientes";
            this.btnCli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCli.UseVisualStyleBackColor = true;
            this.btnCli.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNot
            // 
            this.btnNot.AutoSize = true;
            this.btnNot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNot.ForeColor = System.Drawing.Color.Brown;
            this.btnNot.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNot.ImageIndex = 3;
            this.btnNot.ImageList = this.imageList1;
            this.btnNot.Location = new System.Drawing.Point(389, 0);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(122, 91);
            this.btnNot.TabIndex = 3;
            this.btnNot.Text = "Notas Fiscais";
            this.btnNot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNot.UseVisualStyleBackColor = true;
            this.btnNot.Click += new System.EventHandler(this.button4_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusBar});
            this.statusBar.Location = new System.Drawing.Point(0, 94);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(518, 22);
            this.statusBar.TabIndex = 4;
            this.statusBar.Text = "statusStrip1";
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.AutoSize = false;
            this.lblStatusBar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(490, 17);
            // 
            // frmMiniErp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 116);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.btnNot);
            this.Controls.Add(this.btnCli);
            this.Controls.Add(this.btnForn);
            this.Controls.Add(this.btnProd);
            this.MaximizeBox = false;
            this.Name = "frmMiniErp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Mini ERP - Atos/UFN ::..";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMiniErp_FormClosed);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnProd;
        private ImageList imageList1;
        private Button btnForn;
        private Button btnCli;
        private Button btnNot;
        private StatusStrip statusBar;
        private ToolStripStatusLabel lblStatusBar;
    }
}