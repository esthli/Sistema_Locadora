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

            ltview_BuscarClientes.Columns.Add("Nome", 200, HorizontalAlignment.Left);
            ltview_BuscarClientes.Columns.Add("cpf", 200, HorizontalAlignment.Left);
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
                txt_CEP.Clear();
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
                string query = "SELECT nome, cpf FROM Cliente " +
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
                            reader.GetString(0),
                            reader.GetString(1) };

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
    }
}