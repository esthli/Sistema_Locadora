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
            btn_LimparClientes = new Button();
            ckbox_PesquisarCodFilme = new CheckBox();
            btn_PesquisarCodFilme = new Button();
            cbox_GeneroFilme = new ComboBox();
            cbox_ClassificacaoFilme = new ComboBox();
            msktxt_AnoFilme = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            label01 = new Label();
            txt_CodFilme = new TextBox();
            txt_TituloFilme = new TextBox();
            label16 = new Label();
            label18 = new Label();
            ts_Filmes = new ToolStrip();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbtn_inicio = new ToolStripButton();
            tsbtn_voltar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripTextBox1 = new ToolStripTextBox();
            tslbl_Filmes = new ToolStripLabel();
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
            button1 = new Button();
            ckbox_PesquisarGenero = new CheckBox();
            btn_PesquisarCodGenero = new Button();
            txt_GeneroFilme = new TextBox();
            tbctrl_Filmes = new TabControl();
            tbpg_Filmes = new TabPage();
            btn_EnviarFilmes = new Button();
            label11 = new Label();
            ckbox_AnoFilme = new CheckBox();
            ckbox_ClassificacaoFilme = new CheckBox();
            ckbox_Genero = new CheckBox();
            ltview_BuscarFilme = new ListView();
            txt_BuscarFIlme = new TextBox();
            btn_BuscarFilme = new Button();
            label5 = new Label();
            tbpg_Genero = new TabPage();
            ltview_BuscarGeneros = new ListView();
            txt_BuscaGenero = new TextBox();
            btn_PesquisarGenero = new Button();
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
            gb_Filmes.Controls.Add(btn_LimparClientes);
            gb_Filmes.Controls.Add(ckbox_PesquisarCodFilme);
            gb_Filmes.Controls.Add(btn_PesquisarCodFilme);
            gb_Filmes.Controls.Add(cbox_GeneroFilme);
            gb_Filmes.Controls.Add(cbox_ClassificacaoFilme);
            gb_Filmes.Controls.Add(msktxt_AnoFilme);
            gb_Filmes.Controls.Add(label2);
            gb_Filmes.Controls.Add(label1);
            gb_Filmes.Controls.Add(label01);
            gb_Filmes.Controls.Add(txt_CodFilme);
            gb_Filmes.Controls.Add(txt_TituloFilme);
            gb_Filmes.Controls.Add(label16);
            gb_Filmes.Controls.Add(label18);
            gb_Filmes.Location = new Point(9, 16);
            gb_Filmes.Name = "gb_Filmes";
            gb_Filmes.Size = new Size(708, 152);
            gb_Filmes.TabIndex = 12;
            gb_Filmes.TabStop = false;
            // 
            // btn_LimparClientes
            // 
            btn_LimparClientes.BackColor = SystemColors.InactiveBorder;
            btn_LimparClientes.ForeColor = SystemColors.ControlDarkDark;
            btn_LimparClientes.Image = (Image)resources.GetObject("btn_LimparClientes.Image");
            btn_LimparClientes.Location = new Point(664, 25);
            btn_LimparClientes.Name = "btn_LimparClientes";
            btn_LimparClientes.Size = new Size(32, 29);
            btn_LimparClientes.TabIndex = 27;
            btn_LimparClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_LimparClientes.UseVisualStyleBackColor = false;
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
            ckbox_PesquisarCodFilme.CheckedChanged += ckbox_PesquisarCodFilme_CheckedChanged;
            // 
            // btn_PesquisarCodFilme
            // 
            btn_PesquisarCodFilme.Image = (Image)resources.GetObject("btn_PesquisarCodFilme.Image");
            btn_PesquisarCodFilme.Location = new Point(215, 26);
            btn_PesquisarCodFilme.Name = "btn_PesquisarCodFilme";
            btn_PesquisarCodFilme.Size = new Size(33, 29);
            btn_PesquisarCodFilme.TabIndex = 30;
            btn_PesquisarCodFilme.UseVisualStyleBackColor = true;
            btn_PesquisarCodFilme.Click += btn_PesquisarCodFilme_Click;
            // 
            // cbox_GeneroFilme
            // 
            cbox_GeneroFilme.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_GeneroFilme.FormattingEnabled = true;
            cbox_GeneroFilme.Location = new Point(526, 104);
            cbox_GeneroFilme.Name = "cbox_GeneroFilme";
            cbox_GeneroFilme.Size = new Size(170, 31);
            cbox_GeneroFilme.TabIndex = 17;
            cbox_GeneroFilme.SelectedIndexChanged += cbox_GeneroFilme_SelectedIndexChanged;
            // 
            // cbox_ClassificacaoFilme
            // 
            cbox_ClassificacaoFilme.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_ClassificacaoFilme.FormattingEnabled = true;
            cbox_ClassificacaoFilme.Items.AddRange(new object[] { "L", "10", "12", "14", "16", "18" });
            cbox_ClassificacaoFilme.Location = new Point(375, 104);
            cbox_ClassificacaoFilme.Name = "cbox_ClassificacaoFilme";
            cbox_ClassificacaoFilme.Size = new Size(73, 31);
            cbox_ClassificacaoFilme.TabIndex = 16;
            // 
            // msktxt_AnoFilme
            // 
            msktxt_AnoFilme.Location = new Point(98, 104);
            msktxt_AnoFilme.Mask = "0000";
            msktxt_AnoFilme.Name = "msktxt_AnoFilme";
            msktxt_AnoFilme.Size = new Size(50, 30);
            msktxt_AnoFilme.TabIndex = 15;
            msktxt_AnoFilme.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold);
            label2.Location = new Point(454, 109);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 14;
            label2.Text = "Gênero";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold);
            label1.Location = new Point(154, 109);
            label1.Name = "label1";
            label1.Size = new Size(221, 19);
            label1.TabIndex = 13;
            label1.Text = "Classificação Indicativa";
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
            txt_CodFilme.Size = new Size(106, 30);
            txt_CodFilme.TabIndex = 11;
            // 
            // txt_TituloFilme
            // 
            txt_TituloFilme.Location = new Point(98, 64);
            txt_TituloFilme.Name = "txt_TituloFilme";
            txt_TituloFilme.Size = new Size(598, 30);
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
            label18.Size = new Size(62, 19);
            label18.TabIndex = 8;
            label18.Text = "Título";
            // 
            // ts_Filmes
            // 
            ts_Filmes.ImageScalingSize = new Size(30, 30);
            ts_Filmes.Items.AddRange(new ToolStripItem[] { toolStripSeparator3, tsbtn_inicio, tsbtn_voltar, toolStripSeparator4, toolStripTextBox1, tslbl_Filmes, toolStripSeparator5, tsbtn_frente, toolStripButton6, toolStripSeparator6, tsbtn_addFilme, tsbtn_delFilme, tsbtn_saveFilme });
            ts_Filmes.Location = new Point(0, 0);
            ts_Filmes.Name = "ts_Filmes";
            ts_Filmes.Size = new Size(744, 37);
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
            // tslbl_Filmes
            // 
            tslbl_Filmes.Name = "tslbl_Filmes";
            tslbl_Filmes.Size = new Size(38, 34);
            tslbl_Filmes.Text = "de n";
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
            tsbtn_delFilme.Click += tsbtn_delFilme_Click;
            // 
            // tsbtn_saveFilme
            // 
            tsbtn_saveFilme.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_saveFilme.Image = (Image)resources.GetObject("tsbtn_saveFilme.Image");
            tsbtn_saveFilme.ImageTransparentColor = Color.Magenta;
            tsbtn_saveFilme.Name = "tsbtn_saveFilme";
            tsbtn_saveFilme.Size = new Size(34, 34);
            tsbtn_saveFilme.Text = "Salvar";
            tsbtn_saveFilme.Click += tsbtn_saveFilme_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            label6.Location = new Point(12, 27);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 6;
            label6.Text = "Código";
            // 
            // txt_CodGeneroFilme
            // 
            txt_CodGeneroFilme.Enabled = false;
            txt_CodGeneroFilme.Location = new Point(94, 25);
            txt_CodGeneroFilme.Name = "txt_CodGeneroFilme";
            txt_CodGeneroFilme.Size = new Size(80, 27);
            txt_CodGeneroFilme.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 14;
            label3.Text = "Gênero";
            // 
            // gb_GeneroFilme
            // 
            gb_GeneroFilme.BackColor = Color.Transparent;
            gb_GeneroFilme.Controls.Add(button1);
            gb_GeneroFilme.Controls.Add(ckbox_PesquisarGenero);
            gb_GeneroFilme.Controls.Add(btn_PesquisarCodGenero);
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
            // button1
            // 
            button1.BackColor = SystemColors.InactiveBorder;
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(665, 26);
            button1.Name = "button1";
            button1.Size = new Size(32, 29);
            button1.TabIndex = 27;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // ckbox_PesquisarGenero
            // 
            ckbox_PesquisarGenero.AutoSize = true;
            ckbox_PesquisarGenero.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbox_PesquisarGenero.Location = new Point(232, 27);
            ckbox_PesquisarGenero.Name = "ckbox_PesquisarGenero";
            ckbox_PesquisarGenero.Size = new Size(163, 27);
            ckbox_PesquisarGenero.TabIndex = 29;
            ckbox_PesquisarGenero.Text = "Pesquisar Código";
            ckbox_PesquisarGenero.UseVisualStyleBackColor = true;
            ckbox_PesquisarGenero.CheckedChanged += ckbox_PesquisarGenero_CheckedChanged;
            // 
            // btn_PesquisarCodGenero
            // 
            btn_PesquisarCodGenero.Image = (Image)resources.GetObject("btn_PesquisarCodGenero.Image");
            btn_PesquisarCodGenero.Location = new Point(180, 24);
            btn_PesquisarCodGenero.Name = "btn_PesquisarCodGenero";
            btn_PesquisarCodGenero.Size = new Size(33, 29);
            btn_PesquisarCodGenero.TabIndex = 28;
            btn_PesquisarCodGenero.UseVisualStyleBackColor = true;
            btn_PesquisarCodGenero.Click += btn_PesquisarCodGenero_Click;
            // 
            // txt_GeneroFilme
            // 
            txt_GeneroFilme.Location = new Point(94, 66);
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
            tbctrl_Filmes.Size = new Size(731, 618);
            tbctrl_Filmes.TabIndex = 20;
            tbctrl_Filmes.SelectedIndexChanged += tbctrl_Filmes_SelectedIndexChanged;
            // 
            // tbpg_Filmes
            // 
            tbpg_Filmes.BackColor = SystemColors.ActiveCaption;
            tbpg_Filmes.Controls.Add(btn_EnviarFilmes);
            tbpg_Filmes.Controls.Add(label11);
            tbpg_Filmes.Controls.Add(ckbox_AnoFilme);
            tbpg_Filmes.Controls.Add(ckbox_ClassificacaoFilme);
            tbpg_Filmes.Controls.Add(ckbox_Genero);
            tbpg_Filmes.Controls.Add(gb_Filmes);
            tbpg_Filmes.Controls.Add(ltview_BuscarFilme);
            tbpg_Filmes.Controls.Add(txt_BuscarFIlme);
            tbpg_Filmes.Controls.Add(btn_BuscarFilme);
            tbpg_Filmes.Controls.Add(label5);
            tbpg_Filmes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbpg_Filmes.Location = new Point(4, 29);
            tbpg_Filmes.Name = "tbpg_Filmes";
            tbpg_Filmes.Padding = new Padding(3);
            tbpg_Filmes.Size = new Size(723, 585);
            tbpg_Filmes.TabIndex = 0;
            tbpg_Filmes.Text = "Filme";
            // 
            // btn_EnviarFilmes
            // 
            btn_EnviarFilmes.BackColor = SystemColors.ControlDarkDark;
            btn_EnviarFilmes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EnviarFilmes.ForeColor = SystemColors.ButtonHighlight;
            btn_EnviarFilmes.Location = new Point(402, 542);
            btn_EnviarFilmes.Name = "btn_EnviarFilmes";
            btn_EnviarFilmes.Size = new Size(94, 29);
            btn_EnviarFilmes.TabIndex = 36;
            btn_EnviarFilmes.Text = "Enviar";
            btn_EnviarFilmes.UseVisualStyleBackColor = false;
            btn_EnviarFilmes.Click += btn_EnviarFilmes_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(23, 522);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 35;
            label11.Text = "Mostrar:";
            // 
            // ckbox_AnoFilme
            // 
            ckbox_AnoFilme.AutoSize = true;
            ckbox_AnoFilme.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ckbox_AnoFilme.Location = new Point(32, 545);
            ckbox_AnoFilme.Name = "ckbox_AnoFilme";
            ckbox_AnoFilme.Size = new Size(59, 24);
            ckbox_AnoFilme.TabIndex = 32;
            ckbox_AnoFilme.Text = "Ano";
            ckbox_AnoFilme.UseVisualStyleBackColor = true;
            // 
            // ckbox_ClassificacaoFilme
            // 
            ckbox_ClassificacaoFilme.AutoSize = true;
            ckbox_ClassificacaoFilme.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ckbox_ClassificacaoFilme.Location = new Point(97, 545);
            ckbox_ClassificacaoFilme.Name = "ckbox_ClassificacaoFilme";
            ckbox_ClassificacaoFilme.Size = new Size(186, 24);
            ckbox_ClassificacaoFilme.TabIndex = 33;
            ckbox_ClassificacaoFilme.Text = "Classificação Indicativa";
            ckbox_ClassificacaoFilme.UseVisualStyleBackColor = true;
            // 
            // ckbox_Genero
            // 
            ckbox_Genero.AutoSize = true;
            ckbox_Genero.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ckbox_Genero.Location = new Point(289, 545);
            ckbox_Genero.Name = "ckbox_Genero";
            ckbox_Genero.Size = new Size(81, 24);
            ckbox_Genero.TabIndex = 34;
            ckbox_Genero.Text = "Genero";
            ckbox_Genero.UseVisualStyleBackColor = true;
            // 
            // ltview_BuscarFilme
            // 
            ltview_BuscarFilme.BorderStyle = BorderStyle.FixedSingle;
            ltview_BuscarFilme.FullRowSelect = true;
            ltview_BuscarFilme.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ltview_BuscarFilme.Location = new Point(19, 261);
            ltview_BuscarFilme.Name = "ltview_BuscarFilme";
            ltview_BuscarFilme.Size = new Size(686, 250);
            ltview_BuscarFilme.TabIndex = 27;
            ltview_BuscarFilme.UseCompatibleStateImageBehavior = false;
            // 
            // txt_BuscarFIlme
            // 
            txt_BuscarFIlme.Location = new Point(19, 224);
            txt_BuscarFIlme.Name = "txt_BuscarFIlme";
            txt_BuscarFIlme.Size = new Size(560, 30);
            txt_BuscarFIlme.TabIndex = 26;
            // 
            // btn_BuscarFilme
            // 
            btn_BuscarFilme.BackColor = SystemColors.ActiveBorder;
            btn_BuscarFilme.FlatStyle = FlatStyle.System;
            btn_BuscarFilme.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_BuscarFilme.ForeColor = Color.DarkGray;
            btn_BuscarFilme.Location = new Point(585, 224);
            btn_BuscarFilme.Name = "btn_BuscarFilme";
            btn_BuscarFilme.Size = new Size(120, 27);
            btn_BuscarFilme.TabIndex = 24;
            btn_BuscarFilme.Text = "Pesquisar";
            btn_BuscarFilme.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_BuscarFilme.UseVisualStyleBackColor = false;
            btn_BuscarFilme.Click += btn_BuscarFilme_Click;
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
            tbpg_Genero.BackColor = Color.SlateGray;
            tbpg_Genero.Controls.Add(gb_GeneroFilme);
            tbpg_Genero.Controls.Add(ltview_BuscarGeneros);
            tbpg_Genero.Controls.Add(txt_BuscaGenero);
            tbpg_Genero.Controls.Add(btn_PesquisarGenero);
            tbpg_Genero.Controls.Add(label10);
            tbpg_Genero.Location = new Point(4, 29);
            tbpg_Genero.Name = "tbpg_Genero";
            tbpg_Genero.Padding = new Padding(3);
            tbpg_Genero.Size = new Size(723, 585);
            tbpg_Genero.TabIndex = 1;
            tbpg_Genero.Text = "Gênero";
            // 
            // ltview_BuscarGeneros
            // 
            ltview_BuscarGeneros.BorderStyle = BorderStyle.FixedSingle;
            ltview_BuscarGeneros.FullRowSelect = true;
            ltview_BuscarGeneros.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ltview_BuscarGeneros.Location = new Point(17, 210);
            ltview_BuscarGeneros.Name = "ltview_BuscarGeneros";
            ltview_BuscarGeneros.Size = new Size(686, 359);
            ltview_BuscarGeneros.TabIndex = 27;
            ltview_BuscarGeneros.UseCompatibleStateImageBehavior = false;
            // 
            // txt_BuscaGenero
            // 
            txt_BuscaGenero.Location = new Point(17, 173);
            txt_BuscaGenero.Name = "txt_BuscaGenero";
            txt_BuscaGenero.Size = new Size(560, 27);
            txt_BuscaGenero.TabIndex = 26;
            // 
            // btn_PesquisarGenero
            // 
            btn_PesquisarGenero.BackColor = SystemColors.ActiveBorder;
            btn_PesquisarGenero.FlatStyle = FlatStyle.System;
            btn_PesquisarGenero.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_PesquisarGenero.ForeColor = Color.DarkGray;
            btn_PesquisarGenero.Location = new Point(583, 173);
            btn_PesquisarGenero.Name = "btn_PesquisarGenero";
            btn_PesquisarGenero.Size = new Size(120, 27);
            btn_PesquisarGenero.TabIndex = 24;
            btn_PesquisarGenero.Text = "Pesquisar";
            btn_PesquisarGenero.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_PesquisarGenero.UseVisualStyleBackColor = false;
            btn_PesquisarGenero.Click += btn_PesquisarGenero_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            label10.Location = new Point(17, 145);
            label10.Name = "label10";
            label10.Size = new Size(149, 20);
            label10.TabIndex = 25;
            label10.Text = "Buscar Gênero:";
            // 
            // frm_Filmes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 681);
            Controls.Add(tbctrl_Filmes);
            Controls.Add(ts_Filmes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frm_Filmes";
            StartPosition = FormStartPosition.CenterScreen;
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
        private TextBox txt_CodFilme;
        private TextBox txt_TituloFilme;
        private Label label16;
        private Label label18;
        private ToolStrip ts_Filmes;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbtn_inicio;
        private ToolStripButton tsbtn_voltar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripLabel tslbl_Filmes;
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
        private ListView ltview_BuscarFilme;
        private TextBox txt_BuscarFIlme;
        private Button btn_BuscarFilme;
        private Label label5;
        private ListView ltview_BuscarGeneros;
        private TextBox txt_BuscaGenero;
        private Button btn_PesquisarGenero;
        private Label label10;
        private CheckBox ckbox_PesquisarGenero;
        private Button btn_PesquisarCodGenero;
        private CheckBox ckbox_PesquisarCodFilme;
        private Button btn_PesquisarCodFilme;
        private Button btn_EnviarFilmes;
        private Label label11;
        private CheckBox ckbox_AnoFilme;
        private CheckBox ckbox_ClassificacaoFilme;
        private CheckBox ckbox_Genero;
        private Button btn_LimparClientes;
        private Button button1;
    }
}