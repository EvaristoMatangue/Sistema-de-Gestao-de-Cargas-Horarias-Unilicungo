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
                dataGridView1.Columns["id"].Visible = false;


            }
        }
        private void UCDisciplina_Load(object sender, EventArgs e)
        {

            cbcurso.Items.Clear();

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
            }

            verdados();
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
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

                btactualizar.Enabled = true;
                btapagar.Enabled = true;
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

        private void btcadastrar_Click_1(object sender, EventArgs e)
        {
            if (txtcarga.Text == "" || txtnivel.Text == "" || txtnome.Text == "" || cbcurso.Text == "" || cbsemestre.Text == "")
            {

                Session.Error = "Por favor, preenche todos os campos!";
                FormError formError = new FormError();
                formError.ShowDialog();

            }
            else
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

                            string query = "INSERT INTO disciplinas (nome, cargahoraria, Nivel, cursoID, Semestre, curso) VALUES (@nome, @cargahoraria, @Nivel, @cursoID, @Semestre, @curso)";

                            // Crie um novo comando com a consulta SQL e a conexão
                            MySqlCommand command = new MySqlCommand(query, connection);

                            // Adicione os parâmetros
                            command.Parameters.AddWithValue("@nome", txtnome.Text);
                            command.Parameters.AddWithValue("@cargahoraria", txtcarga.Text);
                            command.Parameters.AddWithValue("@Nivel", txtnivel.Text);
                            command.Parameters.AddWithValue("@cursoID", idcurso);
                            command.Parameters.AddWithValue("@Semestre", cbsemestre.Text);
                            command.Parameters.AddWithValue("@curso", cbcurso.Text);


                            // Execute o comando de inserção
                            command.ExecuteNonQuery();

                            Session.Sucess = "Dados Cadastrados com sucesso!";
                            FormSucess sucess = new FormSucess();
                            sucess.ShowDialog();

                            verdados();
                            // Feche a conexão
                            connection.Close();

                        }
                    }
                }

            }

        }

        private void btactualizar_Click_1(object sender, EventArgs e)
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
                     // SQL para atualizar os dados na tabela
                    string query = "UPDATE disciplinas SET nome= @nome , cargahoraria = @cargahoraria , Nivel= @Nivel, CursoID= @CursoID, semestre=@semestre, curso= @curso WHERE ID = @ID";

                    // Crie um novo comando com a consulta SQL e a conexão
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Adicione os parâmetros
                    command.Parameters.AddWithValue("@nome", txtnome.Text);
                    command.Parameters.AddWithValue("@cargahoraria", txtcarga.Text);
                    command.Parameters.AddWithValue("@Nivel", txtnivel.Text);
                    command.Parameters.AddWithValue("@CursoID", idcurso);
                    command.Parameters.AddWithValue("@semestre", cbsemestre.Text);
                    command.Parameters.AddWithValue("@curso", cbcurso.Text);
                    command.Parameters.AddWithValue("@ID", id);


                    // Execute o comando de atualização
                    int rowsAffected = command.ExecuteNonQuery();

                    // Feche a conexão
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        Session.Sucess = "Registo Actualizado com sucesso!";
                        FormSucess sucess = new FormSucess();
                        sucess.ShowDialog();

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

        private void txtcarga_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtcarga.Text, out int cargaHoraria))
            {
                if (cargaHoraria > 6)
                {
                    Session.Error = "A carga horária não pode exceder 6 horas.";
                    FormError erro = new FormError();
                    erro.ShowDialog();
                    txtcarga.Text = "6";
                    txtcarga.SelectionStart = txtcarga.Text.Length;
                }
            }
            else if (!string.IsNullOrEmpty(txtcarga.Text))
            {
                Session.Error = "Insira um valor numérico válido.";
                FormError erro = new FormError();
                erro.ShowDialog();
                txtcarga.Text = string.Empty;
            }
        }

        private void btapagar_Click(object sender, EventArgs e)
        {
            FormAlertaContinuar alerta = new FormAlertaContinuar(
         "Tem certeza que deseja eliminar esta disciplina?\n\n" +
         "Esta ação é permanente e não poderá ser desfeita.\n\n" +
         "Deseja continuar?"
     );
            DialogResult check = alerta.ShowDialog();

            if (check != DialogResult.Yes)
                return; // Usuário cancelou

            // Obtenha os dados da linha selecionada no DataGridView
            DataRowView selectedRow = dataGridView1.CurrentRow?.DataBoundItem as DataRowView;

            if (selectedRow != null)
            {
                int id = Convert.ToInt32(selectedRow["ID"]);

                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    string query = "DELETE FROM disciplinas WHERE ID = @ID";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Alerta visual com PopupNotifier
                        PopupNotifier popup = new PopupNotifier();
                        popup.BodyColor = Color.White;
                        popup.Image = Properties.Resources.exit; // Imagem personalizada
                        popup.TitleText = "Sucesso";
                        popup.ContentText = "Registo eliminado com sucesso!";
                        popup.Popup();

                        limpardados();
                        verdados();
                    }
                    else
                    {
                        Session.Error = "Falha ao eliminar o registo. Por favor, tente novamente.";
                        FormError erro = new FormError();
                        erro.ShowDialog();
                    }
                }
            }
            else
            {
                Session.Error = "Nenhuma linha foi selecionada. Por favor, selecione uma!";
                FormError erro = new FormError();
                erro.ShowDialog();
            }
        }
        public void limpardados()
        {
            txtcarga.Text = "";
            txtnome.Text = "";
            cbcurso.Text = "";
            txtnivel.Text = "";
            cbsemestre.Text = "";
        }

    }
}
