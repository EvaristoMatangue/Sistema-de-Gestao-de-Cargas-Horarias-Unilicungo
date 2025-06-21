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
        string docente, Curso, Nivel, Disciplina, Observacao;
        string conn = $"{Helppers.conexao.connectionString}";

        public FormDetalhesDocentes(string nomeDocente, string curso, string nivel, string disciplina, int totalCarga, string observacao)
        {
            InitializeComponent();

            ldocente.Text = nomeDocente;
            CarregarDisciplinasDoDocente(nomeDocente);
        }
        private void FormDetalhesDocentes_Load(object sender, EventArgs e)
        {
        }
        private void CarregarDisciplinasDoDocente(string nomeDocente)
        {
            string conn = Helppers.conexao.connectionString;

            string query = @"
        SELECT 
            curso AS Curso,
            ano AS Nivel,
            nomedisciplina AS Disciplina,
            semestre AS Semestre,
            cargahoraria AS CargaHoraria
        FROM 
            turmas
        WHERE 
            docente = @docente
        ORDER BY 
            ano, curso, nomedisciplina;";

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@docente", nomeDocente);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                // Ajustes visuais opcionais
                dataGridView1.Columns["Curso"].HeaderText = "Curso";
                dataGridView1.Columns["Nivel"].HeaderText = "Ano/Nível";
                dataGridView1.Columns["Disciplina"].HeaderText = "Disciplina";
                dataGridView1.Columns["Semestre"].HeaderText = "Semestre";
                dataGridView1.Columns["CargaHoraria"].HeaderText = "Carga Horária";
            }
        }


        private void btsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
