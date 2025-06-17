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
        string conn = $"{Helppers.conexao.connectionString}";

        public FormDocente()
        {
            InitializeComponent();
            CarregarDados();
        }
        private string semestreSelecionado = ""; // Variável para armazenar o semestre selecionado

        private void UCDashboard_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados(string filtroSemestre = null)
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
                            ";

            if (!string.IsNullOrEmpty(filtroSemestre))
            {
                query += $" WHERE di.Semestre = '{filtroSemestre}'";
            }

            query += " ORDER BY NomeDocente";

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void AtualizarCoresSemestre(Label labelSelecionado)
        {
            Label[] labels = { lsemestreum, lsemestredois };

            foreach (var label in labels)
            {
                if (label == labelSelecionado && !string.IsNullOrEmpty(semestreSelecionado))
                {
                    label.BackColor = Color.FromArgb(0, 138, 210);
                    label.ForeColor = Color.White;
                }
                else
                {
                    label.BackColor = Color.Transparent;
                    label.ForeColor = Color.FromArgb(0, 138, 210);
                }
            }
        }

        private void CarregarDadosPorPeriodo(string periodo)
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
                                c.Periodo = @Periodo
                            ORDER BY 
                                NomeDocente";

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Periodo", periodo);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.FormClosed += (s, args) => this.Close();
            this.Hide();
            log.Show();
        }

        private void btlaboral_Click_1(object sender, EventArgs e)
        {
            CarregarDadosPorPeriodo("laboral");
        }

        private void lsemestreum_Click_1(object sender, EventArgs e)
        {
            if (semestreSelecionado == "1º Semestre")
            {
                // Se já está selecionado, limpa o filtro e exibe todos os semestres
                semestreSelecionado = "";
                CarregarDados();
            }
            else
            {
                semestreSelecionado = "1º Semestre";
                CarregarDados("1º Semestre");
            }

            AtualizarCoresSemestre(lsemestreum);
        }

        private void lsemestredois_Click(object sender, EventArgs e)
        {
            if (semestreSelecionado == "2º Semestre")
            {
                // Se já está selecionado, limpa o filtro e exibe todos os semestres
                semestreSelecionado = "";
                CarregarDados();
            }
            else
            {
                semestreSelecionado = "2º Semestre";
                CarregarDados("2º Semestre");
            }

            AtualizarCoresSemestre(lsemestredois);
        }

        private void btposlaboral_Click_1(object sender, EventArgs e)
        {
            CarregarDadosPorPeriodo("pos-laboral");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtprocurar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btprocurar.PerformClick(); // Simula o clique no botão procurar
            }
        }

        private void btprocurar_Click(object sender, EventArgs e)
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
                                d.Nome LIKE @procurar OR 
                                        di.Semestre LIKE @procurar OR 
                                        di.Nivel LIKE @procurar OR 
                                        c.Nome LIKE @procurar                            
                            ORDER BY 
                                NomeDocente";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@procurar", "%" + txtprocurar.Text.Trim() + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }

        }
    }
}
