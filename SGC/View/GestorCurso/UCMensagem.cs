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
using System.Windows.Forms.DataVisualization.Charting;
using Tulpep.NotificationWindow;

namespace SGC.View.GestorCurso
{
    public partial class UCMensagem : UserControl
    {
        string conn = $"{Helppers.conexao.connectionString}";

        public UCMensagem()
        {
            InitializeComponent();
        }

        private void UCMensagem_Load(object sender, EventArgs e)
        {
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
                    string query = "SELECT m.mensagem FROM mensagens as m join gestorescurso as g ON g.nome= m.nomedestinatario WHERE m.nomedestinatario = @nome";
                    string query1 = "SELECT COUNT(*) as total FROM mensagens where nomedestinatario = @nome";
                    MySqlCommand command1 = new MySqlCommand(query1, connection);
                    command1.Parameters.AddWithValue("@nome", $"{Helppers.Session.Nomec}");
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nome", $"{Helppers.Session.Nomec}");

                
                    int n = Convert.ToInt32(command1.ExecuteScalar());

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                          if (n > 0)
                            {
                                while (reader.Read())
                                {
                                    lmensagem.Text += reader["mensagem"].ToString() + Environment.NewLine + Environment.NewLine;
                                }
                            }else{
                                lmensagem.Text="Nenhuma Mensagem disponivel!";
                            }
                    }
                   
                }
        }
        private void btactualizar_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Pretende apagar o registo?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Crie uma nova conexão usando a string de conexão
                using (MySqlConnection connection = new MySqlConnection(conn))
                {
                    if (check == DialogResult.Yes)
                    {
                        // SQL para deletar a linha da tabela
                        string query = "DELETE FROM mensagens WHERE nomedestinatario = @nome";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@nome", $"{Helppers.Session.Nomec}");
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
                            popup.ContentText = "Mensagens Eliminado com sucesso!";
                            popup.Popup();

                            verdados();
                        }
                        else
                        {
                            Session.Error = "Falha ao marcar como concluido . Por favor, tente novamente.";
                            FormError erro = new FormError();
                            erro.ShowDialog();
                        }
                    }
                }
        }
    }
}
