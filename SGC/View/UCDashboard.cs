using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using SGC.Helppers;
using SGC.View.Docentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC.View
{
    public partial class UCDashboard : UserControl
    {
        string conn = $"{Helppers.conexao.connectionString}";
        string nivel, disciplina, semestre,curso;
        int cargahoraria;
        public UCDashboard()
        {
            InitializeComponent();

            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);

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
        tu.docente AS NomeDocente,
        tu.ano AS Nivel,
        tu.nomedisciplina AS Disciplina,
        tu.curso AS Curso,
        tu.semestre AS Semestre,
        tu.cargahoraria AS CargaHoraria,
        d.Observacao,
        (
            SELECT SUM(t2.CargaHoraria)
            FROM turmas t2
            WHERE t2.docente = tu.docente
        ) AS TotalCargaHoraria
    FROM 
        turmas tu
    JOIN 
        Docentes d ON d.nome = tu.docente
    ORDER BY 
        tu.docente, tu.ano, tu.nomedisciplina;";

            DataTable dt = new DataTable("DadosDocente");

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();
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
                // 1. Query resumida para o DataGridView (1 linha por docente)
                string queryResumo = @"
            SELECT 
                d.Nome AS NomeDocente,
                SUM(tu.CargaHoraria) AS TotalCargaHoraria,
                d.Observacao
            FROM 
                turmas tu
            JOIN 
                Docentes d ON d.nome = tu.docente
            GROUP BY 
                d.Nome, d.Observacao
            ORDER BY 
                d.Nome;";

                connection.Open();
                MySqlCommand command = new MySqlCommand(queryResumo, connection);
                MySqlDataReader reader = command.ExecuteReader();

                List<Dados> dadosDocentes = new List<Dados>();
                while (reader.Read())
                {
                    Dados dado = new Dados
                    {
                        NomeDocente = reader["NomeDocente"].ToString(),
                        TotalCargaHoraria = Convert.ToInt32(reader["TotalCargaHoraria"]),
                        Observacao = reader["Observacao"].ToString(),
                        Curso = curso,
                        Nivel = nivel,
                        CargaHoraria=cargahoraria,
                        Disciplina=disciplina
                    };
                    dadosDocentes.Add(dado);
                }
                reader.Close();

                // Vincula ao DataGridView
                dataGridView1.DataSource = dadosDocentes;
                dataGridView1.Columns["Nivel"].Visible = false;
                dataGridView1.Columns["Disciplina"].Visible = false;
                dataGridView1.Columns["Curso"].Visible = false;
                dataGridView1.Columns["CargaHoraria"].Visible = false;
                // Adiciona botão "Ver mais" (se ainda não existir)
                if (!dataGridView1.Columns.Contains("btnDetalhes"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.HeaderText = " Acções";
                    btn.Name = "btnDetalhes";
                    btn.Text = "👁";
                    btn.UseColumnTextForButtonValue = true;
                    btn.Width = 40;
                    dataGridView1.Columns.Add(btn);
                }

              
            }
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "btnDetalhes" && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);

                Color azul = ColorTranslator.FromHtml("#008AD2");
                Color branco = Color.White;

                // Botão pequeno
                int btnSize = 24;
                Rectangle buttonRect = new Rectangle(
                    e.CellBounds.X + (e.CellBounds.Width - btnSize) / 2,
                    e.CellBounds.Y + (e.CellBounds.Height - btnSize) / 2,
                    btnSize,
                    btnSize
                );

                using (SolidBrush brush = new SolidBrush(azul))
                using (Pen pen = new Pen(azul))
                using (GraphicsPath path = new GraphicsPath())
                {
                    int radius = 8;
                    path.AddArc(buttonRect.X, buttonRect.Y, radius, radius, 180, 90);
                    path.AddArc(buttonRect.Right - radius, buttonRect.Y, radius, radius, 270, 90);
                    path.AddArc(buttonRect.Right - radius, buttonRect.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(buttonRect.X, buttonRect.Bottom - radius, radius, radius, 90, 90);
                    path.CloseFigure();

                    e.Graphics.FillPath(brush, path);
                    e.Graphics.DrawPath(pen, path);

                    // Ícone de olho desenhado manualmente
                    int eyeWidth = 12;
                    int eyeHeight = 8;
                    Rectangle eyeRect = new Rectangle(
                        buttonRect.X + (buttonRect.Width - eyeWidth) / 2,
                        buttonRect.Y + (buttonRect.Height - eyeHeight) / 2,
                        eyeWidth,
                        eyeHeight
                    );

                    using (Pen eyePen = new Pen(branco, 1.5f))
                    {
                        e.Graphics.DrawEllipse(eyePen, eyeRect);

                        Rectangle pupilRect = new Rectangle(
                            eyeRect.X + eyeRect.Width / 2 - 2,
                            eyeRect.Y + eyeRect.Height / 2 - 2,
                            4,
                            4
                        );

                        using (SolidBrush pupilBrush = new SolidBrush(branco))
                        {
                            e.Graphics.FillEllipse(pupilBrush, pupilRect);
                        }
                    }
                }

                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "btnDetalhes")
            {
                var row = dataGridView1.Rows[e.RowIndex];

                string nome = row.Cells["NomeDocente"].Value?.ToString();
                string curso = row.Cells["Curso"].Value?.ToString();
                string nivel = row.Cells["Nivel"].Value?.ToString();
                string disciplina = row.Cells["Disciplina"].Value?.ToString();
                int total = Convert.ToInt32(row.Cells["TotalCargaHoraria"].Value);
                string obs = row.Cells["Observacao"].Value?.ToString();

                using (FormDetalhesDocentes detalhes = new FormDetalhesDocentes(nome, curso, nivel, disciplina, total, obs))
                {
                    detalhes.ShowDialog();
                }
            }
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btprocurar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                string query = @"
                            SELECT 
    d.Nome AS NomeDocente,
    (
        SELECT GROUP_CONCAT(DISTINCT di.Nivel SEPARATOR ', ')
        FROM Disciplinas di
        JOIN turmas tu2 ON tu2.nomedisciplina = di.Nome
        WHERE tu2.docente = d.Nome
    ) AS Niveis,
    (
        SELECT GROUP_CONCAT(DISTINCT di.Nome SEPARATOR ', ')
        FROM Disciplinas di
        JOIN turmas tu2 ON tu2.nomedisciplina = di.Nome
        WHERE tu2.docente = d.Nome
    ) AS Disciplinas,
    (
        SELECT GROUP_CONCAT(DISTINCT c.Nome SEPARATOR ', ')
        FROM Disciplinas di
        JOIN Cursos c ON di.CursoID = c.ID
        JOIN turmas tu2 ON tu2.nomedisciplina = di.Nome
        WHERE tu2.docente = d.Nome
    ) AS Cursos,
    (
        SELECT SUM(di2.CargaHoraria)
        FROM Disciplinas di2
        WHERE di2.Nome IN (
            SELECT tu.nomedisciplina FROM turmas tu WHERE tu.docente = d.Nome
        )
    ) AS TotalCargaHoraria,
    d.Observacao
FROM 
    Docentes d
WHERE 
    d.Nome LIKE @procurar
ORDER BY 
    NomeDocente;
";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@procurar", "%" +txtprocurar.Text.Trim()+"%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }

        }

        private void txtprocurar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btprocurar.PerformClick(); // Simula o clique no botão procurar
            }
        }
    }
}
