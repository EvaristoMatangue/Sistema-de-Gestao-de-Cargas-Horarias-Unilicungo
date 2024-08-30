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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btcadastrar_Click(object sender, EventArgs e)
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
                            string hashedSenha = BCrypt.Net.BCrypt.HashPassword("1234");
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
                PopupNotifier popup = new PopupNotifier();
                //popup.TitleText= new Font("Lucida Fax", 11.5F, FontStyle.Bold, );
                popup.BodyColor = Color.White;
                popup.Image = Properties.Resources.exit;
                popup.TitleText = "Alerta";
                popup.ContentText = ex.Message;
                popup.Popup();

            }
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

        private void btactualizar_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = dataGridView1.CurrentRow.DataBoundItem as DataRowView;

            if (selectedRow != null)
            {
                int id = Convert.ToInt32(selectedRow["ID"]);

                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    connection.Open();

                    // Verifica se o curso já tem um coordenador
                    string queryVerificarCoordenador = @"
                        SELECT COUNT(*)
                        FROM gestorescurso
                        WHERE cursoID = (SELECT id FROM cursos WHERE nome = @curso)
                        AND ID != @ID";  // Exclui o gestor atual da verificação

                    MySqlCommand commandVerificar = new MySqlCommand(queryVerificarCoordenador, connection);
                    commandVerificar.Parameters.AddWithValue("@curso", cbcurso.Text);
                    commandVerificar.Parameters.AddWithValue("@ID", id);

                    int coordenadoresExistentes = Convert.ToInt32(commandVerificar.ExecuteScalar());

                    if (coordenadoresExistentes > 0)
                    {
                        Session.Error = "O curso selecionado já possui um coordenador. Por favor, selecione outro \ncurso ou remova o coordenador atual.";
                        FormError erro = new FormError();
                        erro.ShowDialog();
                       
                        return;
                    }

                    // Continua a atualização se não houver coordenador para o curso
                    string queryCurso = "SELECT id FROM cursos WHERE nome = @curso";
                    MySqlCommand commandCurso = new MySqlCommand(queryCurso, connection);
                    commandCurso.Parameters.AddWithValue("@curso", cbcurso.Text);
                    int idcurso = Convert.ToInt32(commandCurso.ExecuteScalar());

                    string queryAtualizarGestor = @"
                        UPDATE gestorescurso 
                        SET nome = @nome, 
                            email = @email, 
                            telefone = @telefone, 
                            cursoID = @cursoID, 
                            nomeusuario = @nomeusuario 
                        WHERE ID = @ID";


                    MySqlCommand commandAtualizarGestor = new MySqlCommand(queryAtualizarGestor, connection);

                    // Parâmetros para atualização
                    commandAtualizarGestor.Parameters.AddWithValue("@nome", txtnome.Text);
                    commandAtualizarGestor.Parameters.AddWithValue("@email", txtemail.Text);
                    commandAtualizarGestor.Parameters.AddWithValue("@telefone", txttelefone.Text);
                    commandAtualizarGestor.Parameters.AddWithValue("@cursoID", idcurso);
                    commandAtualizarGestor.Parameters.AddWithValue("@nomeusuario", txtusuario.Text);
                    commandAtualizarGestor.Parameters.AddWithValue("@ID", id);

                    // Executa as atualizações
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
                        MessageBox.Show("Falha ao atualizar os dados. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha para atualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            popup.Image = Properties.Resources.exit;
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
                            MessageBox.Show("Falha ao deletar a linha. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }



                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha para deletar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                if (e.RowIndex >= 0)
                {
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

        private void txtnome_SelectedIndexChanged(object sender, EventArgs e)
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

        private void dataGridView1_AutoSizeColumnModeChanged(object sender, DataGridViewAutoSizeColumnModeEventArgs e)
        {

        }
    }
}
