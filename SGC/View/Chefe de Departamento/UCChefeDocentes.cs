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
using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace SGC.View.Chefe_de_Departamento
{
    public partial class UCChefeDocentes : UserControl
    {
        string conn = $"{Helppers.conexao.connectionString}";

        public UCChefeDocentes()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbdocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void combobox()
        {
            string curso = cbdocente.SelectedItem.ToString();

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();
                string query = @"
                    SELECT 
                        d.Nome AS NomeDocente,
                        COUNT(di.ID) AS Quantidade
                    FROM 
                        Docentes d
                    JOIN 
                        Disciplinas di ON d.ID = di.DocenteID
                    JOIN 
                        Cursos c ON di.CursoID = c.ID
                    WHERE 
                        c.Nome = @curso
                    GROUP BY 
                        d.Nome";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@curso", curso);

            }
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                // Abra a conexão
                connection.Open();

                string query = @"SELECT 
                                    COUNT(*) AS totaldisciplina
                                FROM 
                                    docentes 
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

                        ltotaldocentes.Text = totaldisciplina.ToString();
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
                                Docentes 
                         ORDER BY 
                                nome";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@curso", cbdocente.Text);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;

            }
        }
        private void UCChefeDocentes_Load(object sender, EventArgs e)
        {
            verdados();
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                // Abra a conexão
                connection.Open();

                // SQL para contar a quantidade de 'monografias' e calcular a percentagem
                string query = @"SELECT 
                                    COUNT(*) AS totaldocente
                                FROM 
                                    docentes";
                string query1 = @"SELECT 
                                    COUNT(*) AS totaldisciplina
                                FROM 
                                    disciplinas";

                // Crie um novo comando com a consulta SQL e a conexão
                MySqlCommand command = new MySqlCommand(query, connection);

                // Crie um novo comando com a consulta SQL e a conexão
                MySqlCommand command1 = new MySqlCommand(query1, connection);

                // Execute o comando e leia os resultados
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Obtenha a quantidade total de 'docentes'
                        int totaldocente = Convert.ToInt32(reader["totaldocente"]);

                        ltotaldocentes.Text = totaldocente.ToString();
                    }

                }
                using (MySqlDataReader reader = command1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Obtenher a quantidade total de 'disciplinas'
                        int totaldisciplina = Convert.ToInt32(reader["totaldisciplina"]);

                        //ltdisciplina.Text = totaldisciplina.ToString();
                    }
                }
            }
        }

        private void cbdocente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                string query = @"
                SELECT 
                    *
                    
                FROM 
                    Docentes as d
                
             WHERE 
                    d.curso = @curso
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
    }
}
