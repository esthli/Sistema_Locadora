using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_Locadora
{
    public partial class frm_Clientes : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;port=3306;username=root;password=198219;database=Locadora";

        public frm_Clientes()
        {
            InitializeComponent();
            ltview_BuscarClientes.View = View.Details;
            ltview_BuscarClientes.LabelEdit = true;
            ltview_BuscarClientes.AllowColumnReorder = true;
            ltview_BuscarClientes.FullRowSelect = true;
            ltview_BuscarClientes.GridLines = true;

            ltview_BuscarClientes.Columns.Add("ID", 50, HorizontalAlignment.Left);
            ltview_BuscarClientes.Columns.Add("Nome", 200, HorizontalAlignment.Left);
            ltview_BuscarClientes.Columns.Add("CPF", 115, HorizontalAlignment.Left);

            // add optional columns but keep them hidden by default (width = 0)
            ltview_BuscarClientes.Columns.Add("Telefone", 0, HorizontalAlignment.Left);
            ltview_BuscarClientes.Columns.Add("Rua", 0, HorizontalAlignment.Left);
            ltview_BuscarClientes.Columns.Add("Bairro", 0, HorizontalAlignment.Left);
            ltview_BuscarClientes.Columns.Add("Cidade", 0, HorizontalAlignment.Left);
            ltview_BuscarClientes.Columns.Add("CEP", 0, HorizontalAlignment.Left);
        }

        private void tsbtn_addCliente_Click(object sender, EventArgs e)

        {
            string trocarNumero = msktxt_Telefone.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            string trocarCpf = msktxt_CPF.Text.Replace("-", "").Replace(".", "");
            string trocarCEP = msktxt_CEP.Text.Replace("-", "");

            try
            {
                //Criar a conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                string query = "INSERT INTO Cliente (Nome, CPF, Telefone, Rua, Bairro, Cidade, CEP)" +
                    " VALUES" +
                    " ('" + txt_nomeCliente.Text + "', '" + trocarCpf + "', '" + trocarNumero + "', '" + txt_Rua.Text + "', '" + txt_Bairro.Text + "', '" + txt_Cidade.Text + "', '" + trocarCEP + "')";

                //Criar o comando SQL para inserir os dados do cliente
                MySqlCommand comando = new MySqlCommand(query, Conexao);
                Conexao.Open();
                comando.ExecuteNonQuery(); // use ExecuteNonQuery for INSERT

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Safe close: avoid NullReferenceException if Conexao is null
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                    Conexao.Close();

                txt_Bairro.Clear();
                msktxt_CEP.Clear();
                txt_Cidade.Clear();
                txt_Rua.Clear();
                txt_nomeCliente.Clear();
                msktxt_CPF.Clear();
                msktxt_Telefone.Clear();
                txt_Endereco.Clear();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_BuscaCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // If you will search while typing, call the search logic here.
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Use a safe close in case Conexao was used elsewhere
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                    Conexao.Close();
            }
        }

        private void btn_PesquisarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //Criar a conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                // MySQL uses LIKE (not iLIKE). Also consider parameterized queries to avoid SQL injection.
                string query = "SELECT * FROM Cliente " +
                    "WHERE nome LIKE '%" + txt_BuscaCliente.Text + "%'";

                Conexao.Open();

                //Criar o comando SQL para selecionar os dados do cliente
                MySqlCommand comando = new MySqlCommand(query, Conexao);

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    ltview_BuscarClientes.Items.Clear();

                    while (reader.Read())
                    {
                        string[] row = {
                            Convert.ToString(reader.GetInt32(0)),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetString(5),
                            reader.GetString(6),
                            reader.GetString(7)
                        };

                        var linhalista = new ListViewItem(row);
                        ltview_BuscarClientes.Items.Add(linhalista);
                    }
                }

                // removed duplicate comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                    Conexao.Close();
            }
        }

        private void tsbtn_delCliente_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                //Criar a conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                // MySQL uses LIKE (not iLIKE). Also consider parameterized queries to avoid SQL injection.
                string query = "DELETE FROM Cliente " +
                    "WHERE nome LIKE '%" + txt_BuscaCliente.Text + "%'";

                Conexao.Open();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                    Conexao.Close();
            }
        }

        private void msktxt_CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void msk_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        // helper and button handler
        private void SetColumnVisibility(int index, bool visible, int width)
        {
            if (ltview_BuscarClientes.Columns.Count > index)
                ltview_BuscarClientes.Columns[index].Width = visible ? width : 0;
        }

        private void btn_EnviarClientes_Click(object sender, EventArgs e)
        {
            // adjust widths as needed for your layout
            SetColumnVisibility(3, ckbox_Telefone.Checked, 110); // Telefone column
            SetColumnVisibility(4, ckbox_Rua.Checked, 150);      // Rua column
            SetColumnVisibility(5, ckbox_Bairro.Checked, 120);   // Bairro column
            SetColumnVisibility(6, ckbox_Cidade.Checked, 120);   // Cidade column
            SetColumnVisibility(7, ckbox_CEP.Checked, 80);       // CEP column
        }

        private void ckbox_CodCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbox_CodCliente.Checked)
            {
                txt_codCliente.ReadOnly = false;
                txt_Bairro.ReadOnly = true;
                txt_Cidade.ReadOnly = true;
                msktxt_CEP.ReadOnly = true;
                msktxt_CPF.ReadOnly = true;
                msktxt_Telefone.ReadOnly = true;
                txt_nomeCliente.ReadOnly = true;
                txt_Endereco.ReadOnly = true;
                txt_Rua.ReadOnly = true;
                btn_PesquisarCodCliente.Enabled = true;

            }
            else
            {
                txt_codCliente.ReadOnly = true;
                txt_Bairro.ReadOnly = false;
                txt_Cidade.ReadOnly = false;
                msktxt_CEP.ReadOnly = false;
                msktxt_CPF.ReadOnly = false;
                msktxt_Telefone.ReadOnly = false;
                txt_nomeCliente.ReadOnly = false;
                txt_Endereco.ReadOnly = false;
                txt_Rua.ReadOnly = false;
                btn_PesquisarCodCliente.Enabled = false;

            }
        }

        private void btn_PesquisarCodCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                string query = "SELECT * FROM Cliente " +
                    "WHERE id_cliente = " + Convert.ToInt32(txt_codCliente.Text);

                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(query, Conexao);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                    Conexao.Close();
            }
        }
    }
}