using MySql.Data.MySqlClient;
using SGC.Helppers;
using SGC.View;
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

namespace SGC
{
    public partial class UCDocenteAdmin : UserControl
    {
        string conn = $"{Helppers.conexao.connectionString}";

        public UCDocenteAdmin()
        {
            InitializeComponent();
        }
        public void verdados()
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {

                connection.Open();

                string query = "SELECT * FROM docentes";

                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                connection.Close();

                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;

            }
        }
        public void limpardados()
        {
            txtemail.Text = "";
            txtnome.Text = "";
            txtobs.Text = "";
            txttelefone.Text = "";
            txtusuario.Text = "";
            cbcurso.Text = "";
        }
        private void btcadastrar_Click(object sender, EventArgs e)
        {
            
        }

        private void UCDocenteAdmin_Load(object sender, EventArgs e)
        {
            cbcurso.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();
              
                    string query = "SELECT nome FROM cursos";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader readerr = command.ExecuteReader())
                    {
                        while (readerr.Read())
                        {
                            cbcurso.Items.Add(readerr["nome"].ToString());

                        }
                    }
                
            }
            verdados();
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
                dataGridView1.Text = row.Cells["curso"].Value.ToString();
                txtusuario.Text = row.Cells["nomeusuario"].Value.ToString();
                txtobs.Text = row.Cells["observacao"].Value.ToString();

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

        private void btcadastrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtemail.Text == "" || txtnome.Text == "" || txttelefone.Text ==""|| txtusuario.Text=="")
                {

                    Session.Error = "É obrigatorio preencher todos os campos!";
                    FormError erro = new FormError();
                    erro.ShowDialog();

                }
                using (MySqlConnection connection1 = new MySqlConnection(conn))
                {

                    connection1.Open();
                    string queryVerificar = "SELECT COUNT(*) FROM docentes WHERE Nome = @nomedocente";
                    MySqlCommand commandVerificar = new MySqlCommand(queryVerificar, connection1);

                    commandVerificar.Parameters.AddWithValue("@nomedocente", txtnome.Text);
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
                            string query = "INSERT INTO docentes (nome, email, telefone, curso, nomeusuario, numcarga, observacao) VALUES (@nome, @email, @telefone, @curso, @nomeusuario, @numcarga, @observacao)";

                            // Crie um novo comando com a consulta SQL e a conexão
                            MySqlCommand command = new MySqlCommand(query, connection);

                            string hashedSenha = BCrypt.Net.BCrypt.HashPassword(txtusuario.Text + "1234"); 

                            // Adicione os parâmetros
                            command.Parameters.AddWithValue("@nome", txtnome.Text);
                            command.Parameters.AddWithValue("@email", txtemail.Text);
                            command.Parameters.AddWithValue("@telefone", txttelefone.Text);
                            command.Parameters.AddWithValue("@curso", cbcurso.Text);
                            command.Parameters.AddWithValue("@nomeusuario", txtusuario.Text);
                            command.Parameters.AddWithValue("@numcarga", txtnumcarga.Text);
                            command.Parameters.AddWithValue("@observacao", txtobs.Text);

                            string queryu = "INSERT INTO usuarios (nomeusuario, tipousuario, senha) VALUES (@nomeusuario, @tipousuario, @senha)";

                            // Crie um novo comando com a consulta SQL e a conexão
                            MySqlCommand commandu = new MySqlCommand(queryu, connection);


                            // Adicione os parâmetros
                            commandu.Parameters.AddWithValue("@nomeusuario", txtusuario.Text);
                            commandu.Parameters.AddWithValue("@tipousuario", "docente");
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
                            limpardados();

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
                    // Verificar se o nomeusuario já existe (para outro ID)
                    string queryVerificar = "SELECT COUNT(*) FROM docentes WHERE nomeusuario = @nomeusuario AND id != @ID";
                    MySqlCommand commandVerificar = new MySqlCommand(queryVerificar, connection);
                    commandVerificar.Parameters.AddWithValue("@nomeusuario", txtusuario.Text);
                    commandVerificar.Parameters.AddWithValue("@ID", id); // ID do registro atual
                    int count = Convert.ToInt32(commandVerificar.ExecuteScalar());

                    if (count > 0)
                    {
                        Session.Error = "O nome de usuário já existe. Escolha outro.";
                        FormError erro = new FormError();
                        erro.ShowDialog();
                        return; // Interrompe a execução se o nome já existir
                    }

                    // SQL para atualizar os dados na tabela
                    string query = "UPDATE docentes SET nome= @nome , email = @email , telefone= @telefone, curso= @curso, nomeusuario= @nomeusuario, observacao =@obs WHERE ID = @ID";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    //parâmetros
                    command.Parameters.AddWithValue("@nome", txtnome.Text);
                    command.Parameters.AddWithValue("@email", txtemail.Text);
                    command.Parameters.AddWithValue("@telefone", txttelefone.Text);
                    command.Parameters.AddWithValue("@curso", dataGridView1.Text);
                    command.Parameters.AddWithValue("@nomeusuario", txtusuario.Text);
                    command.Parameters.AddWithValue("@obs", txtobs.Text);
                    command.Parameters.AddWithValue("@ID", id);

                    // Atualizar tabela usuarios
                    string queryu = "UPDATE usuarios SET nomeusuario= @nomeusuario, email = @email WHERE nomeusuario = (SELECT nomeusuario FROM docentes WHERE id = @ID)";
                    MySqlCommand commandu = new MySqlCommand(queryu, connection);

                    // Adicione os parâmetros para a tabela usuarios
                    commandu.Parameters.AddWithValue("@nomeusuario", txtusuario.Text);
                    commandu.Parameters.AddWithValue("@email", txtemail.Text);
                    commandu.Parameters.AddWithValue("@ID", id);
                    commandu.ExecuteNonQuery();

                    int rowsAffectedu = commandu.ExecuteNonQuery();
                    int rowsAffected = command.ExecuteNonQuery();

                    // Feche a conexão
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        Session.Sucess = "Registo Actualizado com sucesso!";
                        FormSucess sucess = new FormSucess();
                        sucess.ShowDialog();

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

        private void txttelefone_Leave(object sender, EventArgs e)
        {
            if (txttelefone.Text.Length != 9)
            {
                Session.Error = "O número de telefone deve ter exatamente 9 dígitos.";
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

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (!ValidarEmail(txtemail.Text))
            {
                Session.Error = "O endereço de email inserido é inválido. Por favor, insira um email válido.";
                FormError erro = new FormError();
                erro.ShowDialog();

            }
        }
        private bool ValidarEmail(string email)
        {
            // Expressão regular para formato de email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            
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
