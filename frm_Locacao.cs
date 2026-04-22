using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Locadora
{
    public partial class frm_Locacao : Form
    {
        public frm_Locacao()
        {
            InitializeComponent();

            msktxt_DataLocacao.Text = DateTime.Now.ToString("yyyy-MM-dd");
            btn_PesquisarCodLocacao.Enabled = false;
            txt_CodLocacao.Enabled = false;

        }

        private void btn_PesquisarCodCliente_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ckbox_PesquisarCodFilme_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbox_PesquisarCodFilme.Checked)
            {
                cbox_FilmeLocacao.Enabled = false;
                cbox_ClientesLocacao.Enabled = false;
                txt_PrecoLocacao.Enabled = false;
                msktxt_DataLocacao.Enabled = false;
                msktxt_DataPrevistaLocacao.Enabled = false;
                msktxt_DataDevolucaoLocacao.Enabled = false;
                txt_ValorMultaLocacao.Enabled = false;

                btn_PesquisarCodLocacao.Enabled = true;
                txt_CodLocacao.Enabled = true;


            }
            else
            {
                cbox_FilmeLocacao.Enabled = true;
                cbox_ClientesLocacao.Enabled = true;
                txt_PrecoLocacao.Enabled = true;
                msktxt_DataLocacao.Enabled = true;
                msktxt_DataPrevistaLocacao.Enabled = true;
                msktxt_DataDevolucaoLocacao.Enabled = true;
                txt_ValorMultaLocacao.Enabled = true;

                btn_PesquisarCodLocacao.Enabled = false;
                txt_CodLocacao.Enabled = false;
            }
        }
    }
}
