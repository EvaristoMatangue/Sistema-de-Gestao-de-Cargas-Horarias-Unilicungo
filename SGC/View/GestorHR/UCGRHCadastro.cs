using Microsoft.ReportingServices.Diagnostics.Internal;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SGC.View.GestorHR
{
    public partial class UCGRHCadastro : UserControl
    {
        string conn = $"{Helppers.conexao.connectionString}";

        public UCGRHCadastro()
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

                string query = "SELECT * FROM gestoresrh";

                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                connection.Close();

                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;


            }
        }

        private void UCGRHCadastro_Load(object sender, EventArgs e)
        {
            verdados();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btcadastrar_Click(object sender, EventArgs e)
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
                    string nome = txtnome.Text;
                    {

                        using (MySqlConnection connection = new MySqlConnection(conn))
                        {
                            if (connection != null)
                            {
                                connection.Close();
                            }
                            connection.Open();
                            string queryVerificar = "SELECT COUNT(*) FROM gestoresrh WHERE Nome = @nome";
                            MySqlCommand commandVerificar = new MySqlCommand(queryVerificar, connection);

                            commandVerificar.Parameters.AddWithValue("@nome", txtnome.Text);
                            int count = Convert.ToInt32(commandVerificar.ExecuteScalar());

                            if (count > 0)
                            {
                                Session.Error = "O nome do Gestor de Recursos Humanos Já existe, Tento o outro!";
                                FormError erro = new FormError();
                                erro.ShowDialog();
                            }
                            else
                            {

                                string hashedSenha = BCrypt.Net.BCrypt.HashPassword(txtusuario.Text + "1234");
                                if (connection != null)
                                {
                                    connection.Close();
                                }
                                connection.Open();
                                // SQL para inserir os dados na tabela
                                string query = "INSERT INTO gestoresrh (nome, email, telefone, nomeusuario, senha) VALUES (@nome, @email, @telefone, @nomeusuario, @senha)";

                                // Crie um novo comando com a consulta SQL e a conexão
                                MySqlCommand command = new MySqlCommand(query, connection);

                                // Adicione os parâmetros
                                command.Parameters.AddWithValue("@nome", txtnome.Text);
                                command.Parameters.AddWithValue("@email", txtemail.Text);
                                command.Parameters.AddWithValue("@telefone", txttelefone.Text);
                                command.Parameters.AddWithValue("@nomeusuario", txtusuario.Text);
                                command.Parameters.AddWithValue("@senha", hashedSenha);

                                string queryu = "INSERT INTO usuarios (nomeusuario, tipousuario, senha) VALUES (@nomeusuario, @tipousuario, @senha)";

                                // Crie um novo comando com a consulta SQL e a conexão
                                MySqlCommand commandu = new MySqlCommand(queryu, connection);

                                // Adicione os parâmetros
                                commandu.Parameters.AddWithValue("@nomeusuario", txtusuario.Text);
                                commandu.Parameters.AddWithValue("@tipousuario", "gestorrh");
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
                    Session.Error = ex.Message;
                    FormError erro = new FormError();
                    erro.ShowDialog();

                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
