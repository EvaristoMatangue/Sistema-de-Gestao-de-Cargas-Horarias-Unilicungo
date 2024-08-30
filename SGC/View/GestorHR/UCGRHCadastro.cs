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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.ReportingServices.Diagnostics.Internal;

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
                dataGridView1.Columns["senha"].Visible = false;
                dataGridView1.Columns["id"].Visible = false;


            }
        }
        private void btcadastrar_Click(object sender, EventArgs e)
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
                    string queryVerificar = "SELECT COUNT(*) FROM gestoresrh WHERE Nome = @nome";
                    MySqlCommand commandVerificar = new MySqlCommand(queryVerificar, connection1);

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
                        using (MySqlConnection connection = new MySqlConnection(conn))
                        {
                            string hashedSenha = BCrypt.Net.BCrypt.HashPassword("1234");
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
                PopupNotifier popup = new PopupNotifier();
                //popup.TitleText= new Font("Lucida Fax", 11.5F, FontStyle.Bold, );
                popup.BodyColor = Color.White;
                popup.Image = Properties.Resources.exit;
                popup.TitleText = "Falha";
                popup.ContentText = ex.Message;
                popup.Popup();

            }
        }

        private void UCGRHCadastro_Load(object sender, EventArgs e)
        {
            verdados();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
