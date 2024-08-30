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

namespace SGC.View.Chefe_de_Departamento
{
    public partial class UCChefeDiscplina : UserControl
    {
        string conn = $"{Helppers.conexao.connectionString}";
        public UCChefeDiscplina()
        {
            InitializeComponent();
        }

        private void cbdocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                string query = @"
                            SELECT 
                                *
                            FROM 
                                disciplinas
                            
                         WHERE 
                                curso = @curso
                         ORDER BY 
                                nome";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@curso", cbdocente.Text);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            combobox();
        }
        public void combobox()
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                // Abra a conexão
                connection.Open();

                string query = @"SELECT 
                                    COUNT(*) AS totaldisciplina
                                FROM 
                                    disciplinas 
                                where curso =@curso";

                // Crie um novo comando com a consulta SQL e a conexão
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@curso", cbdocente.Text);


                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Obtenher a quantidade total de 'disciplinas'
                        int totaldisciplina = Convert.ToInt32(reader["totaldisciplina"]);

                        ltdisciplina.Text = totaldisciplina.ToString();
                    }
                }
            }
        }
        public void verdados()
        {
            cbdocente.Items.Clear();

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

                        cbdocente.Items.Add(reader["nome"].ToString());
                        cbdocente.Text = reader["nome"].ToString();
                    }

                }
                connection.Close();
            }
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                string query = @"
                            SELECT 
                                *
                                
                            FROM 
                                disciplinas 
                         ORDER BY 
                                nome";

                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["Cursoid"].Visible = false;
                dataGridView1.Columns["Docenteid"].Visible = false;

            }
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                // Abra a conexão
                connection.Open();

                string query = @"SELECT 
                                    COUNT(*) AS totaldisciplina
                                FROM 
                                    disciplinas 
                                where curso =@curso";

                // Crie um novo comando com a consulta SQL e a conexão
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@curso", cbdocente.Text);


                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Obtenher a quantidade total de 'disciplinas'
                        int totaldisciplina = Convert.ToInt32(reader["totaldisciplina"]);

                        ltdisciplina.Text = totaldisciplina.ToString();
                    }
                }
            }
        }
        private void UCChefeDiscplina_Load(object sender, EventArgs e)
        {
            verdados();

        }
    }
}
