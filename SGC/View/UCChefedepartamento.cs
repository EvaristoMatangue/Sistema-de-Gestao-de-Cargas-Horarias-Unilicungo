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
    public partial class UCChefedepartamento : UserControl
    {
        string conn = $"{Helppers.conexao.connectionString}";

        public UCChefedepartamento()
        {
            InitializeComponent();
        }
        public void limpardados()
        {
            txtnome.Text = "";
            txttelefone.Text = "";
            txtemail.Text = "";
            txtusuario.Text = "";
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

                string query = "SELECT * FROM chefedepartamento ";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                connection.Close();

                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;

            }
        }
        private void btcadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection1 = new MySqlConnection(conn))
                {

                    connection1.Open();
                    string queryVerificar = "SELECT COUNT(*) FROM chefedepartamento WHERE nome = @nome";
                    MySqlCommand commandVerificar = new MySqlCommand(queryVerificar, connection1);

                    commandVerificar.Parameters.AddWithValue("@nome", txtnome.Text);
                    int count = Convert.ToInt32(commandVerificar.ExecuteScalar());

                    if (count > 0)
                    {
                        Session.Error = "O nome da Docente Já existe, Tente com outro nome!";
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
                            string query = "INSERT INTO chefedepartamento (nome, email, telefone, nomeusuario) VALUES (@nome, @email, @telefone, @nomeusuario)";

                            // Crie um novo comando com a consulta SQL e a conexão
                            MySqlCommand command = new MySqlCommand(query, connection);

                            string hashedSenha = BCrypt.Net.BCrypt.HashPassword("1234");

                            // Adicione os parâmetros
                            command.Parameters.AddWithValue("@nome", txtnome.Text);
                            command.Parameters.AddWithValue("@email", txtemail.Text);
                            command.Parameters.AddWithValue("@telefone", txttelefone.Text);
                            command.Parameters.AddWithValue("@nomeusuario", txtusuario.Text);

                            string queryu = "INSERT INTO usuarios (nomeusuario, tipousuario, senha) VALUES (@nomeusuario, @tipousuario, @senha)";

                            // Crie um novo comando com a consulta SQL e a conexão
                            MySqlCommand commandu = new MySqlCommand(queryu, connection);


                            // Adicione os parâmetros
                            commandu.Parameters.AddWithValue("@nomeusuario", txtusuario.Text);
                            commandu.Parameters.AddWithValue("@tipousuario", "chefedepartamento");
                            commandu.Parameters.AddWithValue("@senha", hashedSenha);

                            // Execute o comando de inserção
                            command.ExecuteNonQuery();
                            commandu.ExecuteNonQuery();

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
                PopupNotifier popup = new PopupNotifier();
                //popup.TitleText= new Font("Lucida Fax", 11.5F, FontStyle.Bold, );
                popup.BodyColor = Color.White;
                popup.Image = Properties.Resources.error_24px;
                popup.TitleText = "Alerta";
                popup.ContentText = ex.Message;

                popup.Popup();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                // Obtém os valores da célula na linha selecionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Preenche os TextBox com os valores da linha selecionada
                txtnome.Text = row.Cells["nome"].Value.ToString();
                txtemail.Text = row.Cells["email"].Value.ToString();
                txttelefone.Text = row.Cells["telefone"].Value.ToString();
                txtusuario.Text = row.Cells["nomeusuario"].Value.ToString();

                // Obtém o valor da célula na coluna "ID" da linha selecionada
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
            }
            else
            {
                Session.Error = "Nenhuma Linha foi selecionada, por favor selecione uma!";
                FormError erro = new FormError();
                erro.ShowDialog();
            }
        }

        private void btactualizar_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = dataGridView1.CurrentRow.DataBoundItem as DataRowView;

            if (selectedRow != null)
            {
                // Recupere o ID da linha selecionada
                int id = Convert.ToInt32(selectedRow["ID"]);



                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    // Abra a conexão
                    connection.Open();


                    // SQL para atualizar os dados na tabela
                    string query = "UPDATE chefedepartamento SET nome= @nome , email = @email , telefone= @telefone, nomeusuario= @nomeusuario WHERE ID = @ID";
                    // Crie um novo comando com a consulta SQL e a conexão
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Adicione os parâmetros
                    command.Parameters.AddWithValue("@nome", txtnome.Text);
                    command.Parameters.AddWithValue("@email", txtemail.Text);
                    command.Parameters.AddWithValue("@telefone", txttelefone.Text);
                    command.Parameters.AddWithValue("@nomeusuario", txtusuario.Text);
                    command.Parameters.AddWithValue("@ID", id);

                    string queryu = "UPDATE usuarios SET nomeusuario= @nome WHERE ID = @ID";
                    // Crie um novo comando com a consulta SQL e a conexão
                    MySqlCommand commandu = new MySqlCommand(queryu, connection);

                    // Adicione os parâmetros
                    commandu.Parameters.AddWithValue("@nome", txtusuario.Text);
                    commandu.Parameters.AddWithValue("@ID", id);
                    // Execute o comando de atualização
                    int rowsAffectedu = commandu.ExecuteNonQuery();
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
                        limpardados();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar os dados. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha para atualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UCChefedepartamento_Load(object sender, EventArgs e)
        {
            verdados();
        }

        private void btapagar_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Pretende apagar este registo?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            // Obtenha os dados da linha selecionada no DataGridView
            DataRowView selectedRow = dataGridView1.CurrentRow.DataBoundItem as DataRowView;

            if (selectedRow != null)
            {
                // Recupere o ID da linha selecionada
                int id = Convert.ToInt32(selectedRow["ID"]);

                // Crie uma nova conexão usando a string de conexão
                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    if (check == DialogResult.Yes)
                    {
                        // SQL para deletar a linha da tabela
                        string query = "DELETE FROM chefedepartamento WHERE ID = @ID";
                        // Crie um novo comando com a consulta SQL e a conexão
                        MySqlCommand command = new MySqlCommand(query, connection);

                        command.Parameters.AddWithValue("@ID", id);

                        // Abra a conexão
                        connection.Open();

                        // Execute o comando de exclusão
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {

                            PopupNotifier popup = new PopupNotifier();
                            //popup.TitleText= new Font("Lucida Fax", 11.5F, FontStyle.Bold, );
                            popup.BodyColor = Color.White;
                            popup.Image = Properties.Resources.exit;
                            popup.TitleText = "Sucesso";
                            popup.ContentText = "Registo Eliminado com sucesso!";
                            popup.Popup();

                            limpardados();
                            verdados();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao deletar a linha. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }



                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha para deletar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
