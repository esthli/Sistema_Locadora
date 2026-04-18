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
            btn_PesquisarCodGenero.Enabled = false;
            btn_PesquisarCodFilme.Enabled = false;

            // load genres into combo box
            LoadGeneros();

            // list view Buscar Generos
            ltview_BuscarGeneros.View = View.Details;
            ltview_BuscarGeneros.LabelEdit = true;
            ltview_BuscarGeneros.AllowColumnReorder = true;
            ltview_BuscarGeneros.FullRowSelect = true;
            ltview_BuscarGeneros.GridLines = true;

            ltview_BuscarGeneros.Columns.Add("ID", 50, HorizontalAlignment.Left);
            ltview_BuscarGeneros.Columns.Add("Gênero", 200, HorizontalAlignment.Left);
            // list view Buscar Filmes
            ltview_BuscarFilme.View = View.Details;
            ltview_BuscarFilme.LabelEdit = true;
            ltview_BuscarFilme.AllowColumnReorder = true;
            ltview_BuscarFilme.FullRowSelect = true;
            ltview_BuscarFilme.GridLines = true;

            ltview_BuscarFilme.Columns.Add("ID", 50, HorizontalAlignment.Left);
            ltview_BuscarFilme.Columns.Add("Título", 200, HorizontalAlignment.Left);

            // add optional columns but keep them hidden by default (width = 0)
            ltview_BuscarFilme.Columns.Add("Gênero", 0, HorizontalAlignment.Left);
            ltview_BuscarFilme.Columns.Add("Ano", 0, HorizontalAlignment.Left);
            ltview_BuscarFilme.Columns.Add("Classificação", 0, HorizontalAlignment.Left);

        }

        private void tsbtn_addFilme_Click(object sender, EventArgs e)
        {
            if (tbctrl_Filmes.SelectedTab == tbpg_Filmes)
            {
                    try
                {
                    // Ensure a genre is selected and obtain its id from the bound ValueMember
                    if (cbox_GeneroFilme == null || cbox_GeneroFilme.SelectedValue == null)
                    {
                        MessageBox.Show("Selecione um gênero antes de cadastrar o filme.");
                        return;
                    }

                    if (!int.TryParse(cbox_GeneroFilme.SelectedValue.ToString(), out int id_g))
                    {
                        MessageBox.Show("ID do gênero inválido.");
                        return;
                    }

                    // Use parameterized INSERT to avoid SQL injection
                    Conexao = new MySqlConnection(data_source);
                    string query = "INSERT INTO Filme (Titulo, Ano, classificacao_indicativa, id_genero) " +
                                   "VALUES (@titulo, @ano, @classificacao, @idgenero)";

                    MySqlCommand comando = new MySqlCommand(query, Conexao);
                    comando.Parameters.AddWithValue("@titulo", txt_TituloFilme.Text);
                    comando.Parameters.AddWithValue("@ano", msktxt_AnoFilme.Text);
                    comando.Parameters.AddWithValue("@classificacao", cbox_ClassificacaoFilme.Text);
                    comando.Parameters.AddWithValue("@idgenero", id_g);

                    Conexao.Open();
                    comando.ExecuteNonQuery(); // use ExecuteNonQuery for INSERT

                    MessageBox.Show("Filme cadastrado com sucesso!");
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
                    txt_TituloFilme.Clear();
                    msktxt_AnoFilme.Clear();
                    cbox_ClassificacaoFilme.SelectedIndex = -1;
                    cbox_GeneroFilme.SelectedIndex = -1;
                }
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

                    txt_CodGeneroFilme.Clear();
                    txt_GeneroFilme.Clear();

                    // refresh combo box after insert
                    LoadGeneros();
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

                try
                {

                    //Criar a conexão com o banco de dados
                    Conexao = new MySqlConnection(data_source);
                    // MySQL uses LIKE (not iLIKE). Also consider parameterized queries to avoid SQL injection.
                    string query = "DELETE FROM Genero " +
                        "WHERE id_genero = " + Convert.ToInt32(txt_CodGeneroFilme.Text);
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    if (MessageBox.Show("Tem Certeza que deseja deletar este gênero? ID do gênero a ser deletado: " + txt_CodGeneroFilme.Text, "Confirmação de exclusão", buttons) == DialogResult.Yes)
                    {
                        Conexao.Open();

                        MySqlCommand comando = new MySqlCommand(query, Conexao);
                        comando.ExecuteNonQuery(); // use ExecuteNonQuery for DELETE

                        MessageBox.Show("Gênero deletado com sucesso!");

                        // refresh combo box after delete
                        LoadGeneros();
                    }
                    else
                    {
                        MessageBox.Show("Exclusão cancelada.");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (Conexao != null && Conexao.State == ConnectionState.Open)
                        Conexao.Close();

                    txt_CodGeneroFilme.Clear();
                    txt_GeneroFilme.Clear();



                }
            }
        }

        private void ckbox_PesquisarGenero_CheckedChanged(object sender, EventArgs e)
        {


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

                txt_BuscaGenero.Clear();
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

        private void btn_PesquisarCodGenero_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_CodGeneroFilme.Text, out int id))
            {
                MessageBox.Show("Informe um ID válido.");
                return;
            }

            try
            {
                using (Conexao = new MySqlConnection(data_source))
                using (var comando = new MySqlCommand(
                    "SELECT id_genero, nome_genero FROM genero WHERE id_genero = @id",
                    Conexao))

                {
                    comando.Parameters.AddWithValue("@id", id);
                    Conexao.Open();

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Map DB columns to the form controls (adjust names if your DB uses different column names)
                            txt_CodGeneroFilme.Text = reader["id_genero"]?.ToString() ?? "";
                            txt_GeneroFilme.Text = reader["nome_genero"]?.ToString() ?? "";



                        }
                        else
                        {
                            MessageBox.Show("Gênero não encontrado para o ID informado.");
                        }
                    }
                }
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

        private void btn_PesquisarCodFilme_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_CodFilme.Text, out int id))
            {
                MessageBox.Show("Informe um ID válido.");
                return;
            }
            try
            {
                using (Conexao = new MySqlConnection(data_source))
                using (var comando = new MySqlCommand(
                    "SELECT * FROM Filme WHERE id_filme = @id",
                    Conexao))

                {
                    comando.Parameters.AddWithValue("@id", id);
                    Conexao.Open();

                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Map DB columns to the form controls (adjust names if your DB uses different column names)
                            txt_CodFilme.Text = reader["id_filme"]?.ToString() ?? "";
                            txt_TituloFilme.Text = reader["titulo"]?.ToString() ?? "";
                            txt_GeneroFilme.Text = reader["id_genero"]?.ToString() ?? "";
                            msktxt_AnoFilme.Text = reader["ano"]?.ToString() ?? "";
                            cbox_ClassificacaoFilme.Text = reader["classificacao_indicativa"]?.ToString() ?? "";


                        }
                        else
                        {
                            MessageBox.Show("Gênero não encontrado para o ID informado.");
                        }
                    }
                }
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
        private void ckbox_PesquisarCodFilme_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbox_PesquisarCodFilme.Checked)
            {
                txt_CodFilme.Enabled = true;
                btn_PesquisarCodFilme.Enabled = true;

                txt_TituloFilme.Enabled = false;
                msktxt_AnoFilme.Enabled = false;
                cbox_ClassificacaoFilme.Enabled = false;
                cbox_GeneroFilme.Enabled = false;
            }
            else
            {
                txt_CodFilme.Enabled = false;
                btn_PesquisarCodFilme.Enabled = false;

                txt_TituloFilme.Enabled = true;
                msktxt_AnoFilme.Enabled = true;
                cbox_ClassificacaoFilme.Enabled = true;
                cbox_GeneroFilme.Enabled = true;
            }
        }

        private void btn_BuscarFilme_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                string query = "SELECT * FROM Filme " +
                               "WHERE titulo LIKE '%" + txt_TituloFilme.Text + "%'";

                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(query, Conexao);
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    ltview_BuscarFilme.Items.Clear();
                    while (reader.Read())
                    {
                        string[] row = {
                            Convert.ToString(reader.GetInt32(0)), // id_filme
                            Convert.ToString(reader.GetInt32(1)), // id_genero
                            reader.GetString(2), // titulo
                            reader.GetString(3), // ano
                            reader.GetString(4), // classificacao_indicativa
                           
                        };
                        var linhalista = new ListViewItem(row);
                        ltview_BuscarFilme.Items.Add(linhalista);
                    }
                }
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
        private void SetColumnVisibility(int index, bool visible, int width)
        {
            if (ltview_BuscarFilme.Columns.Count > index)
                ltview_BuscarFilme.Columns[index].Width = visible ? width : 0;
        }

        private void tsbtn_saveFilme_Click(object sender, EventArgs e)
        {
            if (tbctrl_Filmes.SelectedTab == tbpg_Filmes)
            {
                MessageBox.Show("Funcionalidade em desenvolvimento.");
            }
            else if (tbctrl_Filmes.SelectedTab == tbpg_Genero)
            {
                try
                {
                    Conexao = new MySqlConnection(data_source);
                    string query = "UPDATE Genero " +
                        "SET nome_genero = '" + txt_GeneroFilme.Text + "' " +
                        "WHERE id_genero = " + Convert.ToInt32(txt_CodGeneroFilme.Text);

                    Conexao.Open();
                    MySqlCommand comando = new MySqlCommand(query, Conexao);

                    comando.ExecuteNonQuery(); // use ExecuteNonQuery for UPDATE

                    MessageBox.Show("Genero atualizado com sucesso!");

                    // refresh combo box after update
                    LoadGeneros();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (Conexao != null && Conexao.State == ConnectionState.Open)
                        Conexao.Close();

                    txt_GeneroFilme.Clear();
                    txt_CodGeneroFilme.Clear();
                }
            }
        }

        private void btn_EnviarFilmes_Click_1(object sender, EventArgs e)
        {
            SetColumnVisibility(3, ckbox_AnoFilme.Checked, 110); // Ano column
            SetColumnVisibility(4, ckbox_Genero.Checked, 150);      // Genero column
            SetColumnVisibility(5, ckbox_ClassificacaoFilme.Checked, 120);   // Classificacao column
        }

        // Loads genres from database into cbox_GeneroFilme
        private void LoadGeneros()
        {
            try
            {
                using (var conn = new MySqlConnection(data_source))
                using (var adapter = new MySqlDataAdapter("SELECT id_genero, nome_genero FROM Genero ORDER BY nome_genero", conn))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    // Ensure combobox exists (Designer name must match)
                    if (cbox_GeneroFilme != null)
                    {
                        cbox_GeneroFilme.DisplayMember = "nome_genero";
                        cbox_GeneroFilme.ValueMember = "id_genero";
                        cbox_GeneroFilme.DataSource = dt;
                        cbox_GeneroFilme.SelectedIndex = -1; // no selection by default
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao carregar gêneros: " + ex.Message);
            }
        }
    }
}
