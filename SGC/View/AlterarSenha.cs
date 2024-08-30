using MySql.Data.MySqlClient;
using System;
using SGC.Helppers;
using BCrypt.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using Microsoft.ReportingServices.Diagnostics.Internal;

namespace SGC.View
{
    public partial class AlterarSenha : Form
    {
        string conn = $"{Helppers.conexao.connectionString}";

        public AlterarSenha()
        {
            InitializeComponent();
        }

        private void AlterarSenha_Load(object sender, EventArgs e)
        {
            txtsenhaactual.UseSystemPasswordChar = true;
            txtconfirmar.UseSystemPasswordChar = true;
            txtnovasenha.UseSystemPasswordChar = true;
            string nomerh = $"{Helppers.Session.Nomerh}";
            string nomec = $"{Helppers.Session.Nomec}";
            string nome = $"{Helppers.Session.Nome}";
            if (nomec != "" && nome == "" && nomerh == "")
            {
                txtnomeusuario.Text = $"{Helppers.Session.Nomec}";
                txtemail.Text = $"{Helppers.Session.Emailc}";

            }
            else if(nomerh != "" && nomec == "" && nome == "")
            {
                txtnomeusuario.Text = $"{Helppers.Session.Nomerh}";
                txtemail.Text = $"{Helppers.Session.Emailrh}";
            }
            else if (nome != "" && nomerh=="" && nomec=="")
            {
                txtnomeusuario.Text = $"{Helppers.Session.Nome}";
                txtemail.Text = $"{Helppers.Session.Email}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsubmenter_Click(object sender, EventArgs e)
        {
            string senha = "";
            using (MySqlConnection con = new MySqlConnection(conn))
            {
                if (con != null)
                {
                    con.Close();
                }
                con.Open();
                string querys = "SELECT senha FROM usuarios WHERE nomeusuario=@user";

                // Crie um novo comando com a consulta SQL e a conexão
                MySqlCommand commands = new MySqlCommand(querys, con);

                // Adicione os parâmetros
                commands.Parameters.AddWithValue("@user", $"{Helppers.Session.UserName}");

                MySqlDataReader reader = commands.ExecuteReader();

                if (reader.Read())
                {
                    string storedHash = reader["senha"].ToString();

                    if (BCrypt.Net.BCrypt.Verify(txtsenhaactual.Text, storedHash))
                    {
                        if (txtconfirmar.Text == "" || txtnovasenha.Text == "" || txtsenhaactual.Text == "")
                        {
                            txtsenhaactual.ForeColor = Color.Black;
                            txtnovasenha.ForeColor = Color.Black;
                            txtconfirmar.ForeColor = Color.Black;
                            txterror.Visible = true;
                            Session.Error = "É obrigatorio preencher todos os campos!";
                            txterror.Text = $"{Helppers.Session.Error}";
                        }
                        else if (txtnovasenha.Text != txtconfirmar.Text)
                        {
                            txtsenhaactual.ForeColor = Color.Black;
                            txtnovasenha.ForeColor = Color.Red;
                            txtconfirmar.ForeColor = Color.Red;
                            txterror.Visible = true;
                            Session.Error = "Deve ser a mesma senha ao confirmar!";
                            txterror.Text = $"{Helppers.Session.Error}";
                        }
                        else if (txtnovasenha.Text == txtconfirmar.Text)
                        {
                            con.Close();
                            txterror.Visible = false;
                            txtsenhaactual.ForeColor = Color.Black;
                            txtnovasenha.ForeColor = Color.Black;
                            txtconfirmar.ForeColor = Color.Black;
                            using (MySqlConnection connection = new MySqlConnection(conn))
                            {
                                connection.Open();

                                string query = "UPDATE usuarios SET senha= @senha WHERE nomeusuario = @nomeusuario";

                                // Crie um novo comando com a consulta SQL e a conexão
                                MySqlCommand command = new MySqlCommand(query, connection);

                                // Gere o hash da nova senha
                                string hashedSenha = BCrypt.Net.BCrypt.HashPassword(txtnovasenha.Text);

                                // Adicione os parâmetros
                                command.Parameters.AddWithValue("@senha", hashedSenha);
                                command.Parameters.AddWithValue("@nomeusuario", Helppers.Session.UserName);

                                int rowsAffected = command.ExecuteNonQuery();

                                // Feche a conexão
                                connection.Close();

                                if (rowsAffected > 0)
                                {
                                    PopupNotifier popup = new PopupNotifier();
                                    popup.BodyColor = Color.White;
                                    popup.Image = Properties.Resources.ok_48px;
                                    popup.TitleText = "Sucesso";
                                    popup.ContentText = "Registo Atualizado com sucesso!";
                                    popup.Popup();
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao atualizar os dados: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            this.Close();
                        }
                    }
                    else
                    {
                        txtnovasenha.ForeColor = Color.Black;
                        txtconfirmar.ForeColor = Color.Black;
                        txtsenhaactual.ForeColor = Color.Red;
                        txterror.Visible = true;
                        Session.Error = "Senha Actual Invalida";
                        txterror.Text = $"{Helppers.Session.Error}";
                    }
                }
                else
                {
                    txterror.Visible = true;
                    Session.Error = "Usuário não encontrado.";
                    txterror.Text = $"{Helppers.Session.Error}";
                }
            }


        }

        private void btveresconder_Click(object sender, EventArgs e)
        {
                if (txtsenhaactual.UseSystemPasswordChar && txtconfirmar.UseSystemPasswordChar && txtnovasenha.UseSystemPasswordChar)
            {
                txtsenhaactual.UseSystemPasswordChar = false;
                txtconfirmar.UseSystemPasswordChar = false;
                txtnovasenha.UseSystemPasswordChar = false;
                btveresconder.Image = Properties.Resources.hide_20px;
            }
            else
            {
                txtsenhaactual.UseSystemPasswordChar = true;
                txtconfirmar.UseSystemPasswordChar = true;
                txtnovasenha.UseSystemPasswordChar = true; 
                btveresconder.Image = Properties.Resources.eye_20px;
            }
        }
    }
}
