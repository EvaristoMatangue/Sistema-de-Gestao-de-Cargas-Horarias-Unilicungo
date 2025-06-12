using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using SGC.Helppers;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Globalization;

namespace SGC.View
{
    public partial class UCDashboard : UserControl
    {
        string conn = $"{Helppers.conexao.connectionString}";
        public UCDashboard()
        {
            InitializeComponent();
        }

        private void UCDashboard_Load(object sender, EventArgs e)
        {
            CarregarDados();
            //GerarRelatorio();
        }
       
        public DataTable ObterDadosDoBancoDeDados()
        {
            string query = @"
        SELECT 
            d.Nome AS NomeDocente,
            di.Nivel,
            di.Nome AS Disciplina,
            c.Nome AS Curso,
            di.CargaHoraria,
            t.TotalCargaHoraria,
            d.Observacao
        FROM 
            Docentes d
        JOIN 
            Disciplinas di ON d.ID = di.DocenteID
        JOIN 
            Cursos c ON di.CursoID = c.ID
        JOIN 
            (
                SELECT 
                    di.DocenteID,
                    SUM(di.CargaHoraria) AS TotalCargaHoraria
                FROM 
                    Disciplinas di
                GROUP BY 
                    di.DocenteID
            ) t ON d.ID = t.DocenteID
        ORDER BY 
            NomeDocente";

            DataTable dt = new DataTable("DadosDocente");

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                adapter.Fill(dt);
            }

            return dt;
        }

        
        private void CarregarDados()
        {

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                string query = @"
                            SELECT 
                                d.Nome AS NomeDocente,
                                di.Nivel,
                                di.Nome AS Disciplina,
                                c.Nome AS Curso,
                                di.CargaHoraria,
                                t.TotalCargaHoraria,
                                d.Observacao
                                
                            FROM 
                            
                            Docentes d
                            JOIN 
                                Disciplinas di ON d.ID = di.DocenteID
                            JOIN 
                                Cursos c ON di.CursoID = c.ID
                            JOIN 
                                (
                                    SELECT 
                                        di.DocenteID,
                                        SUM(di.CargaHoraria) AS TotalCargaHoraria
                                    FROM 
                                        Disciplinas di
                                    GROUP BY 
                                        di.DocenteID
                                ) t ON d.ID = t.DocenteID
                            ORDER BY 
                                NomeDocente";

                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                List<Dados> dadosDocentes = new List<Dados>();
                while (reader.Read())
                {
                    Dados dado = new Dados
                    {
                        NomeDocente = reader["NomeDocente"].ToString(),
                        Nivel = reader["Nivel"].ToString(),
                        Disciplina = reader["Disciplina"].ToString(),
                        Curso = reader["Curso"].ToString(),
                        CargaHoraria = Convert.ToInt32(reader["CargaHoraria"]),
                        TotalCargaHoraria = Convert.ToInt32(reader["TotalCargaHoraria"]),
                        Observacao = reader["Observacao"].ToString()
                        
                    };
                    dadosDocentes.Add(dado);
                }
                reader.Close();

                dataGridView1.DataSource = dadosDocentes;
                
            }
        }

        private void lsemestreum_Click(object sender, EventArgs e)
        {
            lsemestreum.BackColor = Color.FromArgb(0, 138, 210);
            lsemestreum.ForeColor = Color.White;
            lsementredois.ForeColor = Color.FromArgb(0, 138, 210);
            lsementredois.BackColor = Color.Transparent;
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                string query = @"
                            SELECT 
                                d.Nome AS NomeDocente,
                                di.Nivel,
                                di.Nome AS Disciplina,
                                c.Nome AS Curso,
                                di.CargaHoraria,
                                t.TotalCargaHoraria,
                                d.Observacao
                                
                            FROM 
                                Docentes d
                            JOIN 
                                Disciplinas di ON d.ID = di.DocenteID
                            JOIN 
                                Cursos c ON di.CursoID = c.ID
                            JOIN 
                                (
                                    SELECT 
                                        di.DocenteID,
                                        SUM(di.CargaHoraria) AS TotalCargaHoraria
                                    FROM 
                                        Disciplinas di
                                    GROUP BY 
                                        di.DocenteID
                                ) t ON d.ID = t.DocenteID

                         WHERE 
                                di.Semestre = '1º Semestre'
                         ORDER BY 
                                NomeDocente";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void lsementredois_Click(object sender, EventArgs e)
        {
            lsementredois.BackColor = Color.FromArgb(0, 138, 210);
            lsementredois.ForeColor = Color.White;
            lsemestreum.ForeColor = Color.FromArgb(0, 138, 210);
            lsemestreum.BackColor = Color.Transparent;
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                string query = @"
                            SELECT 
                                d.Nome AS NomeDocente,
                                di.Nivel,
                                di.Nome AS Disciplina,
                                c.Nome AS Curso,
                                di.CargaHoraria,
                                t.TotalCargaHoraria,
                                d.Observacao
                                
                            FROM 
                                Docentes d
                            JOIN 
                                Disciplinas di ON d.ID = di.DocenteID
                            JOIN 
                                Cursos c ON di.CursoID = c.ID
                            JOIN 
                                (
                                    SELECT 
                                        di.DocenteID,
                                        SUM(di.CargaHoraria) AS TotalCargaHoraria
                                    FROM 
                                        Disciplinas di
                                    GROUP BY 
                                        di.DocenteID
                                ) t ON d.ID = t.DocenteID
                            WHERE 
                                di.Semestre = '2º Semestre'
                            ORDER BY 
                                NomeDocente";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }

        }

        private void btlaboral_Click(object sender, EventArgs e)
        {
            
        }

        private void btposlaboral_Click(object sender, EventArgs e)
        {
            
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                string query = @"
                            SELECT 
                                d.Nome AS NomeDocente,
                                di.Nivel,
                                di.Nome AS Disciplina,
                                c.Nome AS Curso,
                                di.CargaHoraria,
                                t.TotalCargaHoraria,
                                d.Observacao
                                
                            FROM 
                                Docentes d
                            JOIN 
                                Disciplinas di ON d.ID = di.DocenteID
                            JOIN 
                                Cursos c ON di.CursoID = c.ID
                            JOIN 
                                (
                                    SELECT 
                                        di.DocenteID,
                                        SUM(di.CargaHoraria) AS TotalCargaHoraria
                                    FROM 
                                        Disciplinas di
                                    GROUP BY 
                                        di.DocenteID
                                ) t ON d.ID = t.DocenteID

                         WHERE 
                                c.Periodo = 'Laboral'
                         ORDER BY 
                                NomeDocente";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                string query = @"
                            SELECT 
                                d.Nome AS NomeDocente,
                                di.Nivel,
                                di.Nome AS Disciplina,
                                c.Nome AS Curso,
                                di.CargaHoraria,
                                t.TotalCargaHoraria,
                                d.Observacao
                                
                            FROM 
                                Docentes d
                            JOIN 
                                Disciplinas di ON d.ID = di.DocenteID
                            JOIN 
                                Cursos c ON di.CursoID = c.ID
                            JOIN 
                                (
                                    SELECT 
                                        di.DocenteID,
                                        SUM(di.CargaHoraria) AS TotalCargaHoraria
                                    FROM 
                                        Disciplinas di
                                    GROUP BY 
                                        di.DocenteID
                                ) t ON d.ID = t.DocenteID

                         WHERE 
                                c.Periodo = 'pos-laboral'
                         ORDER BY 
                                NomeDocente";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
