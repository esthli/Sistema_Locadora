using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_Locadora
{
    public partial class frm_Locacao : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;port=3306;username=root;password=198219;database=Locadora";

        public frm_Locacao()
        {
            InitializeComponent();

            msktxt_DataLocacao.Text = DateTime.Now.ToString("yyyy-MM-dd");
            btn_PesquisarCodLocacao.Enabled = false;
            txt_CodLocacao.Enabled = false;
            msktxt_DataDevolucaoLocacao.Enabled = false;

            Conexao = new MySqlConnection(data_source);

            string query = "Select COUNT(id_locacao) FROM Locacao";

            Conexao.Open();
            MySqlCommand comando = new MySqlCommand(query, Conexao);
            int count = Convert.ToInt32(comando.ExecuteScalar());

            tslbl_IDCount.Text = $" de {count}";

            Conexao.Close();

            ltview_BuscarLocacao.View = View.Details;
            ltview_BuscarLocacao.LabelEdit = true;
            ltview_BuscarLocacao.AllowColumnReorder = true;
            ltview_BuscarLocacao.FullRowSelect = true;
            ltview_BuscarLocacao.GridLines = true;
            ltview_BuscarLocacao.Columns.Add("ID_Locação", 200, HorizontalAlignment.Left);
            ltview_BuscarLocacao.Columns.Add("Data Locação", 0, HorizontalAlignment.Left);
            ltview_BuscarLocacao.Columns.Add("Data Prevista Devolução", 0, HorizontalAlignment.Left);
            ltview_BuscarLocacao.Columns.Add("Data Devolução", 0, HorizontalAlignment.Left);
            ltview_BuscarLocacao.Columns.Add("Valor Multa", 0, HorizontalAlignment.Left);
            ltview_BuscarLocacao.Columns.Add("Cliente", 150, HorizontalAlignment.Left);
            ltview_BuscarLocacao.Columns.Add("Filme", 150, HorizontalAlignment.Left);


            // populate combo boxes when form is created
            LoadClientes();
            LoadFilmes();
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

        // Load clients into cbox_ClientesLocacao (DisplayMember = nome, ValueMember = id_cliente)
        private void LoadClientes()
        {
            try
            {
                using (var conn = new MySqlConnection(data_source))
                using (var adapter = new MySqlDataAdapter("SELECT id_cliente, nome FROM Cliente ORDER BY nome", conn))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    if (cbox_ClientesLocacao != null)
                    {
                        cbox_ClientesLocacao.DisplayMember = "nome";
                        cbox_ClientesLocacao.ValueMember = "id_cliente";
                        cbox_ClientesLocacao.DataSource = dt;
                        cbox_ClientesLocacao.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao carregar clientes: " + ex.Message);
            }
        }

        // Load films into cbox_FilmeLocacao (DisplayMember = titulo, ValueMember = id_filme)
        private void LoadFilmes()
        {
            try
            {
                using (var conn = new MySqlConnection(data_source))
                using (var adapter = new MySqlDataAdapter("SELECT id_filme, titulo FROM Filme ORDER BY titulo", conn))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    if (cbox_FilmeLocacao != null)
                    {
                        cbox_FilmeLocacao.DisplayMember = "titulo";
                        cbox_FilmeLocacao.ValueMember = "id_filme";
                        cbox_FilmeLocacao.DataSource = dt;
                        cbox_FilmeLocacao.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao carregar filmes: " + ex.Message);
            }
        }

        // Helpers to refresh lists from other forms after changes
        public void RefreshClientes() => LoadClientes();
        public void RefreshFilmes() => LoadFilmes();

        private void tsbtn_addLocacao_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a client is selected and obtain its id from the bound ValueMember
                if (cbox_ClientesLocacao == null || cbox_ClientesLocacao.SelectedValue == null)
                {
                    MessageBox.Show("Selecione um cliente antes de cadastrar a locação.");
                    return;
                }

                // Ensure a film is selected and obtain its id from the bound ValueMember
                if (cbox_FilmeLocacao == null || cbox_FilmeLocacao.SelectedValue == null)
                {
                    MessageBox.Show("Selecione um filme antes de cadastrar a locação.");
                    return;
                }

                // Use parameterized INSERT to avoid SQL injection
                Conexao = new MySqlConnection(data_source);
                string query = "INSERT INTO Locacao (id_cliente, id_filme, data_locacao, data_prevista_devolucao, data_devolucao, valor_multa, preco) " +
                               "VALUES (@id_cliente, @id_filme, @data_locacao, @data_prevista_devolucao, @data_devolucao, @valor_multa, @preco)";

                MySqlCommand comando = new MySqlCommand(query, Conexao);

                comando.Parameters.AddWithValue("@id_cliente", cbox_ClientesLocacao.SelectedValue);
                comando.Parameters.AddWithValue("@id_filme", cbox_FilmeLocacao.SelectedValue);

                // data_locacao
                if (DateTime.TryParse(msktxt_DataLocacao.Text, out DateTime dtLocacao))
                    comando.Parameters.AddWithValue("@data_locacao", dtLocacao);
                else
                    comando.Parameters.AddWithValue("@data_locacao", DBNull.Value);

                // data_prevista_devolucao
                if (DateTime.TryParse(msktxt_DataPrevistaLocacao.Text, out DateTime dtPrevista))
                    comando.Parameters.AddWithValue("@data_prevista_devolucao", dtPrevista);
                else
                    comando.Parameters.AddWithValue("@data_prevista_devolucao", DBNull.Value);

                // data_devolucao: if empty or unchecked send NULL to DB
                var devolucaoText = msktxt_DataDevolucaoLocacao.Text?.Trim() ?? string.Empty;
                if (!string.IsNullOrEmpty(devolucaoText) && DateTime.TryParse(devolucaoText, out DateTime dtDevolucao))
                {
                    comando.Parameters.AddWithValue("@data_devolucao", dtDevolucao);
                }
                else
                {
                    comando.Parameters.AddWithValue("@data_devolucao", DBNull.Value);
                }

                // valor_multa (optional) — send NULL if empty/invalid
                if (decimal.TryParse(txt_ValorMultaLocacao.Text, out decimal valorMulta))
                    comando.Parameters.AddWithValue("@valor_multa", valorMulta);
                else
                    comando.Parameters.AddWithValue("@valor_multa", DBNull.Value);

                // preco (required?) — send NULL if empty/invalid to avoid exceptions
                if (decimal.TryParse(txt_PrecoLocacao.Text, out decimal preco))
                    comando.Parameters.AddWithValue("@preco", preco);
                else
                    comando.Parameters.AddWithValue("@preco", DBNull.Value);

                Conexao.Open();
                comando.ExecuteNonQuery(); // use ExecuteNonQuery for INSERT

                MessageBox.Show("Locação cadastrada com sucesso!");

                Conexao = new MySqlConnection(data_source);

                string pedido = "Select COUNT(id_locacao) FROM Locacao";

                Conexao.Open();
                MySqlCommand command = new MySqlCommand(pedido, Conexao);
                int count = Convert.ToInt32(command.ExecuteScalar());

                tslbl_IDCount.Text = $" de {count}";

                Conexao.Close();
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
                txt_CodLocacao.Clear();
                msktxt_DataLocacao.Clear();
                msktxt_DataPrevistaLocacao.Clear();
                msktxt_DataDevolucaoLocacao.Clear();
                txt_PrecoLocacao.Clear();
                txt_ValorMultaLocacao.Clear();
                cbox_ClientesLocacao.SelectedIndex = -1;
                cbox_FilmeLocacao.SelectedIndex = -1;

                msktxt_DataLocacao.Text = DateTime.Now.ToString("yyyy-MM-dd");

            }
        }

        private void btn_PesquisarCodLocacao_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                string query = "SELECT Locacao.id_cliente, Locacao.id_filme, data_locacao, data_prevista_devolucao, data_devolucao, valor_multa, preco " +
                    " FROM Locacao " +
                    "Join Filme ON Filme.id_filme = locacao.id_filme " +
                    "Join Cliente ON Cliente.id_cliente = locacao.id_cliente " +
                    "WHERE id_locacao = " + Convert.ToInt32(txt_CodLocacao.Text);
                ;
                MySqlCommand comando = new MySqlCommand(query, Conexao);


                Conexao.Open();

                using (var reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Set selected values in combo boxes based on retrieved ids
                        // txt_CodLocacao.Text = reader["id_locacao"] != DBNull.Value ? reader["id_locacao"].ToString() : string.Empty;
                        cbox_ClientesLocacao.SelectedValue = reader["id_cliente"];
                        cbox_FilmeLocacao.SelectedValue = reader["id_filme"];
                        // Set masked textboxes and other fields
                        msktxt_DataLocacao.Text = reader["data_locacao"] != DBNull.Value ? Convert.ToDateTime(reader["data_locacao"]).ToString("yyyy-MM-dd") : string.Empty;
                        msktxt_DataPrevistaLocacao.Text = reader["data_prevista_devolucao"] != DBNull.Value ? Convert.ToDateTime(reader["data_prevista_devolucao"]).ToString("yyyy-MM-dd") : string.Empty;
                        msktxt_DataDevolucaoLocacao.Text = reader["data_devolucao"] != DBNull.Value ? Convert.ToDateTime(reader["data_devolucao"]).ToString("yyyy-MM-dd") : string.Empty;
                        txt_ValorMultaLocacao.Text = reader["valor_multa"] != DBNull.Value ? Convert.ToDecimal(reader["valor_multa"]).ToString("F2") : string.Empty;
                        txt_PrecoLocacao.Text = reader["preco"] != DBNull.Value ? Convert.ToDecimal(reader["preco"]).ToString("F2") : string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Locação não encontrada.");
                    }
                }



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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_LimparClientes_Click(object sender, EventArgs e)
        {
            txt_PrecoLocacao.Clear();
            msktxt_DataLocacao.Clear();
            msktxt_DataPrevistaLocacao.Clear();
            msktxt_DataDevolucaoLocacao.Clear();
            txt_ValorMultaLocacao.Clear();
            cbox_ClientesLocacao.SelectedIndex = -1;
            cbox_FilmeLocacao.SelectedIndex = -1;
        }

        private void ckbox_DataDevolucaoLocacao_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbox_DataDevolucaoLocacao.Checked)
            {
                msktxt_DataDevolucaoLocacao.Enabled = true;
            }
            else
            {
                msktxt_DataDevolucaoLocacao.Enabled = false;
                msktxt_DataDevolucaoLocacao.Text = msktxt_DataDevolucaoLocacao.Text.Replace(" ", ""); // Clear the masked textbox when unchecked   
            }
        }

        private void btn_BuscarLocacao_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                string query = "SELECT id_locacao, Cliente.id_cliente, Filme.id_filme, data_locacao, data_prevista_devolucao, data_devolucao, valor_multa, preco, filme.titulo, cliente.nome " +
              "FROM Locacao " +
              "JOIN Filme ON Filme.id_filme = locacao.id_filme " +
              "JOIN Cliente ON Cliente.id_cliente = locacao.id_cliente " +
              "WHERE Cliente.nome LIKe '%" + txt_BuscarLocacao.Text + "%'";

                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(query, Conexao);
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    ltview_BuscarLocacao.Items.Clear();
                    while (reader.Read())
                    {

                        string[] row = {
                           reader["id_locacao"] != DBNull.Value ? reader["id_locacao"].ToString() : string.Empty,
                           reader["data_locacao"] != DBNull.Value ? Convert.ToDateTime(reader["data_locacao"]).ToString("yyyy-MM-dd") : string.Empty,
                           reader["data_prevista_devolucao"] != DBNull.Value ? Convert.ToDateTime(reader["data_prevista_devolucao"]).ToString("yyyy-MM-dd") : string.Empty,
                           reader["data_devolucao"] != DBNull.Value ? Convert.ToDateTime(reader["data_devolucao"]).ToString("yyyy-MM-dd") : string.Empty,
                           reader["valor_multa"] != DBNull.Value ? Convert.ToDecimal(reader["valor_multa"]).ToString("F2") : string.Empty,
                           reader["nome"] != DBNull.Value ? reader["nome"].ToString() : string.Empty,
                           reader["titulo"] != DBNull.Value ? reader["titulo"].ToString() : string.Empty
                          };

                        var linhalista = new ListViewItem(row);
                        ltview_BuscarLocacao.Items.Add(linhalista);
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
                txt_BuscarLocacao.Clear();
            }
        }

        private void ckbox_ClassificacaoFilme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_EnviarLocacao_Click(object sender, EventArgs e)
        {
            SetColumnVisibility(1, ckbox_DataLocacao.Checked, 110); // Ano column
            SetColumnVisibility(2, ckbox_PrevisaoLocacao.Checked, 150);
            SetColumnVisibility(3, ckbox_DataDevolucaoLocacao.Checked, 250);
            SetColumnVisibility(4, ckbox_VlrTaxaLocacao.Checked, 150);
        }
        private void SetColumnVisibility(int index, bool visible, int width)
        {
            if (ltview_BuscarLocacao.Columns.Count > index)
                ltview_BuscarLocacao.Columns[index].Width = visible ? width : 0;
        }

        private void tsbtn_delLocacao_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                string query = "DELETE FROM Locacao WHERE id_locacao = @id_locacao";
                MySqlCommand comando = new MySqlCommand(query, Conexao);
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Tem certeza que deseja deletar esta locação?", "Confirmação de exclusão", buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    comando.Parameters.AddWithValue("@id_locacao", Convert.ToInt32(txt_CodLocacao.Text));
                    Conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Locação deletada com sucesso!");

                    string pedido = "Select COUNT(id_locacao) FROM Locacao";
                    MySqlCommand command = new MySqlCommand(pedido, Conexao);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    tslbl_IDCount.Text = $" de {count}";


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

                txt_CodLocacao.Clear();
                msktxt_DataLocacao.Clear();
                msktxt_DataPrevistaLocacao.Clear();
                msktxt_DataDevolucaoLocacao.Clear();
                txt_PrecoLocacao.Clear();
                txt_ValorMultaLocacao.Clear();
                cbox_ClientesLocacao.SelectedIndex = -1;
                cbox_FilmeLocacao.SelectedIndex = -1;

            }
        }

        private void tsbtn_saveLocacao_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                string query = "UPDATE Locacao SET " +
                               "data_prevista_devolucao = '"+ msktxt_DataPrevistaLocacao.Text+"', data_devolucao = '"+msktxt_DataLocacao.Text+"', valor_multa = "+Convert.ToDecimal(txt_ValorMultaLocacao.Text)+", preco = " + Convert.ToDecimal(txt_PrecoLocacao.Text) +
                               " WHERE id_locacao = " + Convert.ToInt32(txt_CodLocacao.Text);
                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(query, Conexao);
        
                comando.ExecuteNonQuery();
                MessageBox.Show("Locação atualizada com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                    Conexao.Close(); 
                txt_CodLocacao.Clear();
                msktxt_DataLocacao.Clear();
                msktxt_DataPrevistaLocacao.Clear();
                msktxt_DataDevolucaoLocacao.Clear();
                txt_PrecoLocacao.Clear();
                txt_ValorMultaLocacao.Clear();
                cbox_ClientesLocacao.SelectedIndex = -1;
                cbox_FilmeLocacao.SelectedIndex = -1;


            }
        }
    }
}

