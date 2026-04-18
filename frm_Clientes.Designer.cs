
namespace Sistema_Locadora
{
    partial class frm_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Clientes));
            gb_Clientes = new GroupBox();
            btn_PesquisarCodCliente = new Button();
            ckbox_CodCliente = new CheckBox();
            msktxt_CEP = new MaskedTextBox();
            txt_Cidade = new TextBox();
            txt_Bairro = new TextBox();
            txt_Rua = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            msktxt_Telefone = new MaskedTextBox();
            txt_Endereco = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txt_codCliente = new TextBox();
            txt_nomeCliente = new TextBox();
            label1 = new Label();
            msktxt_CPF = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            ts_Clientes = new ToolStrip();
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
            tsbtn_addCliente = new ToolStripButton();
            tsbtn_delCliente = new ToolStripButton();
            tsbtn_saveCliente = new ToolStripButton();
            btn_PesquisarCliente = new Button();
            label10 = new Label();
            txt_BuscaCliente = new TextBox();
            ltview_BuscarClientes = new ListView();
            ckbox_Telefone = new CheckBox();
            ckbox_Rua = new CheckBox();
            ckbox_Bairro = new CheckBox();
            ckbox_Cidade = new CheckBox();
            ckbox_CEP = new CheckBox();
            label11 = new Label();
            btn_EnviarClientes = new Button();
            gb_Clientes.SuspendLayout();
            ts_Clientes.SuspendLayout();
            SuspendLayout();
            // 
            // gb_Clientes
            // 
            gb_Clientes.BackColor = SystemColors.ActiveCaption;
            gb_Clientes.Controls.Add(btn_PesquisarCodCliente);
            gb_Clientes.Controls.Add(ckbox_CodCliente);
            gb_Clientes.Controls.Add(msktxt_CEP);
            gb_Clientes.Controls.Add(txt_Cidade);
            gb_Clientes.Controls.Add(txt_Bairro);
            gb_Clientes.Controls.Add(txt_Rua);
            gb_Clientes.Controls.Add(label9);
            gb_Clientes.Controls.Add(label8);
            gb_Clientes.Controls.Add(label7);
            gb_Clientes.Controls.Add(label6);
            gb_Clientes.Controls.Add(msktxt_Telefone);
            gb_Clientes.Controls.Add(txt_Endereco);
            gb_Clientes.Controls.Add(label5);
            gb_Clientes.Controls.Add(label4);
            gb_Clientes.Controls.Add(txt_codCliente);
            gb_Clientes.Controls.Add(txt_nomeCliente);
            gb_Clientes.Controls.Add(label1);
            gb_Clientes.Controls.Add(msktxt_CPF);
            gb_Clientes.Controls.Add(label2);
            gb_Clientes.Controls.Add(label3);
            gb_Clientes.Location = new Point(12, 30);
            gb_Clientes.Name = "gb_Clientes";
            gb_Clientes.Size = new Size(690, 319);
            gb_Clientes.TabIndex = 11;
            gb_Clientes.TabStop = false;
            // 
            // btn_PesquisarCodCliente
            // 
            btn_PesquisarCodCliente.AutoSize = true;
            btn_PesquisarCodCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_PesquisarCodCliente.Enabled = false;
            btn_PesquisarCodCliente.Image = (Image)resources.GetObject("btn_PesquisarCodCliente.Image");
            btn_PesquisarCodCliente.Location = new Point(172, 29);
            btn_PesquisarCodCliente.Name = "btn_PesquisarCodCliente";
            btn_PesquisarCodCliente.Size = new Size(26, 26);
            btn_PesquisarCodCliente.TabIndex = 25;
            btn_PesquisarCodCliente.UseVisualStyleBackColor = true;
            btn_PesquisarCodCliente.Click += btn_PesquisarCodCliente_Click;
            // 
            // ckbox_CodCliente
            // 
            ckbox_CodCliente.AutoSize = true;
            ckbox_CodCliente.Location = new Point(210, 32);
            ckbox_CodCliente.Name = "ckbox_CodCliente";
            ckbox_CodCliente.Size = new Size(145, 24);
            ckbox_CodCliente.TabIndex = 24;
            ckbox_CodCliente.Text = "Pesquisar Código";
            ckbox_CodCliente.UseVisualStyleBackColor = true;
            ckbox_CodCliente.CheckedChanged += ckbox_CodCliente_CheckedChanged;
            // 
            // msktxt_CEP
            // 
            msktxt_CEP.Location = new Point(580, 103);
            msktxt_CEP.Mask = "00000-000";
            msktxt_CEP.Name = "msktxt_CEP";
            msktxt_CEP.Size = new Size(80, 27);
            msktxt_CEP.TabIndex = 18;
            msktxt_CEP.TextAlign = HorizontalAlignment.Center;
            msktxt_CEP.MaskInputRejected += msk_MaskInputRejected;
            // 
            // txt_Cidade
            // 
            txt_Cidade.Location = new Point(105, 249);
            txt_Cidade.Name = "txt_Cidade";
            txt_Cidade.Size = new Size(555, 27);
            txt_Cidade.TabIndex = 23;
            // 
            // txt_Bairro
            // 
            txt_Bairro.Location = new Point(105, 213);
            txt_Bairro.Name = "txt_Bairro";
            txt_Bairro.Size = new Size(555, 27);
            txt_Bairro.TabIndex = 22;
            // 
            // txt_Rua
            // 
            txt_Rua.Location = new Point(105, 180);
            txt_Rua.Name = "txt_Rua";
            txt_Rua.Size = new Size(555, 27);
            txt_Rua.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label9.Location = new Point(524, 106);
            label9.Name = "label9";
            label9.Size = new Size(50, 22);
            label9.TabIndex = 20;
            label9.Text = "CEP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label8.Location = new Point(22, 252);
            label8.Name = "label8";
            label8.Size = new Size(73, 22);
            label8.TabIndex = 19;
            label8.Text = "Cidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label7.Location = new Point(30, 216);
            label7.Name = "label7";
            label7.Size = new Size(64, 22);
            label7.TabIndex = 18;
            label7.Text = "Bairro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label6.Location = new Point(46, 183);
            label6.Name = "label6";
            label6.Size = new Size(46, 22);
            label6.TabIndex = 17;
            label6.Text = "Rua";
            // 
            // msktxt_Telefone
            // 
            msktxt_Telefone.Location = new Point(361, 103);
            msktxt_Telefone.Mask = "(99) 00000-0000";
            msktxt_Telefone.Name = "msktxt_Telefone";
            msktxt_Telefone.Size = new Size(125, 27);
            msktxt_Telefone.TabIndex = 16;
            msktxt_Telefone.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Endereco
            // 
            txt_Endereco.Location = new Point(105, 141);
            txt_Endereco.Name = "txt_Endereco";
            txt_Endereco.Size = new Size(555, 27);
            txt_Endereco.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label5.Location = new Point(9, 144);
            label5.Name = "label5";
            label5.Size = new Size(95, 22);
            label5.TabIndex = 14;
            label5.Text = "Endereço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label4.Location = new Point(266, 107);
            label4.Name = "label4";
            label4.Size = new Size(89, 22);
            label4.TabIndex = 13;
            label4.Text = "Telefone";
            // 
            // txt_codCliente
            // 
            txt_codCliente.Location = new Point(105, 29);
            txt_codCliente.Name = "txt_codCliente";
            txt_codCliente.ReadOnly = true;
            txt_codCliente.Size = new Size(61, 27);
            txt_codCliente.TabIndex = 11;
            txt_codCliente.TextChanged += txt_codCliente_TextChanged;
            // 
            // txt_nomeCliente
            // 
            txt_nomeCliente.Location = new Point(105, 66);
            txt_nomeCliente.Name = "txt_nomeCliente";
            txt_nomeCliente.Size = new Size(555, 27);
            txt_nomeCliente.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label1.Location = new Point(22, 32);
            label1.Name = "label1";
            label1.Size = new Size(73, 22);
            label1.TabIndex = 6;
            label1.Text = "Código";
            // 
            // msktxt_CPF
            // 
            msktxt_CPF.Location = new Point(105, 103);
            msktxt_CPF.Mask = "000\\.000\\.000-00";
            msktxt_CPF.Name = "msktxt_CPF";
            msktxt_CPF.Size = new Size(113, 27);
            msktxt_CPF.TabIndex = 9;
            msktxt_CPF.TextAlign = HorizontalAlignment.Center;
            msktxt_CPF.MaskInputRejected += msktxt_CPF_MaskInputRejected;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label2.Location = new Point(47, 106);
            label2.Name = "label2";
            label2.Size = new Size(49, 22);
            label2.TabIndex = 7;
            label2.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label3.Location = new Point(30, 69);
            label3.Name = "label3";
            label3.Size = new Size(61, 22);
            label3.TabIndex = 8;
            label3.Text = "Nome";
            // 
            // ts_Clientes
            // 
            ts_Clientes.ImageScalingSize = new Size(30, 30);
            ts_Clientes.Items.AddRange(new ToolStripItem[] { toolStripSeparator3, tsbtn_inicio, tsbtn_voltar, toolStripSeparator4, toolStripTextBox1, toolStripLabel1, toolStripSeparator5, tsbtn_frente, toolStripButton6, toolStripSeparator6, tsbtn_addCliente, tsbtn_delCliente, tsbtn_saveCliente });
            ts_Clientes.Location = new Point(0, 0);
            ts_Clientes.Name = "ts_Clientes";
            ts_Clientes.Size = new Size(721, 37);
            ts_Clientes.TabIndex = 12;
            ts_Clientes.Text = "toolStrip2";
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
            // tsbtn_addCliente
            // 
            tsbtn_addCliente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_addCliente.Image = (Image)resources.GetObject("tsbtn_addCliente.Image");
            tsbtn_addCliente.ImageTransparentColor = Color.Magenta;
            tsbtn_addCliente.Name = "tsbtn_addCliente";
            tsbtn_addCliente.Size = new Size(34, 34);
            tsbtn_addCliente.Text = "Adicionar Cliente";
            tsbtn_addCliente.Click += tsbtn_addCliente_Click;
            // 
            // tsbtn_delCliente
            // 
            tsbtn_delCliente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_delCliente.Image = (Image)resources.GetObject("tsbtn_delCliente.Image");
            tsbtn_delCliente.ImageTransparentColor = Color.Magenta;
            tsbtn_delCliente.Name = "tsbtn_delCliente";
            tsbtn_delCliente.Size = new Size(34, 34);
            tsbtn_delCliente.Text = "Apagar Cliente";
            tsbtn_delCliente.Click += tsbtn_delCliente_Click;
            // 
            // tsbtn_saveCliente
            // 
            tsbtn_saveCliente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbtn_saveCliente.Image = (Image)resources.GetObject("tsbtn_saveCliente.Image");
            tsbtn_saveCliente.ImageTransparentColor = Color.Magenta;
            tsbtn_saveCliente.Name = "tsbtn_saveCliente";
            tsbtn_saveCliente.Size = new Size(34, 34);
            tsbtn_saveCliente.Text = "Salvar Cliente";
            // 
            // btn_PesquisarCliente
            // 
            btn_PesquisarCliente.BackColor = SystemColors.ActiveBorder;
            btn_PesquisarCliente.FlatStyle = FlatStyle.System;
            btn_PesquisarCliente.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_PesquisarCliente.ForeColor = Color.DarkGray;
            btn_PesquisarCliente.Location = new Point(582, 399);
            btn_PesquisarCliente.Name = "btn_PesquisarCliente";
            btn_PesquisarCliente.Size = new Size(120, 27);
            btn_PesquisarCliente.TabIndex = 13;
            btn_PesquisarCliente.Text = "Pesquisar";
            btn_PesquisarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_PesquisarCliente.UseVisualStyleBackColor = false;
            btn_PesquisarCliente.Click += btn_PesquisarCliente_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label10.Location = new Point(16, 371);
            label10.Name = "label10";
            label10.Size = new Size(147, 22);
            label10.TabIndex = 14;
            label10.Text = "Buscar Cliente:";
            label10.Click += label10_Click;
            // 
            // txt_BuscaCliente
            // 
            txt_BuscaCliente.Location = new Point(16, 399);
            txt_BuscaCliente.Name = "txt_BuscaCliente";
            txt_BuscaCliente.Size = new Size(560, 27);
            txt_BuscaCliente.TabIndex = 15;
            txt_BuscaCliente.TextChanged += txt_BuscaCliente_TextChanged;
            // 
            // ltview_BuscarClientes
            // 
            ltview_BuscarClientes.Location = new Point(16, 436);
            ltview_BuscarClientes.Name = "ltview_BuscarClientes";
            ltview_BuscarClientes.Size = new Size(686, 250);
            ltview_BuscarClientes.TabIndex = 17;
            ltview_BuscarClientes.UseCompatibleStateImageBehavior = false;
            // 
            // ckbox_Telefone
            // 
            ckbox_Telefone.AutoSize = true;
            ckbox_Telefone.Location = new Point(21, 712);
            ckbox_Telefone.Name = "ckbox_Telefone";
            ckbox_Telefone.Size = new Size(88, 24);
            ckbox_Telefone.TabIndex = 18;
            ckbox_Telefone.Text = "Telefone";
            ckbox_Telefone.UseVisualStyleBackColor = true;
            // 
            // ckbox_Rua
            // 
            ckbox_Rua.AutoSize = true;
            ckbox_Rua.Location = new Point(115, 712);
            ckbox_Rua.Name = "ckbox_Rua";
            ckbox_Rua.Size = new Size(56, 24);
            ckbox_Rua.TabIndex = 19;
            ckbox_Rua.Text = "Rua";
            ckbox_Rua.UseVisualStyleBackColor = true;
            // 
            // ckbox_Bairro
            // 
            ckbox_Bairro.AutoSize = true;
            ckbox_Bairro.Location = new Point(177, 712);
            ckbox_Bairro.Name = "ckbox_Bairro";
            ckbox_Bairro.Size = new Size(71, 24);
            ckbox_Bairro.TabIndex = 20;
            ckbox_Bairro.Text = "Bairro";
            ckbox_Bairro.UseVisualStyleBackColor = true;
            // 
            // ckbox_Cidade
            // 
            ckbox_Cidade.AutoSize = true;
            ckbox_Cidade.Location = new Point(254, 712);
            ckbox_Cidade.Name = "ckbox_Cidade";
            ckbox_Cidade.Size = new Size(78, 24);
            ckbox_Cidade.TabIndex = 21;
            ckbox_Cidade.Text = "Cidade";
            ckbox_Cidade.UseVisualStyleBackColor = true;
            // 
            // ckbox_CEP
            // 
            ckbox_CEP.AutoSize = true;
            ckbox_CEP.Location = new Point(338, 712);
            ckbox_CEP.Name = "ckbox_CEP";
            ckbox_CEP.Size = new Size(56, 24);
            ckbox_CEP.TabIndex = 22;
            ckbox_CEP.Text = "CEP";
            ckbox_CEP.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 689);
            label11.Name = "label11";
            label11.Size = new Size(63, 20);
            label11.TabIndex = 23;
            label11.Text = "Mostrar:";
            // 
            // btn_EnviarClientes
            // 
            btn_EnviarClientes.Location = new Point(400, 709);
            btn_EnviarClientes.Name = "btn_EnviarClientes";
            btn_EnviarClientes.Size = new Size(94, 29);
            btn_EnviarClientes.TabIndex = 24;
            btn_EnviarClientes.Text = "Enviar";
            btn_EnviarClientes.UseVisualStyleBackColor = true;
            btn_EnviarClientes.Click += btn_EnviarClientes_Click;
            // 
            // frm_Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 741);
            Controls.Add(btn_EnviarClientes);
            Controls.Add(label11);
            Controls.Add(ckbox_CEP);
            Controls.Add(ckbox_Cidade);
            Controls.Add(ckbox_Bairro);
            Controls.Add(ckbox_Rua);
            Controls.Add(ckbox_Telefone);
            Controls.Add(ltview_BuscarClientes);
            Controls.Add(txt_BuscaCliente);
            Controls.Add(label10);
            Controls.Add(btn_PesquisarCliente);
            Controls.Add(ts_Clientes);
            Controls.Add(gb_Clientes);
            Name = "frm_Clientes";
            Text = "Clientes";
            gb_Clientes.ResumeLayout(false);
            gb_Clientes.PerformLayout();
            ts_Clientes.ResumeLayout(false);
            ts_Clientes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void txt_codCliente_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
           // txt_codCliente
        }

        #endregion

        private GroupBox gb_Clientes;
        private TextBox txt_Cidade;
        private TextBox txt_Bairro;
        private TextBox txt_Rua;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private MaskedTextBox msktxt_Telefone;
        private TextBox txt_Endereco;
        private Label label5;
        private Label label4;
        private TextBox txt_codCliente;
        private TextBox txt_nomeCliente;
        private Label label1;
        private MaskedTextBox msktxt_CPF;
        private Label label2;
        private Label label3;
        private ToolStrip ts_Clientes;
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
        private ToolStripButton tsbtn_addCliente;
        private ToolStripButton tsbtn_delCliente;
        private ToolStripButton tsbtn_saveCliente;
        private Button btn_PesquisarCliente;
        private Label label10;
        private TextBox txt_BuscaCliente;
        private ListView ltview_BuscarClientes;
        private MaskedTextBox msktxt_CEP;
        private CheckBox ckbox_Telefone;
        private CheckBox ckbox_Rua;
        private CheckBox ckbox_Bairro;
        private CheckBox ckbox_Cidade;
        private CheckBox ckbox_CEP;
        private Label label11;
        private Button btn_EnviarClientes;
        private CheckBox ckbox_CodCliente;
        private Button btn_PesquisarCodCliente;
    }
}