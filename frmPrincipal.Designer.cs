namespace Sistema_Locadora
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            ts_Principal = new ToolStrip();
            tsbtn_Clientes = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbtn_Filmes = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbtn_Locacao = new ToolStripButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ts_Principal.SuspendLayout();
            SuspendLayout();
            // 
            // ts_Principal
            // 
            ts_Principal.BackColor = SystemColors.ButtonHighlight;
            ts_Principal.ImageScalingSize = new Size(50, 50);
            ts_Principal.Items.AddRange(new ToolStripItem[] { tsbtn_Clientes, toolStripSeparator1, tsbtn_Filmes, toolStripSeparator2, tsbtn_Locacao });
            ts_Principal.Location = new Point(0, 0);
            ts_Principal.Name = "ts_Principal";
            ts_Principal.Size = new Size(967, 77);
            ts_Principal.TabIndex = 0;
            ts_Principal.Text = "toolStrip1";
            // 
            // tsbtn_Clientes
            // 
            tsbtn_Clientes.Image = (Image)resources.GetObject("tsbtn_Clientes.Image");
            tsbtn_Clientes.ImageTransparentColor = Color.Magenta;
            tsbtn_Clientes.Name = "tsbtn_Clientes";
            tsbtn_Clientes.Size = new Size(84, 74);
            tsbtn_Clientes.Text = "Clientes";
            tsbtn_Clientes.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbtn_Clientes.Click += tsbtn_Clientes_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 77);
            // 
            // tsbtn_Filmes
            // 
            tsbtn_Filmes.Image = (Image)resources.GetObject("tsbtn_Filmes.Image");
            tsbtn_Filmes.ImageTransparentColor = Color.Magenta;
            tsbtn_Filmes.Name = "tsbtn_Filmes";
            tsbtn_Filmes.Size = new Size(84, 74);
            tsbtn_Filmes.Text = "Filmes";
            tsbtn_Filmes.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbtn_Filmes.Click += tsbtn_Filmes_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 77);
            // 
            // tsbtn_Locacao
            // 
            tsbtn_Locacao.Image = (Image)resources.GetObject("tsbtn_Locacao.Image");
            tsbtn_Locacao.ImageTransparentColor = Color.Magenta;
            tsbtn_Locacao.Name = "tsbtn_Locacao";
            tsbtn_Locacao.Size = new Size(84, 74);
            tsbtn_Locacao.Text = "Locações";
            tsbtn_Locacao.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbtn_Locacao.Click += tsbtn_Locacao_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(967, 621);
            Controls.Add(ts_Principal);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Locadora";
            ts_Principal.ResumeLayout(false);
            ts_Principal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ts_Principal;
        private ToolStripButton tsbtn_Clientes;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbtn_Filmes;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbtn_Locacao;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
