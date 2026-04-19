namespace Sistema_Locadora
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tsbtn_Clientes_Click(object sender, EventArgs e)
        {
            frm_Clientes Clientes = new frm_Clientes();
            Clientes.ShowDialog();

            /*if (ts_Clientes.Visible == true)
            {
                gb_Clientes.Visible = false;
                gb_Filmes.Visible = false;
                ts_Clientes.Visible = false;
            }

            else
            {
                gb_Clientes.Visible = true;
                ts_Clientes.Visible = true;
            }

            //  frm_Clientes frm_Clientes = new frm_Clientes(); 
            //  frm_Clientes.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            gb_Clientes.Visible = false;
            ts_Clientes.Visible = false;
            //  InitializeComponent();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
            if (ts_Clientes.Visible == true)
            {
                gb_Filmes.Visible = false;
                gb_Clientes.Visible = false;
                ts_Clientes.Visible = false;
            }
            else
            {
                gb_Filmes.Visible = true;
               ts_Clientes.Visible = true;
            }
    */

        }


        private void tsbtn_Filmes_Click(object sender, EventArgs e)
        {
            frm_Filmes filmes = new frm_Filmes();
            filmes.ShowDialog();
        }

        private void tsbtn_Locacao_Click(object sender, EventArgs e)
        {
            frm_Locacao locacao = new frm_Locacao();
            locacao.ShowDialog();
        }
    }
}
