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

namespace SGC.View
{
    public partial class FormDocente : Form
    {
        string connectionString = $"{Helppers.conexao.connectionString}";

        public FormDocente()
        {
            InitializeComponent();
            CarregarDados();
        }
        private void CarregarDados()
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
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
                                d.nome = di.docente
                            ORDER BY
                                NomeDocente";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
           
        }

        private void llaporal_Click(object sender, EventArgs e)
        {
            llaporal.BackColor = Color.FromArgb(0, 138, 210);
            llaporal.ForeColor = Color.White;
            lposlaboral.ForeColor = Color.FromArgb(0, 138, 210);
            lposlaboral.BackColor = Color.Transparent;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
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

        private void lposlaboral_Click(object sender, EventArgs e)
        {
            lposlaboral.BackColor = Color.FromArgb(0, 138, 210);
            lposlaboral.ForeColor = Color.White;
            llaporal.ForeColor = Color.FromArgb(0, 138, 210);
            llaporal.BackColor = Color.Transparent;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                button3.Image = Properties.Resources.copy_24px;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                button3.Image = Properties.Resources.maximize_button_24px;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void painelprincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btapagar_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.FormClosed += (s, args) => this.Close();
            this.Hide();
            log.Show();
        }
    }
}
