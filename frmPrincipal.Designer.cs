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
            label3 = new Label();
            label1 = new Label();
            ts_Clientes = new ToolStrip();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripButton7 = new ToolStripButton();
            toolStripButton8 = new ToolStripButton();
            toolStripButton9 = new ToolStripButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            gb_Clientes = new GroupBox();
            gb_Filmes = new GroupBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            label16 = new Label();
            label18 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            toolStrip1.SuspendLayout();
            ts_Clientes.SuspendLayout();
            gb_Clientes.SuspendLayout();
            gb_Filmes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
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
            tsbtn_Filmes.Click += toolStripButton2_Click;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 69);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 8;
            label3.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 6;
            label1.Text = "Código";
            // 
            // ts_Clientes
            // 
            ts_Clientes.ImageScalingSize = new Size(20, 20);
            ts_Clientes.Items.AddRange(new ToolStripItem[] { toolStripSeparator3, toolStripButton1, toolStripButton4, toolStripSeparator4, toolStripTextBox1, toolStripLabel1, toolStripSeparator5, toolStripButton5, toolStripButton6, toolStripSeparator6, toolStripButton7, toolStripButton8, toolStripButton9 });
            ts_Clientes.Location = new Point(0, 77);
            ts_Clientes.Name = "ts_Clientes";
            ts_Clientes.Size = new Size(896, 27);
            ts_Clientes.TabIndex = 5;
            ts_Clientes.Text = "toolStrip2";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 24);
            toolStripButton4.Text = "toolStripButton2";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 27);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.ReadOnly = true;
            toolStripTextBox1.Size = new Size(100, 27);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(111, 24);
            toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 27);
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(29, 24);
            toolStripButton5.Text = "toolStripButton3";
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(29, 24);
            toolStripButton6.Text = "toolStripButton4";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 27);
            // 
            // toolStripButton7
            // 
            toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton7.Image = (Image)resources.GetObject("toolStripButton7.Image");
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(29, 24);
            toolStripButton7.Text = "toolStripButton5";
            // 
            // toolStripButton8
            // 
            toolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton8.Image = (Image)resources.GetObject("toolStripButton8.Image");
            toolStripButton8.ImageTransparentColor = Color.Magenta;
            toolStripButton8.Name = "toolStripButton8";
            toolStripButton8.Size = new Size(29, 24);
            toolStripButton8.Text = "toolStripButton6";
            // 
            // toolStripButton9
            // 
            toolStripButton9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton9.Image = (Image)resources.GetObject("toolStripButton9.Image");
            toolStripButton9.ImageTransparentColor = Color.Magenta;
            toolStripButton9.Name = "toolStripButton9";
            toolStripButton9.Size = new Size(29, 24);
            toolStripButton9.Text = "toolStripButton7";
            // 
            // gb_Clientes
            // 
            gb_Clientes.Controls.Add(gb_Filmes);
            gb_Clientes.Controls.Add(textBox7);
            gb_Clientes.Controls.Add(textBox6);
            gb_Clientes.Controls.Add(textBox5);
            gb_Clientes.Controls.Add(textBox3);
            gb_Clientes.Controls.Add(label9);
            gb_Clientes.Controls.Add(label8);
            gb_Clientes.Controls.Add(label7);
            gb_Clientes.Controls.Add(label6);
            gb_Clientes.Controls.Add(maskedTextBox2);
            gb_Clientes.Controls.Add(textBox4);
            gb_Clientes.Controls.Add(label5);
            gb_Clientes.Controls.Add(label4);
            gb_Clientes.Controls.Add(textBox2);
            gb_Clientes.Controls.Add(textBox1);
            gb_Clientes.Controls.Add(label1);
            gb_Clientes.Controls.Add(maskedTextBox1);
            gb_Clientes.Controls.Add(label2);
            gb_Clientes.Controls.Add(label3);
            gb_Clientes.Location = new Point(12, 107);
            gb_Clientes.Name = "gb_Clientes";
            gb_Clientes.Size = new Size(872, 331);
            gb_Clientes.TabIndex = 10;
            gb_Clientes.TabStop = false;
            // 
            // gb_Filmes
            // 
            gb_Filmes.Controls.Add(splitContainer1);
            gb_Filmes.Controls.Add(textBox13);
            gb_Filmes.Controls.Add(textBox14);
            gb_Filmes.Controls.Add(label16);
            gb_Filmes.Controls.Add(label18);
            gb_Filmes.Location = new Point(0, 10);
            gb_Filmes.Name = "gb_Filmes";
            gb_Filmes.Size = new Size(872, 331);
            gb_Filmes.TabIndex = 11;
            gb_Filmes.TabStop = false;
            gb_Filmes.Visible = false;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(105, 29);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(61, 27);
            textBox13.TabIndex = 11;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(105, 66);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(555, 27);
            textBox14.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(22, 32);
            label16.Name = "label16";
            label16.Size = new Size(58, 20);
            label16.TabIndex = 6;
            label16.Text = "Código";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(30, 69);
            label18.Name = "label18";
            label18.Size = new Size(45, 20);
            label18.TabIndex = 8;
            label18.Text = "Filme";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(717, 216);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 24;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(105, 249);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(555, 27);
            textBox6.TabIndex = 23;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(105, 213);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(555, 27);
            textBox5.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(105, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(555, 27);
            textBox3.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(666, 219);
            label9.Name = "label9";
            label9.Size = new Size(34, 20);
            label9.TabIndex = 20;
            label9.Text = "CEP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 252);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 19;
            label8.Text = "Cidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 216);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 18;
            label7.Text = "Bairro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 183);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 17;
            label6.Text = "Rua";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(409, 103);
            maskedTextBox2.Mask = "(99) 00000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 27);
            maskedTextBox2.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(105, 141);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(555, 27);
            textBox4.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 144);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 14;
            label5.Text = "Endereço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 106);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 13;
            label4.Text = "Telefone";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(61, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(555, 27);
            textBox1.TabIndex = 10;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(105, 103);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(182, 27);
            maskedTextBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 106);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 7;
            label2.Text = "CPF";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(204, 236);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Size = new Size(188, 125);
            splitContainer1.SplitterDistance = 62;
            splitContainer1.TabIndex = 12;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 747);
            Controls.Add(gb_Clientes);
            Controls.Add(ts_Clientes);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            Text = "Sistema Locadora";
            Load += frmPrincipal_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ts_Clientes.ResumeLayout(false);
            ts_Clientes.PerformLayout();
            gb_Clientes.ResumeLayout(false);
            gb_Clientes.PerformLayout();
            gb_Filmes.ResumeLayout(false);
            gb_Filmes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
        private Label label3;
        private Label label1;
        private ToolStrip ts_Clientes;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
        private ToolStripButton toolStripButton9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox gb_Clientes;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox3;
        private MaskedTextBox maskedTextBox2;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private GroupBox gb_Filmes;
        private TextBox textBox13;
        private TextBox textBox14;
        private Label label16;
        private Label label18;
        private SplitContainer splitContainer1;
    }
}
