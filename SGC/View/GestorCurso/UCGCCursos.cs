using MySql.Data.MySqlClient;
using System;
using SGC.Helppers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace SGC.View
{
    public partial class UCGCCursos : UserControl
    {
        string conn = $"{Helppers.conexao.connectionString}";
        public UCGCCursos()
        {
            InitializeComponent();
        }

        public void verdados()
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();

                string query = "SELECT * FROM cursos";

                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                connection.Close();

                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["cordenadorID"].Visible = false;
                dataGridView1.Columns["id"].Visible = false;


            }
        }

        private void UCGCCursos_Load(object sender, EventArgs e)
        {
            cbcordenador.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();
                string queryc = "SELECT nome FROM docentes";

                MySqlCommand commandc = new MySqlCommand(queryc, connection);

                using (MySqlDataReader reader = commandc.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        cbcordenador.Items.Add(reader["nome"].ToString());

                    }

                }

            }
            verdados();
        }

        public void limpardados()
        {
            cbcordenador.Text = "";
            txtnome.Text = "";
            cbnivel.Text = "";
            cbperiodo.Text = "";
           
        }
        private void btcadastrar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "" || cbnivel.Text == "" || cbperiodo.Text == "")
            {

                Session.Error = "Por favor, preenche todos os campos!";
                FormError formError = new FormError();
                formError.ShowDialog();

            }
            else
            {
                try
                {
                    using (MySqlConnection connection1 = new MySqlConnection(conn))
                    {
                        if (connection1 != null)
                        {
                            connection1.Close();
                        }
                        connection1.Open();
                        string queryVerificar = "SELECT COUNT(*) FROM cursos WHERE Nome = @nn";
                        MySqlCommand commandVerificar = new MySqlCommand(queryVerificar, connection1);

                        commandVerificar.Parameters.AddWithValue("@nn", txtnome.Text);
                        int count = Convert.ToInt32(commandVerificar.ExecuteScalar());

                        if (count > 0)
                        {
                            Session.Error = "O nome da Diciplina Já existe, Tente com outro nome!";
                            FormError erro = new FormError();
                            erro.ShowDialog();
                        }
                        else
                        {
                            using (MySqlConnection connection = new MySqlConnection(conn))
                            {

                                if (connection != null)
                                {
                                    connection.Close();
                                }
                                connection.Open();

                                // SQL para inserir os dados na tabela
                                string query = "INSERT INTO cursos (nome, periodo, Nivel) VALUES (@nome, @periodo, @Nivel)";

                                // Crie um novo comando com a consulta SQL e a conexão
                                MySqlCommand command = new MySqlCommand(query, connection);

                                // Adicione os parâmetros
                                command.Parameters.AddWithValue("@nome", txtnome.Text);
                                command.Parameters.AddWithValue("@periodo", cbperiodo.Text);
                                command.Parameters.AddWithValue("@Nivel", cbnivel.Text);


                                // Execute o comando de inserção
                                command.ExecuteNonQuery();


                                PopupNotifier popup = new PopupNotifier();
                                //popup.TitleText= new Font("Lucida Fax", 11.5F, FontStyle.Bold, );
                                popup.BodyColor = Color.White;
                                popup.Image = Properties.Resources.ok_48px;
                                popup.TitleText = "Sucesso";
                                popup.ContentText = "Dados Cadastrados com sucesso!";
                                popup.Popup();

                                verdados();
                                // Feche a conexão
                                connection.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Session.Error = ex.Message;
                    FormError erro = new FormError();
                    erro.ShowDialog();

                }

            }
        }

        private void btactualizar_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = dataGridView1.CurrentRow.DataBoundItem as DataRowView;

            if (selectedRow != null)
            {
                // Recupere o ID da linha selecionada
                int id = Convert.ToInt32(selectedRow["ID"]);


                if (cbcordenador.Text == "" || txtnome.Text == "" || cbnivel.Text == "" || cbperiodo.Text == "")
                {

                    Session.Error = "Por favor, preenche todos os campos!";
                    FormError formError = new FormError();
                    formError.ShowDialog();

                }
                else
                {
                    using (MySqlConnection connection = new MySqlConnection(conn))
                    {
                        if (connection != null)
                        {
                            connection.Close();
                        }
                        connection.Open();

                        string queryc = "SELECT id FROM gestorescurso WHERE nome = @nome";
                        MySqlCommand commandd = new MySqlCommand(queryc, connection);
                        commandd.Parameters.AddWithValue("@nome", cbcordenador.Text);
                        int idcordenador = Convert.ToInt32(commandd.ExecuteScalar());

                        // SQL para atualizar os dados na tabela
                        string query = "UPDATE cursos SET nome= @nome , periodo = @periodo , Nivel= @Nivel, cordenador= @cordenador, cordenadorID= @cordenadorID WHERE ID = @ID";

                        // Crie um novo comando com a consulta SQL e a conexão
                        MySqlCommand command = new MySqlCommand(query, connection);

                        // Adicione os parâmetros
                        command.Parameters.AddWithValue("@nome", txtnome.Text);
                        command.Parameters.AddWithValue("@periodo", cbperiodo.Text);
                        command.Parameters.AddWithValue("@Nivel", cbnivel.Text);
                        command.Parameters.AddWithValue("@cordenador", cbcordenador.Text);
                        command.Parameters.AddWithValue("@cordenadorID", idcordenador);
                        command.Parameters.AddWithValue("@ID", id);


                        // Execute o comando de atualização
                        int rowsAffected = command.ExecuteNonQuery();

                        // Feche a conexão
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            PopupNotifier popup = new PopupNotifier();
                            //popup.TitleText= new Font("Lucida Fax", 11.5F, FontStyle.Bold, );
                            popup.BodyColor = Color.White;
                            popup.Image = Properties.Resources.ok_48px;
                            popup.TitleText = "Sucesso";
                            popup.ContentText = "Registo Actualizado com sucesso!";
                            popup.Popup();

                            // Após a exclusão, recarregue os dados no DataGridView para refletir as alterações
                            verdados();
                        }
                        else
                        {
                            Session.Error = "Falha ao atualizar os dados. Por favor, tente novamente.";
                            FormError erro = new FormError();
                            erro.ShowDialog();
                        }
                    }

                }
            }
            else
            {
                Session.Error = "Por favor, selecione uma linha para atualizar.";
                FormError erro = new FormError();
                erro.ShowDialog();
            }
        }

        private void btapagar_Click(object sender, EventArgs e)
        {
            // Verificar se há uma linha selecionada no DataGridView
            if (dataGridView1.CurrentRow != null)
            {
                // Confirmar a ação com o usuário
                DialogResult check = MessageBox.Show(
                    "Pretende apagar este registo?",
                    "Remover",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        // Obter o ID do registro selecionado
                        DataRowView selectedRow = dataGridView1.CurrentRow.DataBoundItem as DataRowView;

                        if (selectedRow != null)
                        {
                            int id = Convert.ToInt32(selectedRow["ID"]);

                            using (MySqlConnection connection = new MySqlConnection(conn))
                            {
                                connection.Open();

                                // Comando para apagar o registro
                                string queryDelete = "DELETE FROM cursos WHERE ID = @ID";
                                MySqlCommand command = new MySqlCommand(queryDelete, connection);

                                // Adicionar o parâmetro
                                command.Parameters.AddWithValue("@ID", id);

                                // Executar o comando
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    // Exibir mensagem de sucesso
                                    ExibirSucesso("Registro eliminado com sucesso!");

                                    // Atualizar os dados no DataGridView
                                    verdados();
                                }
                                else
                                {
                                    // Mensagem de erro se não conseguir apagar
                                    ExibirErro("Falha ao deletar o registro. Por favor, tente novamente.");
                                }
                            }
                        }
                        else
                        {
                            ExibirErro("Selecione um registro válido para apagar.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Captura e exibição de erros
                        ExibirErro($"Erro ao apagar o registro: {ex.Message}");
                    }
                }
            }
            else
            {
                ExibirErro("Nenhuma linha selecionada. Por favor, selecione uma linha para apagar.");
            }
        }
        private void ExibirErro(string mensagem)
        {
            Helppers.Session.Error = mensagem;
            FormError erro = new FormError();
            erro.ShowDialog();
        }

        private void ExibirSucesso(string mensagem)
        {
            Helppers.Session.Sucess = mensagem;
            FormSucess sucesso = new FormSucess();
            sucesso.ShowDialog();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btactualizar.Visible = true;
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                // Obtém os valores da célula na linha selecionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Preenche os TextBox com os valores da linha selecionada
                txtnome.Text = row.Cells["nome"].Value.ToString();
                cbperiodo.Text = row.Cells["periodo"].Value.ToString();
                cbcordenador.Text = row.Cells["cordenador"].Value.ToString();
                cbnivel.Text = row.Cells["nivel"].Value.ToString();


                // Obtém o valor da célula na coluna "ID" da linha selecionada
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                if (id <= 0)
                {
                    Session.Error = "Por favor selecione uma linha!";
                    FormError erro = new FormError();
                    erro.ShowDialog();
                }
            }
            else
            {
                Session.Error = "Nenhuma Linha foi selecionada, por favor selecione uma!";
                FormError erro = new FormError();
                erro.ShowDialog();
            }
        }
    }
}
