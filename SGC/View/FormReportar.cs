using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using SGC.Helppers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using System.Data.SQLite;
using System.IO;

namespace SGC.View
{
    
    public partial class FormReportar : Form
    {
        public static string path = $"{Helppers.conexao.path}";
        private static SQLiteConnection sqliteconn;

        string conn = $"{Helppers.conexao.connectionString}";
        string nomeemissor="", nomedestinatario="";
        public FormReportar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReportar_Load(object sender, EventArgs e)
        {
            cbcurso.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(conn))
            {

                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();

                string query = "SELECT nome FROM cursos ORDER BY nome";

                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        cbcurso.Items.Add(reader["nome"].ToString());

                    }

                }
                connection.Close();
            }
        }
        private static SQLiteConnection Dbconn()
        {
            sqliteconn =new SQLiteConnection("Data Sourse=" + path);
            sqliteconn.Open();
            return sqliteconn;
        }
        
        private void btsubmenter_Click(object sender, EventArgs e)
        {

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();
                string querygestor = "SELECT cordenador FROM cursos WHERE nome = @curso";
                MySqlCommand commandgestor = new MySqlCommand(querygestor, connection);
                commandgestor.Parameters.AddWithValue("@curso", cbcurso.Text);
                commandgestor.ExecuteNonQuery();
                MySqlDataReader reader = commandgestor.ExecuteReader();
                if (reader.Read())
                {
                    nomedestinatario = reader["cordenador"].ToString();

                }
                string query = "INSERT INTO mensagens (nomeemissor, nomedestinatario, tipoproblema, dataemissao, mensagem) VALUES (@nomeemissor, @nomedestinatario, @tipoproblema, NOW(), @mensagem)";

                // Crie um novo comando com a consulta SQL e a conexão
                MySqlCommand command = new MySqlCommand(query, connection);

                // Adicione os parâmetros
                command.Parameters.AddWithValue("@nomeemissor", $"{Helppers.Session.Nome}");
                command.Parameters.AddWithValue("@nomedestinatario", nomedestinatario);
                command.Parameters.AddWithValue("@tipoproblema", cblocalproblema.Text);
                command.Parameters.AddWithValue("@mensagem", txtmensagem.Text);

                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();
                // Execute o comando de inserção
                command.ExecuteNonQuery();


                PopupNotifier popup = new PopupNotifier();
                //popup.TitleText= new Font("Lucida Fax", 11.5F, FontStyle.Bold, );
                popup.BodyColor = Color.White;
                popup.Image = Properties.Resources.ok_48px;
                popup.TitleText = "Sucesso";
                popup.ContentText = "Mensagem enviado com sucesso!";
                popup.Popup();
                // Feche a conexão
                connection.Close();

            }
        }
    }
}
