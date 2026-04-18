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
    }
}
