﻿using MySql.Data.MySqlClient;
using System;
using SGC.Helppers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using SGC.View;

namespace SGC
{
    public partial class UCDisciplina : UserControl
    {
        string conn = $"{Helppers.conexao.connectionString}";
        string nomedisciplina = "";
        public UCDisciplina()
        {
            InitializeComponent();
        }
        public void verdados()
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {

                connection.Open();

                string query = "SELECT * FROM disciplinas";

                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                connection.Close();

                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["CursoID"].Visible = false;
                dataGridView1.Columns["docenteID"].Visible = false;
                dataGridView1.Columns["id"].Visible = false;


            }
        }
        private void UCDisciplina_Load(object sender, EventArgs e)
        {

            cbcurso.Items.Clear();
            cbdocente.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(conn))
            {

                    connection.Open();

                    string queryc = "SELECT curso FROM gestorescurso WHERE email= @email";
                    MySqlCommand commandc = new MySqlCommand(queryc, connection);
                    commandc.Parameters.AddWithValue("@email", $"{Helppers.Session.Emailc}");

                    if ($"{Helppers.Session.Emailc}" == "")
                    {
                        string query1 = "SELECT nome FROM cursos";
                        MySqlCommand command1 = new MySqlCommand(query1, connection);
                        using (MySqlDataReader readerr = command1.ExecuteReader())
                        {
                            while (readerr.Read())
                            {

                                cbcurso.Items.Add(readerr["nome"].ToString());

                            }
                        }
                    }
                    else if ($"{Helppers.Session.Emailc}" != "")
                    {

                        using (MySqlDataReader reader = commandc.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                cbcurso.Items.Add(reader["curso"].ToString());

                            }

                        }
                    }
              
                string queryd = "SELECT nome FROM docentes";

                MySqlCommand commandd = new MySqlCommand(queryd, connection);

                using (MySqlDataReader readerd = commandd.ExecuteReader())
                {
                    while (readerd.Read())
                    {

                        cbdocente.Items.Add(readerd["nome"].ToString());

                    }

                }
            }
            
            verdados();
        }

        private void btactualizar_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = dataGridView1.CurrentRow.DataBoundItem as DataRowView;

            if (selectedRow != null)
            {
                // Recupere o ID da linha selecionada
                int id = Convert.ToInt32(selectedRow["ID"]);
            
                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    // Abra a conexão
                    connection.Open();

                    string querySupervisor = "SELECT id FROM cursos WHERE nome = @supervisor";
                    MySqlCommand commandSupervisor = new MySqlCommand(querySupervisor, connection);
                    commandSupervisor.Parameters.AddWithValue("@supervisor", cbcurso.Text);
                    int idcurso = Convert.ToInt32(commandSupervisor.ExecuteScalar());

                    string querydocente = "SELECT id FROM docentes WHERE nome = @docente";
                    MySqlCommand commandd = new MySqlCommand(querydocente, connection);
                    commandd.Parameters.AddWithValue("@docente", cbdocente.Text);
                    int iddocente = Convert.ToInt32(commandd.ExecuteScalar());

                    // SQL para atualizar os dados na tabela
                    string query = "UPDATE disciplinas SET nome= @nome , cargahoraria = @cargahoraria , Nivel= @Nivel, CursoID= @CursoID, semestre=@semestre, docenteID= @docenteid, curso= @curso, docente=@docente WHERE ID = @ID";

                    // Crie um novo comando com a consulta SQL e a conexão
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Adicione os parâmetros
                    command.Parameters.AddWithValue("@nome", txtnome.Text);
                    command.Parameters.AddWithValue("@cargahoraria", txtcarga.Text);
                    command.Parameters.AddWithValue("@Nivel", txtnivel.Text);
                    command.Parameters.AddWithValue("@CursoID", idcurso);
                    command.Parameters.AddWithValue("@semestre", cbsemestre.Text);
                    command.Parameters.AddWithValue("@docenteid", iddocente);
                    command.Parameters.AddWithValue("@docente", cbdocente.Text);
                    command.Parameters.AddWithValue("@curso", cbcurso.Text);
                    command.Parameters.AddWithValue("@ID", id);


                    // Execute o comando de atualização
                    int rowsAffected = command.ExecuteNonQuery();

                    // Feche a conexão
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        PopupNotifier popup = new PopupNotifier();
                        //popup.TitleText= new Font("Lucida Fax", 11.5F, FontStyle.Bold, );
                        popup.BodyColor = Color.White;
                        popup.Image = Properties.Resources.ok_48px;
                        popup.TitleText = "Sucesso";
                        popup.ContentText = "Registo Actualizado com sucesso!";
                        popup.Popup();

                        // Após a exclusão, recarregue os dados no DataGridView para refletir as alterações
                        verdados();
                    }
                    else
                    {
                        Session.Error = "Falha ao atualizar os dados. Por favor, tente novamente.";
                        FormError erro = new FormError();
                        erro.ShowDialog();
                    }
                }
            }
            else
            {
                Session.Error = "Por favor, selecione uma linha para atualizar.";
                FormError erro = new FormError();
                erro.ShowDialog();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                // Obtém os valores da célula na linha selecionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Preenche os TextBox com os valores da linha selecionada
                txtnome.Text = row.Cells["nome"].Value.ToString();
                txtnivel.Text = row.Cells["Nivel"].Value.ToString();
                txtcarga.Text = row.Cells["cargahoraria"].Value.ToString();
                cbcurso.Text = row.Cells["curso"].Value.ToString();
                cbsemestre.Text = row.Cells["Semestre"].Value.ToString();
                cbdocente.Text = row.Cells["docente"].Value.ToString();

                // Obtém o valor da célula na coluna "ID" da linha selecionada
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
            }
            else
            {
                Session.Error = "Nenhuma Linha foi selecionada, por favor selecione uma!";
                FormError erro = new FormError();
                erro.ShowDialog();
            }
        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            

            try
            {
                using (MySqlConnection connection1 = new MySqlConnection(conn))
                {

                    connection1.Open();
                    string queryVerificar = "SELECT COUNT(*) FROM Disciplinas WHERE Nome = @nomeDisciplina AND curso=@curso";
                    MySqlCommand commandVerificar = new MySqlCommand(queryVerificar, connection1);
                    
                    commandVerificar.Parameters.AddWithValue("@nomeDisciplina", txtnome.Text);
                    commandVerificar.Parameters.AddWithValue("@curso", cbcurso.Text);
                    int count = Convert.ToInt32(commandVerificar.ExecuteScalar());

                        if (count > 0)
                        {
                        Session.Error = "O nome da Diciplina Já existe, Tente com outro nome!";
                        FormError erro = new FormError();
                        erro.ShowDialog();
                        }
                        else
                        { 
                    using (MySqlConnection connection = new MySqlConnection(conn))
                    {

                        // Abra a conexão
                        connection.Open();
                        string querySupervisor = "SELECT id FROM cursos WHERE nome = @supervisor";
                        MySqlCommand commandSupervisor = new MySqlCommand(querySupervisor, connection);
                        commandSupervisor.Parameters.AddWithValue("@supervisor", cbcurso.Text);
                        int idcurso = Convert.ToInt32(commandSupervisor.ExecuteScalar());

                        string queryd = "SELECT id FROM docentes WHERE nome = @dd";
                        MySqlCommand commandd = new MySqlCommand(queryd, connection);
                        commandd.Parameters.AddWithValue("@dd", cbdocente.Text);
                        int iddocente = Convert.ToInt32(commandd.ExecuteScalar());

                            string query = "INSERT INTO disciplinas (nome, cargahoraria, Nivel, cursoID, docenteID, Semestre, curso) VALUES (@nome, @cargahoraria, @Nivel, @cursoID, @docenteID, @Semestre, @curso)";

                            // Crie um novo comando com a consulta SQL e a conexão
                            MySqlCommand command = new MySqlCommand(query, connection);

                            // Adicione os parâmetros
                            command.Parameters.AddWithValue("@nome", txtnome.Text);
                            command.Parameters.AddWithValue("@cargahoraria", txtcarga.Text);
                            command.Parameters.AddWithValue("@Nivel", txtnivel.Text);
                            command.Parameters.AddWithValue("@cursoID", idcurso);
                            command.Parameters.AddWithValue("@docenteID", iddocente);
                            command.Parameters.AddWithValue("@Semestre", cbsemestre.Text);
                            command.Parameters.AddWithValue("@curso", cbcurso.Text);


                            // Execute o comando de inserção
                            command.ExecuteNonQuery();


                            PopupNotifier popup = new PopupNotifier();
                            //popup.TitleText= new Font("Lucida Fax", 11.5F, FontStyle.Bold, );
                            popup.BodyColor = Color.White;
                            popup.Image = Properties.Resources.ok_48px;
                            popup.TitleText = "Sucesso";
                            popup.ContentText = "Dados Cadastrados com sucesso!";
                            popup.Popup();

                            verdados();
                            // Feche a conexão
                            connection.Close();
                        
                        
                            }
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

        private void btapagar_Click(object sender, EventArgs e)
        {

        }
    }
}