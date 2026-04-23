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
            gb_Data = new GroupBox();
            ckbox_DataDevolucaoLocacao = new CheckBox();
            label5 = new Label();
            msktxt_DataDevolucaoLocacao = new MaskedTextBox();
            msktxt_DataPrevistaLocacao = new MaskedTextBox();
            msktxt_DataLocacao = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_ValorMultaLocacao = new TextBox();
            ltview_BuscarLocacao = new ListView();
            imageList1 = new ImageList(components);
            ts_Locacao = new ToolStrip();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbtn_inicio = new ToolStripButton();
            tsbtn_voltar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripTextBox1 = new ToolStripTextBox();
            tslbl_IDCount = new ToolStripLabel();
            toolStripSeparator5 = new ToolStripSeparator();
            tsbtn_frente = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            tsbtn_addLocacao = new ToolStripButton();
            tsbtn_delLocacao = new ToolStripButton();
            tsbtn_saveLocacao = new ToolStripButton();
            gb_Filmes = new GroupBox();
            btn_LimparClientes = new Button();
            label8 = new Label();
            label6 = new Label();
            txt_PrecoLocacao = new TextBox();
            label4 = new Label();
            cbox_ClientesLocacao = new ComboBox();
            cbox_FilmeLocacao = new ComboBox();
            ckbox_PesquisarCodFilme = new CheckBox();
            btn_PesquisarCodLocacao = new Button();
            label01 = new Label();
            txt_CodLocacao = new TextBox();
            label16 = new Label();
            label18 = new Label();
            txt_BuscarLocacao = new TextBox();
            btn_BuscarLocacao = new Button();
            label7 = new Label();
            btn_EnviarLocacao = new Button();
            label11 = new Label();
            ckbox_DataLocacao = new CheckBox();
            ckbox_PrevisaoLocacao = new CheckBox();
            ckbox_DevolucaoLocacao = new CheckBox();
            ckbox_VlrTaxaLocacao = new CheckBox();
            gb_Data.SuspendLayout();
            ts_Locacao.SuspendLayout();
            gb_Filmes.SuspendLayout();
            SuspendLayout();
            // 
            // gb_Data
            // 
            gb_Data.Controls.Add(ckbox_DataDevolucaoLocacao);
            gb_Data.Controls.Add(label5);
            gb_Data.Controls.Add(msktxt_DataDevolucaoLocacao);
            gb_Data.Controls.Add(msktxt_DataPrevistaLocacao);
            gb_Data.Controls.Add(msktxt_DataLocacao);
            gb_Data.Controls.Add(label1);
            gb_Data.Controls.Add(label2);
            gb_Data.Controls.Add(label3);
            gb_Data.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gb_Data.Location = new Point(15, 162);
            gb_Data.Name = "gb_Data";
            gb_Data.Size = new Size(755, 191);
            gb_Data.TabIndex = 14;
            gb_Data.TabStop = false;
            gb_Data.Text = "Datas";
            // 
            // ckbox_DataDevolucaoLocacao
            // 
            ckbox_DataDevolucaoLocacao.AutoSize = true;
            ckbox_DataDevolucaoLocacao.Location = new Point(448, 145);
            ckbox_DataDevolucaoLocacao.Name = "ckbox_DataDevolucaoLocacao";
            ckbox_DataDevolucaoLocacao.Size = new Size(243, 28);
            ckbox_DataDevolucaoLocacao.TabIndex = 37;
            ckbox_DataDevolucaoLocacao.Text = "Adicionar Data da Devolução";
            ckbox_DataDevolucaoLocacao.UseVisualStyleBackColor = true;
            ckbox_DataDevolucaoLocacao.CheckedChanged += ckbox_DataDevolucaoLocacao_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(296, 26);
            label5.Name = "label5";
            label5.Size = new Size(121, 24);
            label5.TabIndex = 36;
            label5.Text = "ANO-MÊS-DIA";
            // 
            // msktxt_DataDevolucaoLocacao
            // 
            msktxt_DataDevolucaoLocacao.Location = new Point(292, 146);
            msktxt_DataDevolucaoLocacao.Mask = "0000\\-00\\-00";
            msktxt_DataDevolucaoLocacao.Name = "msktxt_DataDevolucaoLocacao";
            msktxt_DataDevolucaoLocacao.Size = new Size(129, 30);
            msktxt_DataDevolucaoLocacao.TabIndex = 6;
            msktxt_DataDevolucaoLocacao.TextAlign = HorizontalAlignment.Center;
            // 
            // msktxt_DataPrevistaLocacao
            // 
            msktxt_DataPrevistaLocacao.Location = new Point(292, 102);
            msktxt_DataPrevistaLocacao.Mask = "0000\\-00\\-00";
            msktxt_DataPrevistaLocacao.Name = "msktxt_DataPrevistaLocacao";
            msktxt_DataPrevistaLocacao.Size = new Size(129, 30);
            msktxt_DataPrevistaLocacao.TabIndex = 5;
            msktxt_DataPrevistaLocacao.TextAlign = HorizontalAlignment.Center;
            // 
            // msktxt_DataLocacao
            // 
            msktxt_DataLocacao.Location = new Point(292, 53);
            msktxt_DataLocacao.Mask = "0000\\-00\\-00";
            msktxt_DataLocacao.Name = "msktxt_DataLocacao";
            msktxt_DataLocacao.Size = new Size(129, 30);
            msktxt_DataLocacao.TabIndex = 4;
            msktxt_DataLocacao.TextAlign = HorizontalAlignment.Center;
            msktxt_DataLocacao.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold);
            label1.Location = new Point(16, 56);
            label1.Name = "label1";
            label1.Size = new Size(159, 19);
            label1.TabIndex = 0;
            label1.Text = "Data da Locação:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold);
            label2.Location = new Point(16, 105);
            label2.Name = "label2";
            label2.Size = new Size(257, 19);
            label2.TabIndex = 1;
            label2.Text = "Data Prevista da Devolução:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold);
            label3.Location = new Point(16, 149);
            label3.Name = "label3";
            label3.Size = new Size(181, 19);
            label3.TabIndex = 3;
            label3.Text = "Data da Devolução:";
            // 
            // txt_ValorMultaLocacao
            // 
            txt_ValorMultaLocacao.Location = new Point(653, 106);
            txt_ValorMultaLocacao.Name = "txt_ValorMultaLocacao";
            txt_ValorMultaLocacao.Size = new Size(117, 27);
            txt_ValorMultaLocacao.TabIndex = 13;
            // 
            // ltview_BuscarLocacao
            // 
            ltview_BuscarLocacao.Location = new Point(12, 499);
            ltview_BuscarLocacao.Name = "ltview_BuscarLocacao";
            ltview_BuscarLocacao.Size = new Size(786, 324);
            ltview_BuscarLocacao.TabIndex = 1;
            ltview_BuscarLocacao.UseCompatibleStateImageBehavior = false;
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
            ts_Locacao.Items.AddRange(new ToolStripItem[] { toolStripSeparator3, tsbtn_inicio, tsbtn_voltar, toolStripSeparator4, toolStripTextBox1, tslbl_IDCount, toolStripSeparator5, tsbtn_frente, toolStripButton6, toolStripSeparator6, tsbtn_addLocacao, tsbtn_delLocacao, tsbtn_saveLocacao });
            ts_Locacao.Location = new Point(0, 0);
            ts_Locacao.Name = "ts_Locacao";
            ts_Locacao.Size = new Size(808, 37);
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
            // tslbl_IDCount
            // 
            tslbl_IDCount.Name = "tslbl_IDCount";
            tslbl_IDCount.Size = new Size(38, 34);
            tslbl_IDCount.Text = "de n";
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
            tsbtn_addLocacao.Click += tsbtn_addLocacao_Click;
            // 
            // tsbtn_delLocacao
            // 
            tsbtn_delLocacao.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_delLocacao.Image = (Image)resources.GetObject("tsbtn_delLocacao.Image");
            tsbtn_delLocacao.ImageTransparentColor = Color.Magenta;
            tsbtn_delLocacao.Name = "tsbtn_delLocacao";
            tsbtn_delLocacao.Size = new Size(34, 34);
            tsbtn_delLocacao.Text = "Deletar";
            tsbtn_delLocacao.Click += tsbtn_delLocacao_Click;
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
            gb_Filmes.BackColor = SystemColors.ActiveCaption;
            gb_Filmes.Controls.Add(btn_LimparClientes);
            gb_Filmes.Controls.Add(label8);
            gb_Filmes.Controls.Add(label6);
            gb_Filmes.Controls.Add(txt_PrecoLocacao);
            gb_Filmes.Controls.Add(label4);
            gb_Filmes.Controls.Add(txt_ValorMultaLocacao);
            gb_Filmes.Controls.Add(cbox_ClientesLocacao);
            gb_Filmes.Controls.Add(cbox_FilmeLocacao);
            gb_Filmes.Controls.Add(gb_Data);
            gb_Filmes.Controls.Add(ckbox_PesquisarCodFilme);
            gb_Filmes.Controls.Add(btn_PesquisarCodLocacao);
            gb_Filmes.Controls.Add(label01);
            gb_Filmes.Controls.Add(txt_CodLocacao);
            gb_Filmes.Controls.Add(label16);
            gb_Filmes.Controls.Add(label18);
            gb_Filmes.Location = new Point(12, 49);
            gb_Filmes.Name = "gb_Filmes";
            gb_Filmes.Size = new Size(786, 377);
            gb_Filmes.TabIndex = 15;
            gb_Filmes.TabStop = false;
            // 
            // btn_LimparClientes
            // 
            btn_LimparClientes.BackColor = SystemColors.InactiveBorder;
            btn_LimparClientes.ForeColor = SystemColors.ControlDarkDark;
            btn_LimparClientes.Image = (Image)resources.GetObject("btn_LimparClientes.Image");
            btn_LimparClientes.Location = new Point(738, 26);
            btn_LimparClientes.Name = "btn_LimparClientes";
            btn_LimparClientes.Size = new Size(32, 29);
            btn_LimparClientes.TabIndex = 38;
            btn_LimparClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_LimparClientes.UseVisualStyleBackColor = false;
            btn_LimparClientes.Click += btn_LimparClientes_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold);
            label8.Location = new Point(503, 109);
            label8.Name = "label8";
            label8.Size = new Size(144, 19);
            label8.TabIndex = 37;
            label8.Text = "Valor da Multa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold);
            label6.Location = new Point(566, 69);
            label6.Name = "label6";
            label6.Size = new Size(63, 19);
            label6.TabIndex = 36;
            label6.Text = "Preço:";
            // 
            // txt_PrecoLocacao
            // 
            txt_PrecoLocacao.Location = new Point(635, 66);
            txt_PrecoLocacao.Name = "txt_PrecoLocacao";
            txt_PrecoLocacao.Size = new Size(135, 27);
            txt_PrecoLocacao.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(629, 257);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 34;
            // 
            // cbox_ClientesLocacao
            // 
            cbox_ClientesLocacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_ClientesLocacao.FormattingEnabled = true;
            cbox_ClientesLocacao.Location = new Point(97, 66);
            cbox_ClientesLocacao.Name = "cbox_ClientesLocacao";
            cbox_ClientesLocacao.Size = new Size(457, 28);
            cbox_ClientesLocacao.TabIndex = 33;
            // 
            // cbox_FilmeLocacao
            // 
            cbox_FilmeLocacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_FilmeLocacao.FormattingEnabled = true;
            cbox_FilmeLocacao.Location = new Point(97, 106);
            cbox_FilmeLocacao.Name = "cbox_FilmeLocacao";
            cbox_FilmeLocacao.Size = new Size(384, 28);
            cbox_FilmeLocacao.TabIndex = 32;
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
            // btn_PesquisarCodLocacao
            // 
            btn_PesquisarCodLocacao.Image = (Image)resources.GetObject("btn_PesquisarCodLocacao.Image");
            btn_PesquisarCodLocacao.Location = new Point(215, 26);
            btn_PesquisarCodLocacao.Name = "btn_PesquisarCodLocacao";
            btn_PesquisarCodLocacao.Size = new Size(33, 29);
            btn_PesquisarCodLocacao.TabIndex = 30;
            btn_PesquisarCodLocacao.UseVisualStyleBackColor = true;
            btn_PesquisarCodLocacao.Click += btn_PesquisarCodLocacao_Click;
            // 
            // label01
            // 
            label01.AutoSize = true;
            label01.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold);
            label01.Location = new Point(21, 109);
            label01.Name = "label01";
            label01.Size = new Size(59, 19);
            label01.TabIndex = 12;
            label01.Text = "Filme";
            // 
            // txt_CodLocacao
            // 
            txt_CodLocacao.Enabled = false;
            txt_CodLocacao.Location = new Point(98, 27);
            txt_CodLocacao.Name = "txt_CodLocacao";
            txt_CodLocacao.Size = new Size(106, 27);
            txt_CodLocacao.TabIndex = 11;
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
            label18.Location = new Point(15, 69);
            label18.Name = "label18";
            label18.Size = new Size(72, 19);
            label18.TabIndex = 8;
            label18.Text = "Cliente";
            // 
            // txt_BuscarLocacao
            // 
            txt_BuscarLocacao.Location = new Point(12, 466);
            txt_BuscarLocacao.Name = "txt_BuscarLocacao";
            txt_BuscarLocacao.Size = new Size(660, 27);
            txt_BuscarLocacao.TabIndex = 29;
            // 
            // btn_BuscarLocacao
            // 
            btn_BuscarLocacao.BackColor = SystemColors.ActiveBorder;
            btn_BuscarLocacao.FlatStyle = FlatStyle.System;
            btn_BuscarLocacao.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_BuscarLocacao.ForeColor = Color.DarkGray;
            btn_BuscarLocacao.Location = new Point(678, 466);
            btn_BuscarLocacao.Name = "btn_BuscarLocacao";
            btn_BuscarLocacao.Size = new Size(120, 27);
            btn_BuscarLocacao.TabIndex = 27;
            btn_BuscarLocacao.Text = "Pesquisar";
            btn_BuscarLocacao.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_BuscarLocacao.UseVisualStyleBackColor = false;
            btn_BuscarLocacao.Click += btn_BuscarLocacao_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            label7.Location = new Point(12, 438);
            label7.Name = "label7";
            label7.Size = new Size(363, 20);
            label7.TabIndex = 28;
            label7.Text = "Buscar Locação pelo nome do Cliente:";
            // 
            // btn_EnviarLocacao
            // 
            btn_EnviarLocacao.BackColor = SystemColors.ControlDarkDark;
            btn_EnviarLocacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EnviarLocacao.ForeColor = SystemColors.ButtonHighlight;
            btn_EnviarLocacao.Location = new Point(702, 851);
            btn_EnviarLocacao.Name = "btn_EnviarLocacao";
            btn_EnviarLocacao.Size = new Size(94, 29);
            btn_EnviarLocacao.TabIndex = 40;
            btn_EnviarLocacao.Text = "Enviar";
            btn_EnviarLocacao.UseVisualStyleBackColor = false;
            btn_EnviarLocacao.Click += btn_EnviarLocacao_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(12, 831);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 39;
            label11.Text = "Mostrar:";
            // 
            // ckbox_DataLocacao
            // 
            ckbox_DataLocacao.AutoSize = true;
            ckbox_DataLocacao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ckbox_DataLocacao.Location = new Point(21, 854);
            ckbox_DataLocacao.Name = "ckbox_DataLocacao";
            ckbox_DataLocacao.Size = new Size(143, 24);
            ckbox_DataLocacao.TabIndex = 37;
            ckbox_DataLocacao.Text = "Data da Locação";
            ckbox_DataLocacao.UseVisualStyleBackColor = true;
            // 
            // ckbox_PrevisaoLocacao
            // 
            ckbox_PrevisaoLocacao.AutoSize = true;
            ckbox_PrevisaoLocacao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ckbox_PrevisaoLocacao.Location = new Point(170, 854);
            ckbox_PrevisaoLocacao.Name = "ckbox_PrevisaoLocacao";
            ckbox_PrevisaoLocacao.Size = new Size(219, 24);
            ckbox_PrevisaoLocacao.TabIndex = 38;
            ckbox_PrevisaoLocacao.Text = "Data Prevista da Devolução";
            ckbox_PrevisaoLocacao.UseVisualStyleBackColor = true;
            ckbox_PrevisaoLocacao.CheckedChanged += ckbox_ClassificacaoFilme_CheckedChanged;
            // 
            // ckbox_DevolucaoLocacao
            // 
            ckbox_DevolucaoLocacao.AutoSize = true;
            ckbox_DevolucaoLocacao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ckbox_DevolucaoLocacao.Location = new Point(395, 854);
            ckbox_DevolucaoLocacao.Name = "ckbox_DevolucaoLocacao";
            ckbox_DevolucaoLocacao.Size = new Size(161, 24);
            ckbox_DevolucaoLocacao.TabIndex = 41;
            ckbox_DevolucaoLocacao.Text = "Data da Devolução";
            ckbox_DevolucaoLocacao.UseVisualStyleBackColor = true;
            // 
            // ckbox_VlrTaxaLocacao
            // 
            ckbox_VlrTaxaLocacao.AutoSize = true;
            ckbox_VlrTaxaLocacao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ckbox_VlrTaxaLocacao.Location = new Point(557, 854);
            ckbox_VlrTaxaLocacao.Name = "ckbox_VlrTaxaLocacao";
            ckbox_VlrTaxaLocacao.Size = new Size(123, 24);
            ckbox_VlrTaxaLocacao.TabIndex = 42;
            ckbox_VlrTaxaLocacao.Text = "Valor da Taxa";
            ckbox_VlrTaxaLocacao.UseVisualStyleBackColor = true;
            // 
            // frm_Locacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 892);
            Controls.Add(ckbox_VlrTaxaLocacao);
            Controls.Add(ckbox_DevolucaoLocacao);
            Controls.Add(btn_EnviarLocacao);
            Controls.Add(label11);
            Controls.Add(ckbox_DataLocacao);
            Controls.Add(ckbox_PrevisaoLocacao);
            Controls.Add(txt_BuscarLocacao);
            Controls.Add(btn_BuscarLocacao);
            Controls.Add(label7);
            Controls.Add(gb_Filmes);
            Controls.Add(ts_Locacao);
            Controls.Add(ltview_BuscarLocacao);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frm_Locacao";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Locação";
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
        private TextBox txt_ValorMultaLocacao;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gb_Data;
        private ListView ltview_BuscarLocacao;
        private ImageList imageList1;
        private ToolStrip ts_Locacao;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbtn_inicio;
        private ToolStripButton tsbtn_voltar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripLabel tslbl_IDCount;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton tsbtn_frente;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton tsbtn_addLocacao;
        private ToolStripButton tsbtn_delLocacao;
        private ToolStripButton tsbtn_saveLocacao;
        private GroupBox gb_Filmes;
        private CheckBox ckbox_PesquisarCodFilme;
        private Button btn_PesquisarCodLocacao;
        private Label label01;
        private TextBox txt_CodLocacao;
        private Label label16;
        private ComboBox cbox_ClientesLocacao;
        private ComboBox cbox_FilmeLocacao;
        private MaskedTextBox msktxt_DataLocacao;
        private TextBox txt_PrecoLocacao;
        private Label label4;
        private MaskedTextBox msktxt_DataDevolucaoLocacao;
        private MaskedTextBox msktxt_DataPrevistaLocacao;
        private Label label5;
        private Label label8;
        private Label label6;
        private Label label18;
        private Button btn_LimparClientes;
        private TextBox txt_BuscarLocacao;
        private Button btn_BuscarLocacao;
        private Label label7;
        private CheckBox ckbox_DataDevolucaoLocacao;
        private Button btn_EnviarLocacao;
        private Label label11;
        private CheckBox ckbox_DataLocacao;
        private CheckBox ckbox_PrevisaoLocacao;
        private CheckBox ckbox_DevolucaoLocacao;
        private CheckBox ckbox_VlrTaxaLocacao;
    }
}