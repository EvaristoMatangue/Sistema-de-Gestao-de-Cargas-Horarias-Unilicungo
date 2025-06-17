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

namespace SGC.View.Docentes
{
    public partial class FormDetalhesDocentes : Form
    {
        string docente, Curso, Nivel,Disciplina, Observacao;
        string conn = $"{Helppers.conexao.connectionString}";

        private void FormDetalhesDocentes_Load(object sender, EventArgs e)
        {
            verdados();
        }
        private void verdados()
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();

                string query = "SELECT * from turmas where docente=@docente";

                MySqlCommand comando= new MySqlCommand(query, connection);

                comando.Parameters.AddWithValue("@docente", docente);

                comando.ExecuteNonQuery();


                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                connection.Close();

                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;

            }
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int Cargahoraria, Totalcarga, Cargarestante;
        public FormDetalhesDocentes(string nomeDocente, string curso, string nivel, string disciplina, int totalCarga, string observacao)
        {
            InitializeComponent();

            ldocente.Text = nomeDocente;
            Curso = curso;
            Nivel= nivel;
            Disciplina= disciplina;
            Totalcarga= totalCarga;
            Observacao = observacao;

        }

        
    }
}
