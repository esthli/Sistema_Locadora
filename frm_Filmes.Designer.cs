namespace Sistema_Locadora
{
    partial class frm_Filmes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Filmes));
            gb_Filmes = new GroupBox();
            cbox_GeneroFilme = new ComboBox();
            cbox_ClassificacaoFilme = new ComboBox();
            msktxt_AnoFilme = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            label01 = new Label();
            textBox13 = new TextBox();
            txt_TituloFilme = new TextBox();
            label16 = new Label();
            label18 = new Label();
            ts_Filmes = new ToolStrip();
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
            tsbtn_addFilme = new ToolStripButton();
            tsbtn_delFilme = new ToolStripButton();
            tsbtn_saveFilme = new ToolStripButton();
            label6 = new Label();
            txt_CodGeneroFilme = new TextBox();
            label3 = new Label();
            gb_GeneroFilme = new GroupBox();
            txt_GeneroFilme = new TextBox();
            tbctrl_Filmes = new TabControl();
            tbpg_Filmes = new TabPage();
            listView1 = new ListView();
            textBox1 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            tbpg_Genero = new TabPage();
            ltview_BuscarClientes = new ListView();
            txt_BuscaCliente = new TextBox();
            btn_PesquisarCliente = new Button();
            label10 = new Label();
            gb_Filmes.SuspendLayout();
            ts_Filmes.SuspendLayout();
            gb_GeneroFilme.SuspendLayout();
            tbctrl_Filmes.SuspendLayout();
            tbpg_Filmes.SuspendLayout();
            tbpg_Genero.SuspendLayout();
            SuspendLayout();
            // 
            // gb_Filmes
            // 
            gb_Filmes.BackColor = Color.Transparent;
            gb_Filmes.Controls.Add(cbox_GeneroFilme);
            gb_Filmes.Controls.Add(cbox_ClassificacaoFilme);
            gb_Filmes.Controls.Add(msktxt_AnoFilme);
            gb_Filmes.Controls.Add(label2);
            gb_Filmes.Controls.Add(label1);
            gb_Filmes.Controls.Add(label01);
            gb_Filmes.Controls.Add(textBox13);
            gb_Filmes.Controls.Add(txt_TituloFilme);
            gb_Filmes.Controls.Add(label16);
            gb_Filmes.Controls.Add(label18);
            gb_Filmes.Location = new Point(9, 16);
            gb_Filmes.Name = "gb_Filmes";
            gb_Filmes.Size = new Size(723, 166);
            gb_Filmes.TabIndex = 12;
            gb_Filmes.TabStop = false;
            // 
            // cbox_GeneroFilme
            // 
            cbox_GeneroFilme.FormattingEnabled = true;
            cbox_GeneroFilme.Location = new Point(526, 114);
            cbox_GeneroFilme.Name = "cbox_GeneroFilme";
            cbox_GeneroFilme.Size = new Size(170, 31);
            cbox_GeneroFilme.TabIndex = 17;
            // 
            // cbox_ClassificacaoFilme
            // 
            cbox_ClassificacaoFilme.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_ClassificacaoFilme.FormattingEnabled = true;
            cbox_ClassificacaoFilme.Items.AddRange(new object[] { "L", "10", "12", "14", "16", "18" });
            cbox_ClassificacaoFilme.Location = new Point(356, 114);
            cbox_ClassificacaoFilme.Name = "cbox_ClassificacaoFilme";
            cbox_ClassificacaoFilme.Size = new Size(73, 31);
            cbox_ClassificacaoFilme.TabIndex = 16;
            // 
            // msktxt_AnoFilme
            // 
            msktxt_AnoFilme.Location = new Point(98, 114);
            msktxt_AnoFilme.Mask = "0000";
            msktxt_AnoFilme.Name = "msktxt_AnoFilme";
            msktxt_AnoFilme.Size = new Size(50, 30);
            msktxt_AnoFilme.TabIndex = 15;
            msktxt_AnoFilme.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 117);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 14;
            label2.Text = "Gênero";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 117);
            label1.Name = "label1";
            label1.Size = new Size(183, 23);
            label1.TabIndex = 13;
            label1.Text = "Classificação Indicativa";
            // 
            // label01
            // 
            label01.AutoSize = true;
            label01.Location = new Point(23, 117);
            label01.Name = "label01";
            label01.Size = new Size(41, 23);
            label01.TabIndex = 12;
            label01.Text = "Ano";
            // 
            // textBox13
            // 
            textBox13.Enabled = false;
            textBox13.Location = new Point(98, 37);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(106, 30);
            textBox13.TabIndex = 11;
            // 
            // txt_TituloFilme
            // 
            txt_TituloFilme.Location = new Point(98, 74);
            txt_TituloFilme.Name = "txt_TituloFilme";
            txt_TituloFilme.Size = new Size(598, 30);
            txt_TituloFilme.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(15, 40);
            label16.Name = "label16";
            label16.Size = new Size(65, 23);
            label16.TabIndex = 6;
            label16.Text = "Código";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(23, 77);
            label18.Name = "label18";
            label18.Size = new Size(53, 23);
            label18.TabIndex = 8;
            label18.Text = "Título";
            // 
            // ts_Filmes
            // 
            ts_Filmes.ImageScalingSize = new Size(30, 30);
            ts_Filmes.Items.AddRange(new ToolStripItem[] { toolStripSeparator3, tsbtn_inicio, tsbtn_voltar, toolStripSeparator4, toolStripTextBox1, toolStripLabel1, toolStripSeparator5, tsbtn_frente, toolStripButton6, toolStripSeparator6, tsbtn_addFilme, tsbtn_delFilme, tsbtn_saveFilme });
            ts_Filmes.Location = new Point(0, 0);
            ts_Filmes.Name = "ts_Filmes";
            ts_Filmes.Size = new Size(768, 37);
            ts_Filmes.TabIndex = 13;
            ts_Filmes.Text = "toolStrip2";
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
            // tsbtn_addFilme
            // 
            tsbtn_addFilme.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_addFilme.Image = (Image)resources.GetObject("tsbtn_addFilme.Image");
            tsbtn_addFilme.ImageTransparentColor = Color.Magenta;
            tsbtn_addFilme.Name = "tsbtn_addFilme";
            tsbtn_addFilme.Size = new Size(34, 34);
            tsbtn_addFilme.Text = "Adicionar";
            tsbtn_addFilme.Click += tsbtn_addFilme_Click;
            // 
            // tsbtn_delFilme
            // 
            tsbtn_delFilme.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_delFilme.Image = (Image)resources.GetObject("tsbtn_delFilme.Image");
            tsbtn_delFilme.ImageTransparentColor = Color.Magenta;
            tsbtn_delFilme.Name = "tsbtn_delFilme";
            tsbtn_delFilme.Size = new Size(34, 34);
            tsbtn_delFilme.Text = "Deletar";
            // 
            // tsbtn_saveFilme
            // 
            tsbtn_saveFilme.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_saveFilme.Image = (Image)resources.GetObject("tsbtn_saveFilme.Image");
            tsbtn_saveFilme.ImageTransparentColor = Color.Magenta;
            tsbtn_saveFilme.Name = "tsbtn_saveFilme";
            tsbtn_saveFilme.Size = new Size(34, 34);
            tsbtn_saveFilme.Text = "Salvar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 32);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 6;
            label6.Text = "Código";
            // 
            // txt_CodGeneroFilme
            // 
            txt_CodGeneroFilme.Enabled = false;
            txt_CodGeneroFilme.Location = new Point(105, 29);
            txt_CodGeneroFilme.Name = "txt_CodGeneroFilme";
            txt_CodGeneroFilme.Size = new Size(80, 27);
            txt_CodGeneroFilme.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 73);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 14;
            label3.Text = "Gênero";
            // 
            // gb_GeneroFilme
            // 
            gb_GeneroFilme.BackColor = Color.Transparent;
            gb_GeneroFilme.Controls.Add(txt_GeneroFilme);
            gb_GeneroFilme.Controls.Add(label3);
            gb_GeneroFilme.Controls.Add(txt_CodGeneroFilme);
            gb_GeneroFilme.Controls.Add(label6);
            gb_GeneroFilme.Location = new Point(6, 6);
            gb_GeneroFilme.Name = "gb_GeneroFilme";
            gb_GeneroFilme.Size = new Size(726, 116);
            gb_GeneroFilme.TabIndex = 18;
            gb_GeneroFilme.TabStop = false;
            // 
            // txt_GeneroFilme
            // 
            txt_GeneroFilme.Location = new Point(105, 70);
            txt_GeneroFilme.Name = "txt_GeneroFilme";
            txt_GeneroFilme.Size = new Size(603, 27);
            txt_GeneroFilme.TabIndex = 15;
            // 
            // tbctrl_Filmes
            // 
            tbctrl_Filmes.Controls.Add(tbpg_Filmes);
            tbctrl_Filmes.Controls.Add(tbpg_Genero);
            tbctrl_Filmes.Location = new Point(10, 49);
            tbctrl_Filmes.Name = "tbctrl_Filmes";
            tbctrl_Filmes.SelectedIndex = 0;
            tbctrl_Filmes.Size = new Size(746, 569);
            tbctrl_Filmes.TabIndex = 20;
            tbctrl_Filmes.SelectedIndexChanged += tbctrl_Filmes_SelectedIndexChanged;
            // 
            // tbpg_Filmes
            // 
            tbpg_Filmes.BackColor = SystemColors.ActiveCaption;
            tbpg_Filmes.Controls.Add(gb_Filmes);
            tbpg_Filmes.Controls.Add(listView1);
            tbpg_Filmes.Controls.Add(textBox1);
            tbpg_Filmes.Controls.Add(button1);
            tbpg_Filmes.Controls.Add(label5);
            tbpg_Filmes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbpg_Filmes.Location = new Point(4, 29);
            tbpg_Filmes.Name = "tbpg_Filmes";
            tbpg_Filmes.Padding = new Padding(3);
            tbpg_Filmes.Size = new Size(738, 536);
            tbpg_Filmes.TabIndex = 0;
            tbpg_Filmes.Text = "Filme";
            // 
            // listView1
            // 
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.FullRowSelect = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(19, 261);
            listView1.Name = "listView1";
            listView1.Size = new Size(686, 250);
            listView1.TabIndex = 27;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 224);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(560, 30);
            textBox1.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkGray;
            button1.Location = new Point(585, 224);
            button1.Name = "button1";
            button1.Size = new Size(120, 27);
            button1.TabIndex = 24;
            button1.Text = "Pesquisar";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            label5.Location = new Point(19, 196);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 25;
            label5.Text = "Buscar Filme:";
            // 
            // tbpg_Genero
            // 
            tbpg_Genero.BackColor = Color.DarkGray;
            tbpg_Genero.Controls.Add(gb_GeneroFilme);
            tbpg_Genero.Controls.Add(ltview_BuscarClientes);
            tbpg_Genero.Controls.Add(txt_BuscaCliente);
            tbpg_Genero.Controls.Add(btn_PesquisarCliente);
            tbpg_Genero.Controls.Add(label10);
            tbpg_Genero.Location = new Point(4, 29);
            tbpg_Genero.Name = "tbpg_Genero";
            tbpg_Genero.Padding = new Padding(3);
            tbpg_Genero.Size = new Size(738, 536);
            tbpg_Genero.TabIndex = 1;
            tbpg_Genero.Text = "Gênero";
            // 
            // ltview_BuscarClientes
            // 
            ltview_BuscarClientes.BorderStyle = BorderStyle.FixedSingle;
            ltview_BuscarClientes.FullRowSelect = true;
            ltview_BuscarClientes.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ltview_BuscarClientes.Location = new Point(28, 207);
            ltview_BuscarClientes.Name = "ltview_BuscarClientes";
            ltview_BuscarClientes.Size = new Size(686, 250);
            ltview_BuscarClientes.TabIndex = 27;
            ltview_BuscarClientes.UseCompatibleStateImageBehavior = false;
            // 
            // txt_BuscaCliente
            // 
            txt_BuscaCliente.Location = new Point(28, 170);
            txt_BuscaCliente.Name = "txt_BuscaCliente";
            txt_BuscaCliente.Size = new Size(560, 27);
            txt_BuscaCliente.TabIndex = 26;
            // 
            // btn_PesquisarCliente
            // 
            btn_PesquisarCliente.BackColor = SystemColors.ActiveBorder;
            btn_PesquisarCliente.FlatStyle = FlatStyle.System;
            btn_PesquisarCliente.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_PesquisarCliente.ForeColor = Color.DarkGray;
            btn_PesquisarCliente.Location = new Point(594, 170);
            btn_PesquisarCliente.Name = "btn_PesquisarCliente";
            btn_PesquisarCliente.Size = new Size(120, 27);
            btn_PesquisarCliente.TabIndex = 24;
            btn_PesquisarCliente.Text = "Pesquisar";
            btn_PesquisarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_PesquisarCliente.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            label10.Location = new Point(28, 142);
            label10.Name = "label10";
            label10.Size = new Size(149, 20);
            label10.TabIndex = 25;
            label10.Text = "Buscar Gênero:";
            // 
            // frm_Filmes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 666);
            Controls.Add(tbctrl_Filmes);
            Controls.Add(ts_Filmes);
            Name = "frm_Filmes";
            Text = "Filmes";
            gb_Filmes.ResumeLayout(false);
            gb_Filmes.PerformLayout();
            ts_Filmes.ResumeLayout(false);
            ts_Filmes.PerformLayout();
            gb_GeneroFilme.ResumeLayout(false);
            gb_GeneroFilme.PerformLayout();
            tbctrl_Filmes.ResumeLayout(false);
            tbpg_Filmes.ResumeLayout(false);
            tbpg_Filmes.PerformLayout();
            tbpg_Genero.ResumeLayout(false);
            tbpg_Genero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb_Filmes;
        private TextBox textBox13;
        private TextBox txt_TituloFilme;
        private Label label16;
        private Label label18;
        private ToolStrip ts_Filmes;
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
        private ToolStripButton tsbtn_addFilme;
        private ToolStripButton tsbtn_delFilme;
        private ToolStripButton tsbtn_saveFilme;
        private ComboBox cbox_GeneroFilme;
        private ComboBox cbox_ClassificacaoFilme;
        private MaskedTextBox msktxt_AnoFilme;
        private Label label2;
        private Label label1;
        private Label label01;
        private Label label6;
        private TextBox txt_CodGeneroFilme;
        private Label label3;
        private GroupBox gb_GeneroFilme;
        private TabControl tbctrl_Filmes;
        private TabPage tbpg_Filmes;
        private TabPage tbpg_Genero;
        private TextBox txt_GeneroFilme;
        private ListView listView1;
        private TextBox textBox1;
        private Button button1;
        private Label label5;
        private ListView ltview_BuscarClientes;
        private TextBox txt_BuscaCliente;
        private Button btn_PesquisarCliente;
        private Label label10;
    }
}