﻿using Microsoft.ReportingServices.Diagnostics.Internal;
using MySql.Data.MySqlClient;
using SGC.Helppers;
using SGC.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SGC
{
    public partial class UCGCDisciplina : UserControl
    {
        string conn = $"{Helppers.conexao.connectionString}";
        string curso;
        public UCGCDisciplina()
        {
            InitializeComponent();
        }

        public void verdados()
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();

                string query = "SELECT * FROM disciplinas WHERE curso = @curso";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@curso", curso);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                connection.Close();

                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["cursoID"].Visible = false;
                dataGridView1.Columns["id"].Visible = false;

            }
        }

        private void UCGCDisciplina_Load(object sender, EventArgs e)
        {
            cbcurso.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();
                string query = "SELECT curso FROM gestorescurso WHERE email= @email";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", $"{Helppers.Session.Emailc}");

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        cbcurso.Items.Add(reader["curso"].ToString());
                        curso = reader["curso"].ToString();
                    }

                }
                
            }

            verdados();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void limpardados()
        {
            txtcarga.Text = "";
            txtnome.Text = "";
            cbcurso.Text = "";
            txtnivel.Text = "";
            cbsemestre.Text = "";
        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            if (txtcarga.Text == "" || txtnome.Text == "" || txtnivel.Text == "" || cbcurso.Text == ""||cbsemestre.Text=="")
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
                                if (connection != null)
                                {
                                    connection.Close();
                                }
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
                    if (connection != null)
                    {
                        connection.Close();
                    }
                    connection.Open();

                    string querySupervisor = "SELECT id FROM cursos WHERE nome = @supervisor";
                    MySqlCommand commandSupervisor = new MySqlCommand(querySupervisor, connection);
                    commandSupervisor.Parameters.AddWithValue("@supervisor", cbcurso.Text);
                    int idcurso = Convert.ToInt32(commandSupervisor.ExecuteScalar());
                       // SQL para atualizar os dados na tabela
                    string query = "UPDATE disciplinas SET nome= @nome, cargahoraria = @cargahoraria, Nivel= @Nivel, CursoID= @CursoID, semestre=@semestre, curso= @curso WHERE ID = @ID";

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

        private void btapagar_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Pretende apagar este registo?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Obtenha os dados da linha selecionada no DataGridView
            DataRowView selectedRow = dataGridView1.CurrentRow.DataBoundItem as DataRowView;

            if (selectedRow != null)
            {
                // Recupere o ID da linha selecionada
                int id = Convert.ToInt32(selectedRow["ID"]);

                // Crie uma nova conexão usando a string de conexão
                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    if (check == DialogResult.Yes)
                    {
                        // SQL para deletar a linha da tabela
                        string query = "DELETE FROM disciplinas WHERE ID = @ID";

                        MySqlCommand command = new MySqlCommand(query, connection);


                        command.Parameters.AddWithValue("@ID", id);

                        // Abra a conexão
                        connection.Open();

                        // Execute o comando de exclusão
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {

                            PopupNotifier popup = new PopupNotifier();
                            //popup.TitleText= new Font("Lucida Fax", 11.5F, FontStyle.Bold, );
                            popup.BodyColor = Color.White;
                            popup.Image = Properties.Resources.exit;
                            popup.TitleText = "Sucesso";
                            popup.ContentText = "Registo Eliminado com sucesso!";
                            popup.Popup();

                            limpardados();
                            verdados();
                        }
                        else
                        {
                            Session.Error = "Falha ao deletar a linha. Por favor, tente novamente.";
                            FormError erro = new FormError();
                            erro.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                Session.Error = "Nenhuma Linha foi selecionada, por favor selecione uma!";
                FormError erro = new FormError();
                erro.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void txtcarga_TextChanged(object sender, EventArgs e)
        {
            
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

        private void txtnome_Validating(object sender, CancelEventArgs e)
        {
            string nome = txtnome.Text.Trim();

            if (!Regex.IsMatch(nome, @"[a-zA-Zá-úÁ-Ú]"))
            {
                Session.Error = "O nome deve conter pelo menos uma letra.";
                FormError formError = new FormError();
                formError.ShowDialog();

                txtnome.Focus();
                e.Cancel = true;
            }
        }
    }
}
