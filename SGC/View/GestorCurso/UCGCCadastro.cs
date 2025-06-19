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
using System.Xml.Linq;
using Tulpep.NotificationWindow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGC.View.GestorCurso
{
    public partial class UCGCCadastro : UserControl
    {
        string conn = $"{Helppers.conexao.connectionString}";

        public UCGCCadastro()
        {
            InitializeComponent();
        }


        private void UCGCCadastro_Load(object sender, EventArgs e)
        {
            cbcurso.Items.Clear();
            txtnome.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(conn))
            {

                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();

                string query = "SELECT nome FROM docentes ORDER BY nome";

                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        txtnome.Items.Add(reader["nome"].ToString());

                    }

                }
                connection.Close();
            }
            
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();
                string query = "SELECT nome FROM cursos ORDER BY nome";

                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        cbcurso.Items.Add(reader["nome"].ToString());

                    }

                }
                connection.Close();
            }
            verdados();
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

                string query = "SELECT * FROM gestorescurso";

                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                connection.Close();

                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["cursoID"].Visible = false;

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
                        string query = "DELETE FROM gestorescurso WHERE ID = @ID";
                        string queryu = "UPDATE usuarios SET tipousuario = 'docente' WHERE nomeusuario = @nomeuser";
                        // Crie um novo comando com a consulta SQL e a conexão
                        MySqlCommand commandu = new MySqlCommand(queryu, connection);
                        MySqlCommand command = new MySqlCommand(query, connection);

                        commandu.Parameters.AddWithValue("@nomeuser", txtusuario.Text);
                        command.Parameters.AddWithValue("@ID", id);

                        if (connection != null)
                        {
                            connection.Close();
                        }
                        connection.Open();
                        // Execute o comando de exclusão
                        int rowsAffected = command.ExecuteNonQuery();
                        int rowsAffectedu = commandu.ExecuteNonQuery();
                        // Feche a conexão
                        connection.Close();

                        if (rowsAffected > 0 && rowsAffectedu > 0)
                        {

                            PopupNotifier popup = new PopupNotifier();
                            //popup.TitleText= new Font("Lucida Fax", 11.5F, FontStyle.Bold, );
                            popup.BodyColor = Color.White;
                            popup.Image = Properties.Resources.ok_48px;
                            popup.TitleText = "Sucesso";
                            popup.ContentText = "Registo Eliminado com sucesso!";
                            popup.Popup();
                            txtemail.Text = "";
                            txtnome.Text = "";
                            txttelefone.Text = "";
                            txtusuario.Text = "";
                            // Após a exclusão, recarregue os dados no DataGridView para refletir as alterações
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
                Session.Error = "Por favor, selecione uma linha para deletar.";
                FormError erro = new FormError();
                erro.ShowDialog();
            }
        }


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                if (e.RowIndex >= 0)
                {
                    btactualizar.Visible = true;
                    btapagar.Visible = true;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    string cursoid = row.Cells["cursoID"].Value.ToString();

                    // Consulta SQL para obter os nomes dos professores a partir dos IDs
                    string query = @"SELECT nome FROM cursos WHERE id IN (@cursoid)";

                    using (MySqlConnection connection = new MySqlConnection(conn))
                    {
                        if (connection != null)
                        {
                            connection.Close();
                        }
                        connection.Open();
                        txtusuario.Text = row.Cells["nomeusuario"].Value.ToString();
                        txttelefone.Text = row.Cells["telefone"].Value.ToString();
                        txtnome.Text = row.Cells["nome"].Value.ToString();
                        txtemail.Text = row.Cells["email"].Value.ToString();


                        // Execute a consulta SQL
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@cursoid", cursoid);
                        // Leitura dos resultados
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbcurso.Text = reader["nome"].ToString();
                            }
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

        private void txtnome_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();

                string query = "SELECT nomeusuario, email, telefone FROM docentes WHERE nome=@nomed";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nomed", txtnome.Text);


                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        txtemail.Text = reader["email"].ToString();
                        txtusuario.Text = reader["nomeusuario"].ToString();
                        txttelefone.Text = reader["telefone"].ToString();
                    }

                }
                connection.Close();
            }
        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            if (txtemail.Text == "" || txtnome.Text == "" || txttelefone.Text == "" || txtusuario.Text == "")
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

                        string queryVerificar = "SELECT COUNT(*) FROM gestorescurso WHERE Nome = @nome OR curso=@curso";
                        MySqlCommand commandVerificar = new MySqlCommand(queryVerificar, connection1);

                        commandVerificar.Parameters.AddWithValue("@nome", txtnome.Text);
                        commandVerificar.Parameters.AddWithValue("@curso", cbcurso.Text);

                        //string Verificar = "SELECT c.nome FROM cursos as c WHERE cordenador = @cordenador";
                        //MySqlCommand cmd = new MySqlCommand(Verificar, connection1);
                        //cmd.Parameters.AddWithValue("@cordenador", txtnome.Text);
                        //cmd.ExecuteNonQuery();
                        //MySqlDataReader ler = cmd.ExecuteReader();
                        int count = Convert.ToInt32(commandVerificar.ExecuteScalar());


                        if (count > 0)
                        {
                            Session.Error = "Este docente já esta associado a um curso ou o curso já tem cordenador ";
                            FormError erro = new FormError();
                            erro.ShowDialog();
                        }
                        else
                        {
                            using (MySqlConnection connection = new MySqlConnection(conn))
                            {
                                string hashedSenha = BCrypt.Net.BCrypt.HashPassword(txtusuario.Text+"1234");
                                // Abra a conexão
                                connection.Open();
                                string querySupervisor = "SELECT id FROM cursos WHERE nome = @supervisor";
                                MySqlCommand commandSupervisor = new MySqlCommand(querySupervisor, connection);
                                commandSupervisor.Parameters.AddWithValue("@supervisor", cbcurso.Text);
                                int idcurso = Convert.ToInt32(commandSupervisor.ExecuteScalar());

                                // SQL para inserir os dados na tabela
                                string query = "INSERT INTO gestorescurso (nome, email, telefone, cursoID, curso, nomeusuario) VALUES (@nome, @email, @telefone, @cursoID, @curso, @nomeusuario)";

                                // Crie um novo comando com a consulta SQL e a conexão
                                MySqlCommand command = new MySqlCommand(query, connection);

                                // Adicione os parâmetros
                                command.Parameters.AddWithValue("@nome", txtnome.Text);
                                command.Parameters.AddWithValue("@email", txtemail.Text);
                                command.Parameters.AddWithValue("@telefone", txttelefone.Text);
                                command.Parameters.AddWithValue("@cursoID", idcurso);
                                command.Parameters.AddWithValue("@curso", cbcurso.Text);
                                command.Parameters.AddWithValue("@nomeusuario", txtusuario.Text);

                                string queryu = "UPDATE usuarios SET tipousuario=@tipousuario WHERE nomeusuario=@nomeusuario";

                                // Crie um novo comando com a consulta SQL e a conexão
                                MySqlCommand commandu = new MySqlCommand(queryu, connection);

                                // Adicione os parâmetros
                                commandu.Parameters.AddWithValue("@nomeusuario", txtusuario.Text);
                                commandu.Parameters.AddWithValue("@tipousuario", "gestorcurso");

                                // Execute o comando de inserção
                                command.ExecuteNonQuery();
                                commandu.ExecuteNonQuery();

                                string queryc = "UPDATE cursos SET cordenador=@cordenador WHERE nome=@nome";

                                // Crie um novo comando com a consulta SQL e a conexão
                                MySqlCommand commandc = new MySqlCommand(queryc, connection);

                                // Adicione os parâmetros
                                commandc.Parameters.AddWithValue("@cordenador", txtnome.Text);
                                commandc.Parameters.AddWithValue("@nome", cbcurso.Text);

                                // Execute o comando de inserção
                                commandc.ExecuteNonQuery();

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
                    Session.Error = ex.Message;
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
                int id = Convert.ToInt32(selectedRow["ID"]);

                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    connection.Open();

                    // Obter o ID do curso anterior
                    string queryCursoAnterior = "SELECT cursoID FROM gestorescurso WHERE ID = @ID";
                    MySqlCommand commandCursoAnterior = new MySqlCommand(queryCursoAnterior, connection);
                    commandCursoAnterior.Parameters.AddWithValue("@ID", id);
                    int idCursoAnterior = Convert.ToInt32(commandCursoAnterior.ExecuteScalar());

                    // Obter o ID do novo curso
                    string queryCurso = "SELECT id FROM cursos WHERE nome = @curso";
                    MySqlCommand commandCurso = new MySqlCommand(queryCurso, connection);
                    commandCurso.Parameters.AddWithValue("@curso", cbcurso.Text);
                    int idCursoNovo = Convert.ToInt32(commandCurso.ExecuteScalar());

                    // Verificar se já existe outro usuário com o mesmo nomeusuario
                    string queryVerificarUsuario = @"
            SELECT COUNT(*) FROM gestorescurso 
            WHERE nomeusuario = @nomeusuario AND ID != @ID";

                    MySqlCommand commandVerificarUsuario = new MySqlCommand(queryVerificarUsuario, connection);
                    commandVerificarUsuario.Parameters.AddWithValue("@nomeusuario", txtusuario.Text);
                    commandVerificarUsuario.Parameters.AddWithValue("@ID", id);

                    int usuarioExistente = Convert.ToInt32(commandVerificarUsuario.ExecuteScalar());

                    if (usuarioExistente > 0)
                    {
                        Session.Error = "O nome de usuário já está sendo usado por outro registro. Escolha um nome diferente.";
                        FormError erro = new FormError();
                        erro.ShowDialog();
                        return;
                    }

                    // Verificar se o novo curso já tem um coordenador
                    string queryVerificarCoordenador = @"
                                                        SELECT COUNT(*) FROM gestorescurso 
                                                        WHERE cursoID = @cursoID AND ID != @ID";

                    MySqlCommand commandVerificar = new MySqlCommand(queryVerificarCoordenador, connection);
                    commandVerificar.Parameters.AddWithValue("@cursoID", idCursoNovo);
                    commandVerificar.Parameters.AddWithValue("@ID", id);

                    int coordenadoresExistentes = Convert.ToInt32(commandVerificar.ExecuteScalar());

                    if (coordenadoresExistentes > 0)
                    {
                        Session.Error = "O curso selecionado já possui um coordenador. Selecione outro curso ou remova o coordenador atual.";
                        FormError erro = new FormError();
                        erro.ShowDialog();

                        return;
                    }

                    // Atualizar o curso antigo para remover o coordenador
                    string queryRemoverCoordenador = "UPDATE cursos SET cordenador = NULL WHERE id = @idCursoAnterior";
                    MySqlCommand commandRemoverCoordenador = new MySqlCommand(queryRemoverCoordenador, connection);
                    commandRemoverCoordenador.Parameters.AddWithValue("@idCursoAnterior", idCursoAnterior);
                    commandRemoverCoordenador.ExecuteNonQuery();

                    // Atualizar o novo curso com o novo coordenador
                    string queryAtualizarNovoCurso = "UPDATE cursos SET cordenador = @cordenador WHERE id = @idCursoNovo";
                    MySqlCommand commandAtualizarNovoCurso = new MySqlCommand(queryAtualizarNovoCurso, connection);
                    commandAtualizarNovoCurso.Parameters.AddWithValue("@cordenador", txtnome.Text);
                    commandAtualizarNovoCurso.Parameters.AddWithValue("@idCursoNovo", idCursoNovo);
                    commandAtualizarNovoCurso.ExecuteNonQuery();

                    // Atualizar os dados do gestor
                    string queryAtualizarGestor = @"
                                                    UPDATE gestorescurso 
                                                    SET nome = @nome, 
                                                        email = @email, 
                                                        telefone = @telefone, 
                                                        cursoID = @cursoID,
                                                        curso = @curso,
                                                        nomeusuario = @nomeusuario 
                                                    WHERE ID = @ID";

                    MySqlCommand commandAtualizarGestor = new MySqlCommand(queryAtualizarGestor, connection);
                    commandAtualizarGestor.Parameters.AddWithValue("@nome", txtnome.Text);
                    commandAtualizarGestor.Parameters.AddWithValue("@email", txtemail.Text);
                    commandAtualizarGestor.Parameters.AddWithValue("@telefone", txttelefone.Text);
                    commandAtualizarGestor.Parameters.AddWithValue("@cursoID", idCursoNovo);
                    commandAtualizarGestor.Parameters.AddWithValue("@curso", cbcurso.Text);
                    commandAtualizarGestor.Parameters.AddWithValue("@nomeusuario", txtusuario.Text);
                    commandAtualizarGestor.Parameters.AddWithValue("@ID", id);

                    int rowsAffectedGestor = commandAtualizarGestor.ExecuteNonQuery();

                    connection.Close();

                    if (rowsAffectedGestor > 0)
                    {
                        PopupNotifier popup = new PopupNotifier
                        {
                            BodyColor = Color.White,
                            Image = Properties.Resources.ok_48px,
                            TitleText = "Sucesso",
                            ContentText = "Registro atualizado com sucesso!"
                        };
                        popup.Popup();

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

        private void btapagar_Click_1(object sender, EventArgs e)
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
                        string query = "DELETE FROM gestorescurso WHERE ID = @ID";
                        string queryu = "UPDATE usuarios SET tipousuario = 'docente' WHERE nomeusuario = @nomeuser";
                        // Crie um novo comando com a consulta SQL e a conexão
                        MySqlCommand commandu = new MySqlCommand(queryu, connection);
                        MySqlCommand command = new MySqlCommand(query, connection);

                        commandu.Parameters.AddWithValue("@nomeuser", txtusuario.Text);
                        command.Parameters.AddWithValue("@ID", id);

                        if (connection != null)
                        {
                            connection.Close();
                        }
                        connection.Open();
                        // Execute o comando de exclusão
                        int rowsAffected = command.ExecuteNonQuery();
                        int rowsAffectedu = commandu.ExecuteNonQuery();
                        // Feche a conexão
                        connection.Close();

                        if (rowsAffected > 0 && rowsAffectedu > 0)
                        {

                            PopupNotifier popup = new PopupNotifier();
                            //popup.TitleText= new Font("Lucida Fax", 11.5F, FontStyle.Bold, );
                            popup.BodyColor = Color.White;
                            popup.Image = Properties.Resources.ok_48px;
                            popup.TitleText = "Sucesso";
                            popup.ContentText = "Registo Eliminado com sucesso!";
                            popup.Popup();
                            txtemail.Text = "";
                            txtnome.Text = "";
                            txttelefone.Text = "";
                            txtusuario.Text = "";
                            // Após a exclusão, recarregue os dados no DataGridView para refletir as alterações
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
                Session.Error = "Por favor, selecione uma linha para deletar.";
                FormError erro = new FormError();
                erro.ShowDialog();
            }
        }
    }
}
