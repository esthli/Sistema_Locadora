using MySql.Data.MySqlClient;
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
    public partial class frm_Filmes : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;port=3306;username=root;password=198219;database=Locadora";
        public frm_Filmes()
        {
            InitializeComponent();

            ltview_BuscarGeneros.View = View.Details;
            ltview_BuscarGeneros.LabelEdit = true;
            ltview_BuscarGeneros.AllowColumnReorder = true;
            ltview_BuscarGeneros.FullRowSelect = true;
            ltview_BuscarGeneros.GridLines = true;

            ltview_BuscarGeneros.Columns.Add("ID", 50, HorizontalAlignment.Left);
            ltview_BuscarGeneros.Columns.Add("Gênero", 200, HorizontalAlignment.Left);
        }

        private void tsbtn_addFilme_Click(object sender, EventArgs e)
        {
            if (tbctrl_Filmes.SelectedTab == tbpg_Filmes)
            {
                /*
                try
                {
                    
                    //Criar a conexão com o banco de dados
                    Conexao = new MySqlConnection(data_source);
                    string query = "INSERT INTO Filme (Titulo, Ano, classificacao_indicativa, id_genero)" +
                        " VALUES" +
                        " ('" + txt_TituloFilme.Text + "', '" + msktxt_AnoFilme.Text + "', '" + cbox_ClassificacaoFilme.Text + "', '" + txt_IdGenero.Text + "')";

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



                }*/
                MessageBox.Show("Funcionalidade em desenvolvimento.");

            }
            else if (tbctrl_Filmes.SelectedTab == tbpg_Genero)
            {

                try
                {
                    //Criar a conexão com o banco de dados
                    Conexao = new MySqlConnection(data_source);
                    string query = "INSERT INTO Genero (nome_genero)" +
                        " VALUES" +
                        " ('" + txt_GeneroFilme.Text + "')";

                    //Criar o comando SQL para inserir os dados do cliente
                    MySqlCommand comando = new MySqlCommand(query, Conexao);
                    Conexao.Open();
                    comando.ExecuteNonQuery(); // use ExecuteNonQuery for INSERT

                    MessageBox.Show("Gênero adicionado com sucesso!");
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



                }
            }






        }


        private void tbctrl_Filmes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsbtn_delFilme_Click(object sender, EventArgs e)
        {



            if (tbctrl_Filmes.SelectedTab == tbpg_Filmes)
            {
                MessageBox.Show("Funcionalidade em desenvolvimento.");
            }
            else if (tbctrl_Filmes.SelectedTab == tbpg_Genero)
            {
                /*
                try
                {

                    //Criar a conexão com o banco de dados
                    Conexao = new MySqlConnection(data_source);
                    // MySQL uses LIKE (not iLIKE). Also consider parameterized queries to avoid SQL injection.
                    string query = "DELETE FROM Genero " +
                        "WHERE id_genero = " + Convert.ToInt32(txt_codGenero.Text);

                    Conexao.Open();

                    MySqlCommand comando = new MySqlCommand(query, Conexao);
                    comando.ExecuteNonQuery(); // use ExecuteNonQuery for DELETE

                    MessageBox.Show("Cliente deletado com sucesso!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (Conexao != null && Conexao.State == ConnectionState.Open)
                        Conexao.Close();



                    txt_codCliente.Clear();
                    txt_nomeCliente.Clear();
                    msktxt_CPF.Clear();
                    msktxt_CEP.Clear();
                    msktxt_Telefone.Clear();
                    txt_Rua.Clear();
                    txt_Bairro.Clear();
                    txt_Cidade.Clear();

                }*/
            }
        }

        private void ckbox_PesquisarGenero_CheckedChanged(object sender, EventArgs e)
        {
            btn_PesquisarCodGenero.Enabled = false;

            if (ckbox_PesquisarGenero.Checked)
            {
                txt_CodGeneroFilme.Enabled = true;
                txt_GeneroFilme.Enabled = false;
                btn_PesquisarCodGenero.Enabled = true;
            }
            else
            {
                txt_CodGeneroFilme.Enabled = false;
                txt_GeneroFilme.Enabled = true;
                btn_PesquisarCodGenero.Enabled = false;
            }
        }

        private void btn_PesquisarGenero_Click(object sender, EventArgs e)
        {
            
            try
            {
                //Criar a conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                // MySQL uses LIKE (not iLIKE). Also consider parameterized queries to avoid SQL injection.
                string query = "SELECT * FROM Genero " +
                    "WHERE nome_genero LIKE '%" + txt_BuscaGenero.Text + "%'";

                Conexao.Open();

                //Criar o comando SQL para selecionar os dados do cliente
                MySqlCommand comando = new MySqlCommand(query, Conexao);

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    ltview_BuscarGeneros.Items.Clear();

                    while (reader.Read())
                    {
                        string[] row = {
                            Convert.ToString(reader.GetInt32(0)),
                            reader.GetString(1)
                        };

                        var linhalista = new ListViewItem(row);
                        ltview_BuscarGeneros.Items.Add(linhalista);
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
    }
}
