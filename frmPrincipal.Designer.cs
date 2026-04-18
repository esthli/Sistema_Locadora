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
            toolStrip1 = new ToolStrip();
            tsbtn_Clientes = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbtn_Filmes = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ButtonHighlight;
            toolStrip1.ImageScalingSize = new Size(50, 50);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtn_Clientes, toolStripSeparator1, tsbtn_Filmes, toolStripSeparator2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(896, 77);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_Clientes
            // 
            tsbtn_Clientes.Image = (Image)resources.GetObject("tsbtn_Clientes.Image");
            tsbtn_Clientes.ImageTransparentColor = Color.Magenta;
            tsbtn_Clientes.Name = "tsbtn_Clientes";
            tsbtn_Clientes.Size = new Size(65, 74);
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
            tsbtn_Filmes.Size = new Size(55, 74);
            tsbtn_Filmes.Text = "Filmes";
            tsbtn_Filmes.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbtn_Filmes.Click += tsbtn_Filmes_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 77);
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(74, 74);
            toolStripButton3.Text = "Locações";
            toolStripButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 747);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Locadora";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbtn_Clientes;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbtn_Filmes;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
