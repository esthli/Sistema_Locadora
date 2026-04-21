namespace Sistema_Locadora
{
    partial class frm_Locacao
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Locacao));
            gb_LocacaoCod = new GroupBox();
            btn_PesquisarCodCliente = new Button();
            ckbox_CodCliente = new CheckBox();
            gb_Data = new GroupBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            ts_Locacao = new ToolStrip();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbtn_inicio = new ToolStripButton();
            tsbtn_voltar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator5 = new ToolStripSeparator();
            tsbtn_frente = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            tsbtn_addLocacao = new ToolStripButton();
            tsbtn_delLocacao = new ToolStripButton();
            tsbtn_saveLocacao = new ToolStripButton();
            gb_Filmes = new GroupBox();
            ckbox_PesquisarCodFilme = new CheckBox();
            btn_PesquisarCodFilme = new Button();
            cbox_GeneroFilme = new ComboBox();
            cbox_ClassificacaoFilme = new ComboBox();
            msktxt_AnoFilme = new MaskedTextBox();
            label8 = new Label();
            label9 = new Label();
            label01 = new Label();
            txt_CodFilme = new TextBox();
            txt_TituloFilme = new TextBox();
            label16 = new Label();
            label18 = new Label();
            gb_LocacaoCod.SuspendLayout();
            gb_Data.SuspendLayout();
            ts_Locacao.SuspendLayout();
            gb_Filmes.SuspendLayout();
            SuspendLayout();
            // 
            // gb_LocacaoCod
            // 
            gb_LocacaoCod.Controls.Add(btn_PesquisarCodCliente);
            gb_LocacaoCod.Controls.Add(ckbox_CodCliente);
            gb_LocacaoCod.Controls.Add(gb_Data);
            gb_LocacaoCod.Controls.Add(textBox7);
            gb_LocacaoCod.Controls.Add(textBox5);
            gb_LocacaoCod.Controls.Add(textBox6);
            gb_LocacaoCod.Controls.Add(textBox1);
            gb_LocacaoCod.Controls.Add(label7);
            gb_LocacaoCod.Controls.Add(label5);
            gb_LocacaoCod.Controls.Add(label6);
            gb_LocacaoCod.Controls.Add(label4);
            gb_LocacaoCod.Location = new Point(12, 323);
            gb_LocacaoCod.Name = "gb_LocacaoCod";
            gb_LocacaoCod.Size = new Size(679, 258);
            gb_LocacaoCod.TabIndex = 0;
            gb_LocacaoCod.TabStop = false;
            // 
            // btn_PesquisarCodCliente
            // 
            btn_PesquisarCodCliente.AutoSize = true;
            btn_PesquisarCodCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_PesquisarCodCliente.Enabled = false;
            btn_PesquisarCodCliente.Image = (Image)resources.GetObject("btn_PesquisarCodCliente.Image");
            btn_PesquisarCodCliente.Location = new Point(226, 27);
            btn_PesquisarCodCliente.Name = "btn_PesquisarCodCliente";
            btn_PesquisarCodCliente.Size = new Size(26, 26);
            btn_PesquisarCodCliente.TabIndex = 27;
            btn_PesquisarCodCliente.UseVisualStyleBackColor = true;
            btn_PesquisarCodCliente.Click += btn_PesquisarCodCliente_Click;
            // 
            // ckbox_CodCliente
            // 
            ckbox_CodCliente.AutoSize = true;
            ckbox_CodCliente.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbox_CodCliente.Location = new Point(268, 26);
            ckbox_CodCliente.Name = "ckbox_CodCliente";
            ckbox_CodCliente.Size = new Size(163, 27);
            ckbox_CodCliente.TabIndex = 26;
            ckbox_CodCliente.Text = "Pesquisar Código";
            ckbox_CodCliente.UseVisualStyleBackColor = true;
            // 
            // gb_Data
            // 
            gb_Data.Controls.Add(textBox2);
            gb_Data.Controls.Add(label1);
            gb_Data.Controls.Add(label2);
            gb_Data.Controls.Add(textBox4);
            gb_Data.Controls.Add(textBox3);
            gb_Data.Controls.Add(label3);
            gb_Data.Location = new Point(281, 59);
            gb_Data.Name = "gb_Data";
            gb_Data.Size = new Size(359, 178);
            gb_Data.TabIndex = 14;
            gb_Data.TabStop = false;
            gb_Data.Text = "Datas";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(215, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 43);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Data da Locação:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 92);
            label2.Name = "label2";
            label2.Size = new Size(195, 20);
            label2.TabIndex = 1;
            label2.Text = "Data Prevista da Devolução:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(215, 89);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(215, 133);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 136);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 3;
            label3.Text = "Data da Devolução:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(127, 192);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(95, 133);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(95, 79);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 195);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 6;
            label7.Text = "Valor da Taxa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 136);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 5;
            label5.Text = "Filme:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 82);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 4;
            label6.Text = "Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 33);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 2;
            label4.Text = "Código :";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 587);
            listView1.Name = "listView1";
            listView1.Size = new Size(673, 16);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // ts_Locacao
            // 
            ts_Locacao.ImageScalingSize = new Size(30, 30);
            ts_Locacao.Items.AddRange(new ToolStripItem[] { toolStripSeparator3, tsbtn_inicio, tsbtn_voltar, toolStripSeparator4, toolStripTextBox1, toolStripLabel1, toolStripSeparator5, tsbtn_frente, toolStripButton6, toolStripSeparator6, tsbtn_addLocacao, tsbtn_delLocacao, tsbtn_saveLocacao });
            ts_Locacao.Location = new Point(0, 0);
            ts_Locacao.Name = "ts_Locacao";
            ts_Locacao.Size = new Size(756, 37);
            ts_Locacao.TabIndex = 14;
            ts_Locacao.Text = "toolStrip2";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 37);
            // 
            // tsbtn_inicio
            // 
            tsbtn_inicio.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_inicio.Image = (Image)resources.GetObject("tsbtn_inicio.Image");
            tsbtn_inicio.ImageTransparentColor = Color.Magenta;
            tsbtn_inicio.Name = "tsbtn_inicio";
            tsbtn_inicio.Size = new Size(34, 34);
            tsbtn_inicio.Text = "Voltar pro Início";
            // 
            // tsbtn_voltar
            // 
            tsbtn_voltar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_voltar.Image = (Image)resources.GetObject("tsbtn_voltar.Image");
            tsbtn_voltar.ImageTransparentColor = Color.Magenta;
            tsbtn_voltar.Name = "tsbtn_voltar";
            tsbtn_voltar.Size = new Size(34, 34);
            tsbtn_voltar.Text = "Voltar";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 37);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.ReadOnly = true;
            toolStripTextBox1.Size = new Size(100, 37);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(38, 34);
            toolStripLabel1.Text = "de n";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 37);
            // 
            // tsbtn_frente
            // 
            tsbtn_frente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_frente.Image = (Image)resources.GetObject("tsbtn_frente.Image");
            tsbtn_frente.ImageTransparentColor = Color.Magenta;
            tsbtn_frente.Name = "tsbtn_frente";
            tsbtn_frente.Size = new Size(34, 34);
            tsbtn_frente.Text = "Frente";
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(34, 34);
            toolStripButton6.Text = "toolStripButton4";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 37);
            // 
            // tsbtn_addLocacao
            // 
            tsbtn_addLocacao.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_addLocacao.Image = (Image)resources.GetObject("tsbtn_addLocacao.Image");
            tsbtn_addLocacao.ImageTransparentColor = Color.Magenta;
            tsbtn_addLocacao.Name = "tsbtn_addLocacao";
            tsbtn_addLocacao.Size = new Size(34, 34);
            tsbtn_addLocacao.Text = "Adicionar";
            // 
            // tsbtn_delLocacao
            // 
            tsbtn_delLocacao.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_delLocacao.Image = (Image)resources.GetObject("tsbtn_delLocacao.Image");
            tsbtn_delLocacao.ImageTransparentColor = Color.Magenta;
            tsbtn_delLocacao.Name = "tsbtn_delLocacao";
            tsbtn_delLocacao.Size = new Size(34, 34);
            tsbtn_delLocacao.Text = "Deletar";
            // 
            // tsbtn_saveLocacao
            // 
            tsbtn_saveLocacao.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_saveLocacao.Image = (Image)resources.GetObject("tsbtn_saveLocacao.Image");
            tsbtn_saveLocacao.ImageTransparentColor = Color.Magenta;
            tsbtn_saveLocacao.Name = "tsbtn_saveLocacao";
            tsbtn_saveLocacao.Size = new Size(34, 34);
            tsbtn_saveLocacao.Text = "Salvar";
            // 
            // gb_Filmes
            // 
            gb_Filmes.BackColor = Color.Transparent;
            gb_Filmes.Controls.Add(ckbox_PesquisarCodFilme);
            gb_Filmes.Controls.Add(btn_PesquisarCodFilme);
            gb_Filmes.Controls.Add(cbox_GeneroFilme);
            gb_Filmes.Controls.Add(cbox_ClassificacaoFilme);
            gb_Filmes.Controls.Add(msktxt_AnoFilme);
            gb_Filmes.Controls.Add(label8);
            gb_Filmes.Controls.Add(label9);
            gb_Filmes.Controls.Add(label01);
            gb_Filmes.Controls.Add(txt_CodFilme);
            gb_Filmes.Controls.Add(txt_TituloFilme);
            gb_Filmes.Controls.Add(label16);
            gb_Filmes.Controls.Add(label18);
            gb_Filmes.Location = new Point(0, 49);
            gb_Filmes.Name = "gb_Filmes";
            gb_Filmes.Size = new Size(723, 152);
            gb_Filmes.TabIndex = 15;
            gb_Filmes.TabStop = false;
            // 
            // ckbox_PesquisarCodFilme
            // 
            ckbox_PesquisarCodFilme.AutoSize = true;
            ckbox_PesquisarCodFilme.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbox_PesquisarCodFilme.Location = new Point(269, 28);
            ckbox_PesquisarCodFilme.Name = "ckbox_PesquisarCodFilme";
            ckbox_PesquisarCodFilme.Size = new Size(163, 27);
            ckbox_PesquisarCodFilme.TabIndex = 31;
            ckbox_PesquisarCodFilme.Text = "Pesquisar Código";
            ckbox_PesquisarCodFilme.UseVisualStyleBackColor = true;
            // 
            // btn_PesquisarCodFilme
            // 
            btn_PesquisarCodFilme.Image = (Image)resources.GetObject("btn_PesquisarCodFilme.Image");
            btn_PesquisarCodFilme.Location = new Point(215, 26);
            btn_PesquisarCodFilme.Name = "btn_PesquisarCodFilme";
            btn_PesquisarCodFilme.Size = new Size(33, 29);
            btn_PesquisarCodFilme.TabIndex = 30;
            btn_PesquisarCodFilme.UseVisualStyleBackColor = true;
            // 
            // cbox_GeneroFilme
            // 
            cbox_GeneroFilme.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_GeneroFilme.FormattingEnabled = true;
            cbox_GeneroFilme.Location = new Point(526, 104);
            cbox_GeneroFilme.Name = "cbox_GeneroFilme";
            cbox_GeneroFilme.Size = new Size(170, 28);
            cbox_GeneroFilme.TabIndex = 17;
            // 
            // cbox_ClassificacaoFilme
            // 
            cbox_ClassificacaoFilme.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_ClassificacaoFilme.FormattingEnabled = true;
            cbox_ClassificacaoFilme.Items.AddRange(new object[] { "L", "10", "12", "14", "16", "18" });
            cbox_ClassificacaoFilme.Location = new Point(375, 104);
            cbox_ClassificacaoFilme.Name = "cbox_ClassificacaoFilme";
            cbox_ClassificacaoFilme.Size = new Size(73, 28);
            cbox_ClassificacaoFilme.TabIndex = 16;
            // 
            // msktxt_AnoFilme
            // 
            msktxt_AnoFilme.Location = new Point(98, 104);
            msktxt_AnoFilme.Mask = "0000";
            msktxt_AnoFilme.Name = "msktxt_AnoFilme";
            msktxt_AnoFilme.Size = new Size(50, 27);
            msktxt_AnoFilme.TabIndex = 15;
            msktxt_AnoFilme.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold);
            label8.Location = new Point(454, 109);
            label8.Name = "label8";
            label8.Size = new Size(73, 19);
            label8.TabIndex = 14;
            label8.Text = "Gênero";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold);
            label9.Location = new Point(154, 109);
            label9.Name = "label9";
            label9.Size = new Size(221, 19);
            label9.TabIndex = 13;
            label9.Text = "Classificação Indicativa";
            // 
            // label01
            // 
            label01.AutoSize = true;
            label01.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold);
            label01.Location = new Point(32, 109);
            label01.Name = "label01";
            label01.Size = new Size(44, 19);
            label01.TabIndex = 12;
            label01.Text = "Ano";
            // 
            // txt_CodFilme
            // 
            txt_CodFilme.Enabled = false;
            txt_CodFilme.Location = new Point(98, 27);
            txt_CodFilme.Name = "txt_CodFilme";
            txt_CodFilme.Size = new Size(106, 27);
            txt_CodFilme.TabIndex = 11;
            // 
            // txt_TituloFilme
            // 
            txt_TituloFilme.Location = new Point(98, 64);
            txt_TituloFilme.Name = "txt_TituloFilme";
            txt_TituloFilme.Size = new Size(598, 27);
            txt_TituloFilme.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold);
            label16.Location = new Point(15, 30);
            label16.Name = "label16";
            label16.Size = new Size(72, 19);
            label16.TabIndex = 6;
            label16.Text = "Código";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold);
            label18.Location = new Point(25, 69);
            label18.Name = "label18";
            label18.Size = new Size(72, 19);
            label18.TabIndex = 8;
            label18.Text = "Cliente";
            // 
            // frm_Locacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 615);
            Controls.Add(gb_Filmes);
            Controls.Add(ts_Locacao);
            Controls.Add(listView1);
            Controls.Add(gb_LocacaoCod);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_Locacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Locação";
            gb_LocacaoCod.ResumeLayout(false);
            gb_LocacaoCod.PerformLayout();
            gb_Data.ResumeLayout(false);
            gb_Data.PerformLayout();
            ts_Locacao.ResumeLayout(false);
            ts_Locacao.PerformLayout();
            gb_Filmes.ResumeLayout(false);
            gb_Filmes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb_LocacaoCod;
        private TextBox textBox7;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private GroupBox gb_Data;
        private ListView listView1;
        private Button btn_PesquisarCodCliente;
        private CheckBox ckbox_CodCliente;
        private ImageList imageList1;
        private ToolStrip ts_Locacao;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbtn_inicio;
        private ToolStripButton tsbtn_voltar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton tsbtn_frente;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton tsbtn_addLocacao;
        private ToolStripButton tsbtn_delLocacao;
        private ToolStripButton tsbtn_saveLocacao;
        private GroupBox gb_Filmes;
        private CheckBox ckbox_PesquisarCodFilme;
        private Button btn_PesquisarCodFilme;
        private ComboBox cbox_GeneroFilme;
        private ComboBox cbox_ClassificacaoFilme;
        private MaskedTextBox msktxt_AnoFilme;
        private Label label8;
        private Label label9;
        private Label label01;
        private TextBox txt_CodFilme;
        private TextBox txt_TituloFilme;
        private Label label16;
        private Label label18;
    }
}