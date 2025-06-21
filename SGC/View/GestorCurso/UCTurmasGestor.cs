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

namespace SGC.View.GestorCurso
{
    public partial class UCTurmasGestor : UserControl
    {
        string conn = $"{Helppers.conexao.connectionString}";

        public UCTurmasGestor()
        {
            InitializeComponent();
        }

        private void UCTurmasGestor_Load(object sender, EventArgs e)
        {
            cbdisciplina.Items.Clear();
            cbdocente.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();

                // 1. Docentes do curso
                string querydo = "SELECT DISTINCT nome FROM docentes WHERE curso = @curso";

                // 2. Curso do gestor (só o próprio curso)
                string queryc = "SELECT nome FROM cursos WHERE nome = @curso";

                // 3. Disciplinas do curso
                string querydi = "SELECT nome FROM disciplinas WHERE curso = @curso";

                // --- DOCENTES ---
                using (MySqlCommand commanddo = new MySqlCommand(querydo, connection))
                {
                    commanddo.Parameters.AddWithValue("@curso", Session.curso);
                    using (MySqlDataReader reader = commanddo.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbdocente.Items.Add(reader["nome"].ToString());
                        }
                    }
                }

                // --- DISCIPLINAS ---
                using (MySqlCommand commanddi = new MySqlCommand(querydi, connection))
                {
                    commanddi.Parameters.AddWithValue("@curso", Session.curso);
                    using (MySqlDataReader readerdi = commanddi.ExecuteReader())
                    {
                        while (readerdi.Read())
                        {
                            cbdisciplina.Items.Add(readerdi["nome"].ToString());
                        }
                    }
                }

                cbcurso.Items.Add(Session.curso);
            }

            verdados();

        }
        private void EliminarTurma()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Alerta personalizado (usando FormAlertaContinuar)
                FormAlertaContinuar alerta = new FormAlertaContinuar(
                    "Tem certeza que deseja eliminar esta turma?\n\nEssa ação não pode ser desfeita."
                );
                DialogResult resposta = alerta.ShowDialog();

                // Se usuário clicar em "Não", cancela
                if (resposta == DialogResult.No)
                    return;

                // Pegando o ID da turma selecionada
                int turmaId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    connection.Open();
                    string query = "DELETE FROM turmas WHERE id = @id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", turmaId);
                        int resultado = command.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            Session.Sucess = "Turma eliminada com sucesso!";
                            FormSucess sucess = new FormSucess();
                            sucess.ShowDialog();

                            verdados(); // Atualiza a DataGridView
                        }
                        else
                        {
                            Session.Error = "Erro ao eliminar a turma.";
                            FormError formError = new FormError();
                            formError.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                Session.Error = "Selecione uma turma para eliminar.";
                FormError formError = new FormError();
                formError.ShowDialog();
            }
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
                string docente = cbdocente.Text.Trim();
                string curso = cbcurso.Text.Trim();
                string ano = cbano.Text.Trim();
                string regime = cbregime.Text.Trim();
                string semestre = cbsemestre.Text.Trim();
                string disciplina = cbdisciplina.Text.Trim();
                DateTime anoletivo = cbdata.Value;

                int cargaNova = 0;
                int cargaTotalAtual = 0;
                int cargaPermitida = 0;

                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    connection.Open();

                    // 1. Buscar carga horária da disciplina
                    string queryCarga = @"
                                SELECT cargahoraria 
                                FROM disciplinas 
                                WHERE nome = @disciplina 
                                  AND curso = @curso 
                                  AND nivel = @ano 
                                  AND semestre = @semestre";

                    MySqlCommand cmdCarga = new MySqlCommand(queryCarga, connection);
                    cmdCarga.Parameters.AddWithValue("@disciplina", disciplina);
                    cmdCarga.Parameters.AddWithValue("@curso", curso);
                    cmdCarga.Parameters.AddWithValue("@ano", ano);
                    cmdCarga.Parameters.AddWithValue("@semestre", semestre);

                    object cargaObj = cmdCarga.ExecuteScalar();
                    if (cargaObj != null)
                        cargaNova = Convert.ToInt32(cargaObj);
                    else
                    {
                        Session.Error = "Disciplina não encontrada. Verifique os dados.";
                        FormError formError = new FormError();
                        formError.ShowDialog();
                        return;
                    }

                    // 2. Buscar carga horária máxima permitida ao docente
                    string queryCargaMax = "SELECT numcarga FROM docentes WHERE nome = @docente";
                    MySqlCommand cmdMax = new MySqlCommand(queryCargaMax, connection);
                    cmdMax.Parameters.AddWithValue("@docente", docente);
                    object maxObj = cmdMax.ExecuteScalar();

                    if (maxObj != null)
                        cargaPermitida = Convert.ToInt32(maxObj);
                    else
                    {
                        Session.Error = "Docente não encontrado.";
                        FormError formError = new FormError();
                        formError.ShowDialog();
                        return;
                    }

                    // 3. Soma da carga já atribuída ao docente
                    string queryTotal = "SELECT IFNULL(SUM(cargahoraria), 0) FROM turmas WHERE docente = @docente";
                    MySqlCommand cmdTotal = new MySqlCommand(queryTotal, connection);
                    cmdTotal.Parameters.AddWithValue("@docente", docente);
                    cargaTotalAtual = Convert.ToInt32(cmdTotal.ExecuteScalar());

                    // 4. Verificação de limite
                    int cargaRestante = cargaPermitida - cargaTotalAtual;

                    if (cargaNova > cargaRestante)
                    {
                        FormAlertaContinuar alerta = new FormAlertaContinuar(
                         $"O docente já tem {cargaTotalAtual}h atribuídas.\n" +
                         $"Esta disciplina adicionará mais {cargaNova}h, excedendo o limite de {cargaPermitida}h.\n\n" +
                         "Deseja continuar mesmo assim?"
                     );

                        DialogResult resposta = alerta.ShowDialog();

                        if (resposta == DialogResult.No)
                            return; // Usuário cancelou

                    }
                    // 4.1 Verificar se já existe
                    string verificarQuery = @"
                                        SELECT COUNT(*) FROM turmas 
                                        WHERE docente = @docente AND 
                                                curso = @curso AND 
                                                ano = @ano AND 
                                                regime = @regime AND 
                                                semestre = @semestre AND 
                                                nomedisciplina = @disciplina";

                    MySqlCommand verificarCmd = new MySqlCommand(verificarQuery, connection);
                    verificarCmd.Parameters.AddWithValue("@docente", docente);
                    verificarCmd.Parameters.AddWithValue("@curso", curso);
                    verificarCmd.Parameters.AddWithValue("@ano", ano);
                    verificarCmd.Parameters.AddWithValue("@regime", regime);
                    verificarCmd.Parameters.AddWithValue("@semestre", semestre);
                    verificarCmd.Parameters.AddWithValue("@disciplina", disciplina);

                    int existe = Convert.ToInt32(verificarCmd.ExecuteScalar());
                    if (existe > 0)
                    {
                        Session.Error = "Este docente já está associado a esta disciplina.";
                        FormError error = new FormError();
                        error.ShowDialog();
                        return;
                    }


                    // 5. Inserir novo registo
                    string insertQuery = @"
                                            INSERT INTO turmas (docente, curso, ano, regime, semestre, nomedisciplina, cargahoraria, anoletivo)
                                            VALUES (@docente, @curso, @ano, @regime, @semestre, @disciplina, @cargahoraria, @anoletivo)";

                    MySqlCommand cmdInsert = new MySqlCommand(insertQuery, connection);
                    cmdInsert.Parameters.AddWithValue("@docente", docente);
                    cmdInsert.Parameters.AddWithValue("@curso", curso);
                    cmdInsert.Parameters.AddWithValue("@ano", ano);
                    cmdInsert.Parameters.AddWithValue("@regime", regime);
                    cmdInsert.Parameters.AddWithValue("@semestre", semestre);
                    cmdInsert.Parameters.AddWithValue("@disciplina", disciplina);
                    cmdInsert.Parameters.AddWithValue("@cargahoraria", cargaNova);
                    cmdInsert.Parameters.AddWithValue("@anoletivo", anoletivo);

                    int result = cmdInsert.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Session.Sucess = "Docente cadastrado com sucesso!";
                        FormSucess sucess = new FormSucess();
                        sucess.ShowDialog();
                        verdados(); // Atualiza a DataGridView, se necessário
                    }
                    else
                    {
                        Session.Error = "Erro ao cadastrar docente.";
                        FormError error = new FormError();
                        error.ShowDialog();
                    }
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
                        txtcarga.Text = reader["cargahoraria"].ToString();
                    }

                }

            }
        }
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
            string query = @"
        SELECT * 
        FROM turmas 
        WHERE curso = @cursoGestor 
        ORDER BY ano, curso, nomedisciplina;
    ";

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@cursoGestor", Session.curso);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                if (dataGridView1.Columns.Contains("id"))
                    dataGridView1.Columns["id"].Visible = false;

                if (dataGridView1.Columns.Contains("cursoid"))
                    dataGridView1.Columns["cursoid"].Visible = false;
            }
        }

        private void cbcurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDisciplinas();
        }

        private void cbano_SelectedIndexChanged(object sender, EventArgs e)
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

                btactualizar.Enabled = true;
                btapagar.Enabled = true;
            }
        }

        private void txtprocurar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btprocurar.PerformClick();
            }
        }
        private void AtualizarDocenteComValidacao()
        {
            string docente = cbdocente.Text.Trim();
            string curso = cbcurso.Text.Trim();
            string ano = cbano.Text.Trim();
            string regime = cbregime.Text.Trim();
            string semestre = cbsemestre.Text.Trim();
            string disciplina = cbdisciplina.Text.Trim();

            int cargaNova = 0;
            int cargaTotalAtual = 0;
            int cargaPermitida = 0;

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();

                // 1. Buscar carga horária da disciplina atual
                string queryCargaNova = @"
                    SELECT cargahoraria 
                    FROM disciplinas 
                    WHERE nome = @disciplina 
                      AND curso = @curso 
                      AND nivel = @ano 
                      AND semestre = @semestre";

                MySqlCommand cmdNova = new MySqlCommand(queryCargaNova, connection);
                cmdNova.Parameters.AddWithValue("@disciplina", disciplina);
                cmdNova.Parameters.AddWithValue("@curso", curso);
                cmdNova.Parameters.AddWithValue("@ano", ano);
                cmdNova.Parameters.AddWithValue("@semestre", semestre);

                object cargaObj = cmdNova.ExecuteScalar();
                if (cargaObj != null)
                    cargaNova = Convert.ToInt32(cargaObj);
                else
                {
                    Session.Error = "Disciplina não encontrada.";
                    FormError formError = new FormError();
                    formError.ShowDialog();
                    return;
                }

                // 2. Buscar carga máxima permitida do docente
                string queryMax = "SELECT numcarga FROM docentes WHERE nome = @nome";
                MySqlCommand cmdMax = new MySqlCommand(queryMax, connection);
                cmdMax.Parameters.AddWithValue("@nome", docente);
                object maxObj = cmdMax.ExecuteScalar();

                if (maxObj != null)
                    cargaPermitida = Convert.ToInt32(maxObj);
                else
                {
                    Session.Error = "Docente não encontrado";
                    FormError formError = new FormError();
                    formError.ShowDialog();
                    return;
                }

                // 3. Soma da carga já atribuída ao docente
                string queryTotal = "SELECT IFNULL(SUM(cargahoraria), 0) FROM turmas WHERE docente = @docente";
                MySqlCommand cmdTotal = new MySqlCommand(queryTotal, connection);
                cmdTotal.Parameters.AddWithValue("@docente", docente);
                cargaTotalAtual = Convert.ToInt32(cmdTotal.ExecuteScalar());

                // 4. Verificação de limite
                int cargaRestante = cargaPermitida - cargaTotalAtual;

                if (cargaNova > cargaRestante)
                {
                    FormAlertaContinuar alerta = new FormAlertaContinuar(
                     $"O docente já tem {cargaTotalAtual}h atribuídas.\n" +
                     $"Esta disciplina adicionará mais {cargaNova}h, excedendo o limite de {cargaPermitida}h.\n\n" +
                     "Deseja continuar mesmo assim?"
                 );

                    DialogResult resposta = alerta.ShowDialog();

                    if (resposta == DialogResult.No)
                        return; // Usuário cancelou
                }

                // 5. Faz a atualização
                string updateQuery = @"
                    UPDATE turmas
                    SET docente = @docente
                    WHERE 
                        curso = @curso AND 
                        ano = @ano AND 
                        regime = @regime AND 
                        semestre = @semestre AND 
                        nomedisciplina = @disciplina;
                ";

                MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, connection);
                cmdUpdate.Parameters.AddWithValue("@docente", docente);
                cmdUpdate.Parameters.AddWithValue("@curso", curso);
                cmdUpdate.Parameters.AddWithValue("@ano", ano);
                cmdUpdate.Parameters.AddWithValue("@regime", regime);
                cmdUpdate.Parameters.AddWithValue("@semestre", semestre);
                cmdUpdate.Parameters.AddWithValue("@disciplina", disciplina);

                int result = cmdUpdate.ExecuteNonQuery();

                if (result > 0)
                {
                    Session.Sucess = "Docente atualizado com sucesso!";
                    FormSucess sucess = new FormSucess();
                    sucess.ShowDialog();
                    verdados(); // Recarregar tabela, se desejar
                }
                else
                {
                    Session.Error = "Não foi possível atualizar. Verifique os dados.";
                    FormError formError = new FormError();
                    formError.ShowDialog();
                }
            }
        }

        private void btactualizar_Click(object sender, EventArgs e)
        {
            AtualizarDocenteComValidacao();
        }

        private void btapagar_Click(object sender, EventArgs e)
        {
            EliminarTurma();
        }
    }
}
