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

        private void cbdocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                if (connection != null)
                {
                    connection.Close();
                }
                lnomedocente.Visible = true;
                lnivelacademico.Visible = true;
                lquantmax.Visible = true;
                lquantrestante.Visible = true;
                lquantcadeiras.Visible = true;

                lnomedocente.Text = cbdocente.Text;


                connection.Open();
                string queryc = "SELECT do.nivelacademico, do.numcarga FROM docentes as do Join disciplinas where do.nome=@nomedocente";
                string query = "SELECT COUNT(d.nome) as totalcadeiras, SUM(t.cargahoraria) as totalcarga FROM disciplinas as d join turmas as t where d.docente=@nomedocente";
                MySqlCommand commandc = new MySqlCommand(queryc, connection);
                commandc.Parameters.AddWithValue("@nomedocente", cbdocente.Text);
                commandc.ExecuteNonQuery();

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nomedocente", cbdocente.Text);
                command.ExecuteNonQuery();

                using (MySqlDataReader reader = commandc.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        quantidade = Int16.Parse(reader["numcarga"].ToString());

                        lnivelacademico.Text = reader["nivelacademico"].ToString();
                        lquantmax.Text = reader["numcarga"].ToString();

                    }

                }
                using (MySqlDataReader reader2 = command.ExecuteReader())
                {
                    if (reader2.Read())
                    {
                        int totalCa;
                        if (reader2["totalcarga"].ToString() == "" || reader2["totalcarga"].ToString() == null)
                        {
                            totalCa=0;
                        }
                        else
                        {
                            totalCa = Int16.Parse(reader2["totalcarga"].ToString());
                        }
                        lquantcadeiras.Text = reader2["totalcadeiras"].ToString();
                        quantidaderestante = Int16.Parse(lquantmax.Text) - totalCa;

                        lquantrestante.Text = quantidaderestante.ToString();


                    }
                }
                if (Int16.Parse(lquantrestante.Text) <= 0)
                {
                    Session.Error = "Atigiu Limite de cargas para este docente!";
                    FormError formError = new FormError();
                    formError.ShowDialog();

                }
            }
        }
    }
}
