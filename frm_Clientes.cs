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
        MySqlConnection Conexao;

        public frm_Clientes()
        {
            InitializeComponent();
        }

        private void tsbtn_addCliente_Click(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost;port=3306;username=root;password=198219;database=Locadora";
            try
            {
                //Criar a conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                string query = "INSERT INTO Cliente (Nome, CPF, Telefone, Rua, Bairro, Cidade, CEP)" +
                    " VALUES" +
                    " ('"+txt_nomeCliente.Text+"', '"+msktxt_CPF.Text+"', '"+msktxt_Telefone.Text+"', '"+txt_Rua.Text+"', '"+txt_Bairro.Text+"', '"+txt_Cidade.Text+"', '"+txt_CEP.Text+"')";

                //Criar o comando SQL para inserir os dados do cliente
                MySqlCommand comando = new MySqlCommand(query, Conexao);
                Conexao.Open();
                comando.ExecuteReader();

                MessageBox.Show("Cliente cadastrado com sucesso!");

            } catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally {            
                Conexao.Close();
            }
        }


    }
}
