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
            ltview_BuscarFilme.Columns.Add("ID_Gênero", 0, HorizontalAlignment.Left);
            ltview_BuscarFilme.Columns.Add("Ano", 0, HorizontalAlignment.Left);
            ltview_BuscarFilme.Columns.Add("Classificação", 0, HorizontalAlignment.Left);
            ltview_BuscarFilme.Columns.Add("Gênero", 150, HorizontalAlignment.Left);


            Conexao = new MySqlConnection(data_source);
            string query = "SELECT COUNT(id_filme) FROM Filme; ";
            Conexao.Open();

            MySqlCommand comando = new MySqlCommand(query, Conexao);

            using (MySqlDataReader reader = comando.ExecuteReader())
            {
                if (reader.Read())
                {
                    tslbl_Filmes.Text = " de " + reader.GetInt32(0).ToString();
                }
            }

            Conexao.Close();
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

                    Conexao = new MySqlConnection(data_source);

                    string pedido = "Select COUNT(id_filme) FROM Filme";

                    Conexao.Open();
                    MySqlCommand command = new MySqlCommand(pedido, Conexao);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    tslbl_Filmes.Text = $" de {count}";
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

                    Conexao = new MySqlConnection(data_source);
                    string pedido = "SELECT COUNT(id_genero) FROM Genero";
                    Conexao.Open();
                    MySqlCommand command = new MySqlCommand(pedido, Conexao);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    Conexao.Close();
                    tslbl_Filmes.Text = $" de {count}";

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
            if (tbctrl_Filmes.SelectedTab == tbpg_Genero)
            {
                Conexao = new MySqlConnection(data_source);
                string query = "SELECT COUNT(id_genero) FROM Genero";
                Conexao.Open();
                MySqlCommand command = new MySqlCommand(query, Conexao);
                int count = Convert.ToInt32(command.ExecuteScalar());
                Conexao.Close();
                tslbl_Filmes.Text = $" de {count}";
            }
            else if (tbctrl_Filmes.SelectedTab == tbpg_Filmes)
            {
                Conexao = new MySqlConnection(data_source);
                string query = "SELECT COUNT(id_filme) FROM Filme";
                Conexao.Open();
                MySqlCommand command = new MySqlCommand(query, Conexao);
                int count = Convert.ToInt32(command.ExecuteScalar());
                Conexao.Close();
                tslbl_Filmes.Text = $" de {count}";
            }
        }

        private void tsbtn_delFilme_Click(object sender, EventArgs e)
        {
            if (tbctrl_Filmes.SelectedTab == tbpg_Filmes)
            {
                // validate id first
                if (!int.TryParse(txt_CodFilme.Text?.Trim(), out int idToDelete))
                {
                    MessageBox.Show("Informe um ID válido para exclusão.");
                    return;
                }

                var buttons = MessageBoxButtons.YesNo;
                if (MessageBox.Show("Tem Certeza que deseja deletar este filme? ID do filme a ser deletado: " + idToDelete, "Confirmação de exclusão", buttons) != DialogResult.Yes)
                {
                    MessageBox.Show("Exclusão cancelada.");
                    return;
                }

                try
                {
                    // Use a single connection and parameterized queries; dispose with using
                    using (var conn = new MySqlConnection(data_source))
                    {
                        conn.Open();

                        using (var delCmd = new MySqlCommand("DELETE FROM Filme WHERE id_filme = @id", conn))
                        {
                            delCmd.Parameters.AddWithValue("@id", idToDelete);
                            int rowsAffected = delCmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                                MessageBox.Show("Filme deletado com sucesso!");
                            else
                                MessageBox.Show("Nenhum filme encontrado com o ID informado.");
                        }

                        // update count using same open connection
                        using (var countCmd = new MySqlCommand("SELECT COUNT(id_filme) FROM Filme", conn))
                        {
                            int count = Convert.ToInt32(countCmd.ExecuteScalar());
                            tslbl_Filmes.Text = $" de {count}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    // show concrete error to help debugging instead of generic ID message
                    MessageBox.Show("Ocorreu um erro ao tentar deletar: " + ex.Message);
                }
                finally
                {
                    txt_CodFilme.Clear();
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

                    Conexao = new MySqlConnection(data_source);
                    string pedido = "SELECT COUNT(id_genero) FROM Genero";
                    Conexao.Open();
                    MySqlCommand command = new MySqlCommand(pedido, Conexao);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    Conexao.Close();
                    tslbl_Filmes.Text = $" de {count}";

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
                    "SELECT id_filme, titulo, id_genero, ano, classificacao_indicativa FROM Filme WHERE id_filme = @id",
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

                            // convert id_genero to corresponding nome_genero in the ComboBox
                            var idGeneroObj = reader["id_genero"];
                            if (idGeneroObj != DBNull.Value && int.TryParse(idGeneroObj.ToString(), out int id_g))
                            {
                                // make sure genres are loaded so SelectedValue works
                                if (cbox_GeneroFilme != null && cbox_GeneroFilme.DataSource == null)
                                    LoadGeneros();

                                if (cbox_GeneroFilme != null)
                                {
                                    // set SelectedValue to the id so the combobox shows the nome_genero
                                    cbox_GeneroFilme.SelectedValue = id_g;
                                }
                            }
                            else
                            {
                                if (cbox_GeneroFilme != null)
                                    cbox_GeneroFilme.SelectedIndex = -1;
                            }

                            msktxt_AnoFilme.Text = reader["ano"]?.ToString() ?? "";
                            cbox_ClassificacaoFilme.Text = reader["classificacao_indicativa"]?.ToString() ?? "";
                        }
                        else
                        {
                            MessageBox.Show("Filme não encontrado para o ID informado.");
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
                string query = "SELECT id_filme, titulo, Filme.id_genero, ano, classificacao_indicativa, nome_genero FROM Filme " +
                    "JOIN Genero ON Filme.id_genero = Genero.id_genero " +
                               "WHERE titulo LIKE '%" + txt_BuscarFIlme.Text + "%'";

                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(query, Conexao);
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    ltview_BuscarFilme.Items.Clear();
                    while (reader.Read())
                    {

                        string[] row = {
                            Convert.ToString(reader.GetInt32(0)), // id_filme
                            reader.GetString(1), // titulo
                            Convert.ToString(reader.GetInt32(2)), // id_genero
                            Convert.ToString(reader.GetInt32(3)), // ano
                            reader.GetString(4), //  classificacao_indicativa
                            reader.GetString(5), // nome_genero

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
                txt_BuscarFIlme.Clear();
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
                try
                {
                    Conexao = new MySqlConnection(data_source);
                    string query = "UPDATE Filme " +
                        "SET titulo = '" + txt_TituloFilme.Text + "'," +
                        "ano = '" + msktxt_AnoFilme.Text + "'," +
                        "classificacao_indicativa = '" + cbox_ClassificacaoFilme.SelectedItem + "'," +
                        "id_genero = '" + cbox_GeneroFilme.SelectedValue + "'" +
                        "WHERE id_filme = " + Convert.ToInt32(txt_CodFilme.Text);

                    MySqlCommand comando = new MySqlCommand(query, Conexao);
                    Conexao.Open();
                    comando.ExecuteNonQuery(); // use ExecuteNonQuery for UPDATE
                    MessageBox.Show("Filme atualizado com sucesso!");
                }
                catch
                {
                    MessageBox.Show("Informe um ID válido para atualização.");
                }
                finally
                {
                    if (Conexao != null && Conexao.State == ConnectionState.Open)
                        Conexao.Close();
                    txt_CodFilme.Clear();
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
            SetColumnVisibility(4, ckbox_ClassificacaoFilme.Checked, 150);      // Classificacao column
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

        private void cbox_GeneroFilme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_LimparClientes_Click(object sender, EventArgs e)
        {
            cbox_ClassificacaoFilme.SelectedIndex = -1;
            cbox_GeneroFilme.SelectedIndex = -1;
            txt_TituloFilme.Clear();
            msktxt_AnoFilme.Clear();
            ckbox_PesquisarCodFilme.Checked = false;
        }

        private void ckbox_ClassificacaoFilme_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
