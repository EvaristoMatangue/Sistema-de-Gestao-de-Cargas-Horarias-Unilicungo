using MySql.Data.MySqlClient;
using SGC.Helppers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void UCChefedepartamento_Load(object sender, EventArgs e)
        {
            verdados();
        }


        private void btcadastrar_Click_1(object sender, EventArgs e)
        {
            if (txtemail.Text == "" || txtnome.Text == "" || txttelefone.Text == "" || txtusuario.Text == "")
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

                                string hashedSenha = BCrypt.Net.BCrypt.HashPassword(txtusuario.Text + "1234");

                                // Adicione os parâmetros
                                command.Parameters.AddWithValue("@nome", txtnome.Text);
                                command.Parameters.AddWithValue("@email", txtemail.Text);
                                command.Parameters.AddWithValue("@telefone", txttelefone.Text);
                                command.Parameters.AddWithValue("@nomeusuario", txtusuario.Text);

                                string queryu = "INSERT INTO usuarios (nomeusuario, tipousuario, email, senha) VALUES (@nomeusuario, @tipousuario,@email, @senha)";

                                // Crie um novo comando com a consulta SQL e a conexão
                                MySqlCommand commandu = new MySqlCommand(queryu, connection);


                                // Adicione os parâmetros
                                commandu.Parameters.AddWithValue("@nomeusuario", txtusuario.Text);
                                commandu.Parameters.AddWithValue("@tipousuario", "chefedepartamento");
                                commandu.Parameters.AddWithValue("@email", txtemail.Text);
                                commandu.Parameters.AddWithValue("@senha", hashedSenha);

                                // Execute o comando de inserção
                                command.ExecuteNonQuery();
                                commandu.ExecuteNonQuery();

                                Session.Sucess = "Dados Cadastrados com sucesso!";
                                FormSucess sucess = new FormSucess();
                                sucess.ShowDialog();

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

        private void btactualizar_Click_1(object sender, EventArgs e)
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
                        Session.Error = "Falha ao atualizar os dados. Por favor, tente novamente.";
                        FormError erro = new FormError();
                        erro.ShowDialog();
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

        private void btapagar_Click_1(object sender, EventArgs e)
        {
            // Mostra popup de confirmação personalizado
            FormAlertaContinuar alerta = new FormAlertaContinuar(
                "Tem certeza que deseja eliminar este chefe de departamento?\n\n" +
                "Essa ação é permanente e não poderá ser desfeita.\n\n" +
                "Deseja continuar?"
            );

            DialogResult check = alerta.ShowDialog();

            if (check != DialogResult.Yes)
                return;

            // Obtenha os dados da linha selecionada no DataGridView
            DataRowView selectedRow = dataGridView1.CurrentRow?.DataBoundItem as DataRowView;

            if (selectedRow != null)
            {
                // Recupere o ID da linha selecionada
                int id = Convert.ToInt32(selectedRow["ID"]);

                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    string query = "DELETE FROM chefedepartamento WHERE ID = @ID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Mostra popup de sucesso
                        PopupNotifier popup = new PopupNotifier();
                        popup.BodyColor = Color.White;
                        popup.Image = Properties.Resources.ok_48px;
                        popup.TitleText = "Sucesso";
                        popup.ContentText = "Registo eliminado com sucesso!";
                        popup.Popup();

                        limpardados();
                        verdados();
                    }
                    else
                    {
                        Session.Error = "Falha ao eliminar o registo. Por favor, tente novamente.";
                        FormError erro = new FormError();
                        erro.ShowDialog();
                    }
                }
            }
            else
            {
                Session.Error = "Por favor, selecione uma linha para eliminar.";
                FormError erro = new FormError();
                erro.ShowDialog();
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
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

                btactualizar.Enabled = true;
                btapagar.Enabled = true;
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

        private void txttelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttelefone_Leave(object sender, EventArgs e)
        {
            if (txttelefone.Text.Length != 9)
            {
                Session.Error = "O número de telefone deve ter exatamente 9 dígitos.";
                FormError erro = new FormError();
                erro.ShowDialog();
            }
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private bool ValidarEmail(string email)
        {
            // Expressão regular para formato de email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (!ValidarEmail(txtemail.Text))
            {
                Session.Error = "O endereço de email inserido é inválido. Por favor, insira um email válido.";
                FormError erro = new FormError();
                erro.ShowDialog();

            }
        }

        private void txttelefone_TextChanged(object sender, EventArgs e)
        {
            string telefone = txttelefone.Text;

            // Validar se o telefone começa com 8 e segue as demais condições
            if (telefone.Length >= 2)
            {
                if (telefone[0] != '8' || telefone[1] < '2' || telefone[1] > '7')
                {
                    Session.Error = "Por favor digite um contacto válido!";
                    FormError erro = new FormError();
                    erro.ShowDialog();
                    txttelefone.Text = telefone.Substring(0, telefone.Length - 1); // Remover último caractere inválido
                    txttelefone.SelectionStart = txttelefone.Text.Length; // Ajustar o cursor
                }
            }

            // Validar se há caracteres não numéricos
            if (!telefone.All(char.IsDigit))
            {
                Session.Error = "O número de telefone deve conter apenas dígitos.";
                FormError erro = new FormError();
                erro.ShowDialog();
                txttelefone.Text = new string(telefone.Where(char.IsDigit).ToArray());
                txttelefone.SelectionStart = txttelefone.Text.Length; // Ajustar o cursor
            }
        }
    }
}
