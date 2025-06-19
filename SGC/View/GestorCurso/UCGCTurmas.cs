using MySql.Data.MySqlClient;
using SGC.Helppers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tulpep.NotificationWindow;

namespace SGC.View.GestorCurso
{
    public partial class UCGCTurmas : UserControl
    {
        string conn = $"{Helppers.conexao.connectionString}";

        int quantidade, quantidaderestante;

        public UCGCTurmas()
        {
            InitializeComponent();
        }

        private void UCGCTurmas_Load(object sender, EventArgs e)
        {
            cbcurso.Items.Clear();
            cbdisciplina.Items.Clear();
            cbdocente.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();
                string querydo = "SELECT nome FROM docentes";
                string queryc = "SELECT nome FROM cursos";
                string querydi = "SELECT nome FROM disciplinas";

                MySqlCommand commanddo = new MySqlCommand(querydo, connection);

                MySqlCommand commanddi = new MySqlCommand(querydi, connection);
                MySqlCommand commandc = new MySqlCommand(queryc, connection);

                using (MySqlDataReader reader = commanddo.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbdocente.Items.Add(reader["nome"].ToString());
                    }

                }
                using (MySqlDataReader readerdi = commanddi.ExecuteReader())
                {
                    while (readerdi.Read())
                    {
                        cbdisciplina.Items.Add(readerdi["nome"].ToString());
                    }

                }
                using (MySqlDataReader readerc = commandc.ExecuteReader())
                {
                    while (readerc.Read())
                    {
                        cbcurso.Items.Add(readerc["nome"].ToString());
                    }

                }

            }
            verdados();

        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            if (txtcarga.Text == "" || cbcurso.Text == "" || cbano.Text == "" || cbcurso.Text == "" || cbsemestre.Text == "")
            {

                Session.Error = "Por favor, preenche todos os campos!";
                FormError formError = new FormError();
                formError.ShowDialog();

            }
            else
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
                        
                       
                            using (MySqlConnection connection = new MySqlConnection(conn))
                            {
                                if (connection != null)
                                {
                                    connection.Close();
                                }
                                connection.Open();
                                string querycurso = "SELECT id FROM cursos WHERE nome = @curso";
                                MySqlCommand commandcurso = new MySqlCommand(querycurso, connection);
                                commandcurso.Parameters.AddWithValue("@curso", cbcurso.Text);
                                int idcurso = Convert.ToInt32(commandcurso.ExecuteScalar());

                               
                                string query = "INSERT INTO turmas (nomedisciplina, cargahoraria, ano, cursoID, Semestre, curso, docente, regime, anoletivo) VALUES (@nomedisciplina, @cargahoraria, @ano, @cursoID, @Semestre, @curso, @docente, @regime, @anoletivo)";

                                // Crie um novo comando com a consulta SQL e a conexão
                                MySqlCommand command = new MySqlCommand(query, connection);

                                // Adicione os parâmetros
                                command.Parameters.AddWithValue("@nomedisciplina", cbdisciplina.Text);
                                command.Parameters.AddWithValue("@cargahoraria", txtcarga.Text);
                                command.Parameters.AddWithValue("@ano", cbano.Text);
                                command.Parameters.AddWithValue("@cursoID", idcurso);
                                command.Parameters.AddWithValue("@Semestre", cbsemestre.Text);
                                command.Parameters.AddWithValue("@curso", cbcurso.Text);
                                command.Parameters.AddWithValue("@docente", cbdocente.Text);
                                command.Parameters.AddWithValue("@anoletivo", cbdata.Value);
                                command.Parameters.AddWithValue("@regime", cbregime.Text);


                                // Execute o comando de inserção
                                command.ExecuteNonQuery();


                                PopupNotifier popup = new PopupNotifier();
                                //popup.TitleText= new Font("Lucida Fax", 11.5F, FontStyle.Bold, );
                                popup.BodyColor = Color.White;
                                popup.Image = Properties.Resources.ok_48px;
                                popup.TitleText = "Sucesso";
                                popup.ContentText = "Dados Cadastrados com sucesso!";
                                popup.Popup();

                                // Feche a conexão
                                connection.Close();
                                verdados();                               
                                // selecionardocente();
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    Session.Error = " " + ex.Message;
                    FormError erro = new FormError();
                    erro.ShowDialog();

                }

            }
        }

        private void cbdisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();
                string queryc = "SELECT cargahoraria FROM disciplinas where nome=@nomedisciplina";

                MySqlCommand commandc = new MySqlCommand(queryc, connection);
                commandc.Parameters.AddWithValue("@nomedisciplina", cbdisciplina.Text);
                commandc.ExecuteNonQuery();

                using (MySqlDataReader reader = commandc.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtcarga.Text= reader["cargahoraria"].ToString();
                    }

                }

            }

        }
        //private void selecionardocente()
        //{
        //    using (MySqlConnection connection = new MySqlConnection(conn))
        //    {
        //        if (connection != null)
        //        {
        //            connection.Close();
        //        }
        //        lnomedocente.Visible = true;
        //        lnivelacademico.Visible = true;
        //        lquantmax.Visible = true;
        //        lquantrestante.Visible = true;
        //        lquantcadeiras.Visible = true;

        //        lnomedocente.Text = cbdocente.Text;


        //        connection.Open();
        //        string queryc = @"
        //    SELECT nivelacademico, numcarga 
        //    FROM docentes 
        //    WHERE nome = @nomedocente";

        //        MySqlCommand commandc = new MySqlCommand(queryc, connection);
        //        commandc.Parameters.AddWithValue("@nomedocente", cbdocente.Text);

        //        int cargaMaxima = 0;

        //        using (MySqlDataReader reader = commandc.ExecuteReader())
        //        {
        //            if (reader.Read())
        //            {
        //                lnivelacademico.Text = reader["nivelacademico"].ToString();
        //                lquantmax.Text = reader["numcarga"].ToString();
        //                int.TryParse(reader["numcarga"].ToString(), out cargaMaxima);
        //            }
        //        }

        //        // Query para contar disciplinas e somar carga horária
        //        string query = @"
        //    SELECT 
        //        COUNT(*) AS totalcadeiras, 
        //        SUM(t.cargahoraria) AS totalcarga 
        //    FROM turmas t 
        //    WHERE t.docente = @nomedocente";

        //        MySqlCommand command = new MySqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@nomedocente", cbdocente.Text);

        //        int totalCadeiras = 0;
        //        int totalCarga = 0;

        //        using (MySqlDataReader reader2 = command.ExecuteReader())
        //        {
        //            if (reader2.Read())
        //            {
        //                int.TryParse(reader2["totalcadeiras"].ToString(), out totalCadeiras);
        //                int.TryParse(reader2["totalcarga"].ToString(), out totalCarga);

        //                lquantcadeiras.Text = totalCadeiras.ToString();
        //            }
        //        }

        //        int restante = cargaMaxima - totalCarga;
        //        lquantrestante.Text = restante.ToString();

        //        if (restante <= 0)
        //        {
        //            Session.Error = "Atingiu limite de cargas para este docente!";
        //            FormError formError = new FormError();
        //            formError.ShowDialog();
        //        }
        //    }
        //}
        private void CarregarDisciplinas()
        {
            if (cbano.SelectedItem == null || cbcurso.SelectedItem == null || cbsemestre.SelectedItem == null)
                return;

            string nivel = cbano.SelectedItem.ToString();
            string curso = cbcurso.SelectedItem.ToString();
            string semestre = cbsemestre.SelectedItem.ToString();

            string query = @"
                    SELECT DISTINCT d.Nome
                    FROM disciplinas d
                    LEFT JOIN turmas t 
                        ON d.Nome = t.nomedisciplina 
                        AND d.Curso = t.curso 
                        AND d.Nivel = t.ano 
                        AND d.Semestre = t.semestre
                    WHERE 
                        d.Nivel = @nivel AND 
                        d.Curso = @curso AND 
                        d.Semestre = @semestre AND 
                        (t.docente IS NULL OR t.docente = '')
                    ORDER BY d.Nome;";

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nivel", nivel);
                command.Parameters.AddWithValue("@curso", curso);
                command.Parameters.AddWithValue("@semestre", semestre);

                MySqlDataReader reader = command.ExecuteReader();

                cbdisciplina.Items.Clear();
                cbdisciplina.Text = ""; // Limpa o texto atual

                while (reader.Read())
                {
                    cbdisciplina.Items.Add(reader["Nome"].ToString());
                }

                if (cbdisciplina.Items.Count == 0)
                {
                    cbdisciplina.Text = "Sem disciplinas disponíveis";
                }
            }
        }
        public void verdados()
        {
            string query = "SELECT * FROM turmas ORDER BY ano, curso, nomedisciplina;";

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["cursoid"].Visible = false;

            }
        }

        private void cbano_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDisciplinas();
        }

        private void cbregime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbcurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDisciplinas();
        }

        private void cbsemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDisciplinas();

        }

        private void btprocurar_Click(object sender, EventArgs e)
        {
            string query = @"
                    SELECT * FROM turmas 
                    WHERE 
                        docente LIKE @busca OR 
                        nomedisciplina LIKE @busca OR 
                        curso LIKE @busca OR 
                        ano LIKE @busca OR 
                        semestre LIKE @busca OR 
                        regime LIKE @busca
                    ORDER BY ano, curso, nomedisciplina;
                ";

                        using (MySqlConnection connection = new MySqlConnection(conn))
                        {
                            connection.Open();
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@busca", "%" + txtprocurar.Text + "%");

                            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dataGridView1.DataSource = dt;
                        }
        }

        private void txtprocurar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btprocurar.PerformClick();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Garante que clicou numa linha válida
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Carregar valores nos campos
                cbcurso.Text = row.Cells["curso"].Value?.ToString();
                cbano.Text = row.Cells["ano"].Value?.ToString();
                cbregime.Text = row.Cells["regime"].Value?.ToString();
                cbsemestre.Text = row.Cells["semestre"].Value?.ToString();
                cbdisciplina.Text = row.Cells["nomedisciplina"].Value?.ToString();
                cbdocente.Text = row.Cells["docente"].Value?.ToString();
            }
        }
        private void AtualizarDocente()
        {
            string query = @"
        UPDATE turmas
        SET docente = @docente
        WHERE 
            curso = @curso AND 
            ano = @ano AND 
            regime = @regime AND 
            semestre = @semestre AND 
            nomedisciplina = @disciplina;
    ";

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Adiciona os parâmetros com os valores dos controles
                    command.Parameters.AddWithValue("@docente", cbdocente.Text.Trim());
                    command.Parameters.AddWithValue("@curso", cbcurso.Text.Trim());
                    command.Parameters.AddWithValue("@ano", cbano.Text.Trim());
                    command.Parameters.AddWithValue("@regime", cbregime.Text.Trim());
                    command.Parameters.AddWithValue("@semestre", cbsemestre.Text.Trim());
                    command.Parameters.AddWithValue("@disciplina", cbdisciplina.Text.Trim());

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Session.Sucess = "Alocação atualizada com sucesso!";
                        FormSucess sucess = new FormSucess();
                        sucess.ShowDialog();
                        verdados(); 
                    }
                    else
                    {
                        Session.Error = "Nenhum registo foi encontrado para atualizar.";
                        FormError error = new FormError();
                        error.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    Session.Error = "Erro ao atualizar:"+ ex.Message;
                    FormError error = new FormError();
                    error.ShowDialog();
                }
            }
        }

        private void btactualizar_Click(object sender, EventArgs e)
        {
            AtualizarDocente();
        }

        private void cbdocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selecionardocente();
        }
    }
}
