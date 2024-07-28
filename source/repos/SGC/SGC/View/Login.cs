using MySql.Data.MySqlClient;
using SGC.Helppers;
using SGC.View.Chefe_de_Departamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SGC.View
{
    public partial class Login : Form
    {
        string connectionString = "Server=localhost;Database=gestao_contratos;User=root;Password=;";

        public Login()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            
            
        }

        private bool ValidarUsuario(string username, string password, out string userType)
        {
            userType = string.Empty;
            string connectionString = "Server=localhost;Database=gestao_contratos;User=root;Password=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                SELECT 'tipousuario' AS UserType FROM usuarios WHERE NomeUsuario = @username AND senha = @password
                ";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    userType = result.ToString();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void tedio()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string nomec = "SELECT g.* FROM gestorescurso AS g JOIN usuarios AS u ON g.nomeusuario = @u WHERE u.tipousuario = 'gestorcurso'";
               // string nome = "SELECT * FROM usuarios  WHERE tipousuario = 'chefedepartamento'";
                string nomerh = "SELECT d.nome AS nome, d.email AS email FROM gestoresrh AS d JOIN usuarios AS u ON d.nomeusuario = @u WHERE u.tipousuario = 'gestorrh'";
                if(connection != null)
                {
                    connection.Clone();
                }
                connection.Open();

                // Executar a primeira consulta
                using (MySqlCommand commandc = new MySqlCommand(nomec, connection))
                {
                    commandc.Parameters.AddWithValue("@u", txtuser.Text);

                    using (MySqlDataReader readerc = commandc.ExecuteReader())
                    {
                        if (readerc.Read())
                        { 
                            Session.Nomec = readerc["nome"].ToString();
                            Session.Emailc = readerc["email"].ToString();
                            Session.curso = readerc["curso"].ToString();

                            return;
                        }
                    }
                }
                //using (MySqlCommand command = new MySqlCommand(nome, connection))
                //{
                //    command.Parameters.AddWithValue("@u", txtuser.Text);

                //    using (MySqlDataReader readerc = command.ExecuteReader())
                //    {
                //        if (readerc.Read())
                //        {
                //            Session.Nome = readerc["nome"].ToString();
                //            return;
                //        }
                //    }
                //}
                using (MySqlCommand command = new MySqlCommand(nomerh, connection))
                {
                    command.Parameters.AddWithValue("@u", txtuser.Text);

                    using (MySqlDataReader readerc = command.ExecuteReader())
                    {
                        if (readerc.Read())
                        {
                            Session.Nomerh = readerc["nome"].ToString();
                            Session.Emailrh = readerc["email"].ToString();
                            return;
                        }
                    }
                }
            }
        }
        private void btcadastrar_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtsenha.Text;
            // Obter a data de hoje
           

            tedio();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                    

                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();

                string query = @"
                                SELECT nomeusuario, senha, tipousuario FROM usuarios WHERE nomeusuario = @username
                                ";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", txtuser.Text);

                command.ExecuteNonQuery();

                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string storedHash = reader["senha"].ToString();
                    string userType = reader["tipousuario"].ToString();

                    if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                    {
                        Session.UserName = txtuser.Text;

                        if (reader["tipousuario"].ToString() == "gestorrh")
                        {
                            FormAdmin admin = new FormAdmin();
                            admin.FormClosed += (s, args) => this.Close();
                            this.Hide();
                            admin.Show();

                        }
                        else if (reader["tipousuario"].ToString() == "docente")
                        {
                            FormDocente docente = new FormDocente();
                            docente.FormClosed += (s, args) => this.Close();
                            this.Hide();
                            docente.Show();

                        }
                        else if (reader["tipousuario"].ToString() == "gestorcurso")
                        {
                            FormGestorCuros gestorcurso = new FormGestorCuros();
                            gestorcurso.FormClosed += (s, args) => this.Close();
                            this.Hide();
                            gestorcurso.Show();
                        }
                        else if (reader["tipousuario"].ToString() == "chefedepartamento")
                        {
                            FormChefeReparticao chefedep = new FormChefeReparticao();
                            chefedep.FormClosed += (s, args) => this.Close();
                            this.Hide();
                            chefedep.Show();

                        }
                        else
                        {
                            MessageBox.Show("Usuario Nao Autorizado!");
                        }
                    }
                    else
                    {
                        Session.Error = "Usuario ou senha Invalido!";
                        FormError erro = new FormError();
                        erro.ShowDialog();
                    }

                }
                else
                {
                    Session.Error = "Usuario ou senha Invalido!";
                    FormError erro = new FormError();
                    erro.ShowDialog();
                }

            }
            


        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtsenha.UseSystemPasswordChar = true;
        }

        private void btveresconder_Click(object sender, EventArgs e)
        {
            if (txtsenha.UseSystemPasswordChar)
            {
                txtsenha.UseSystemPasswordChar = false;
                btveresconder.Image = Properties.Resources.hide_20px;
            }
            else
            {
                txtsenha.UseSystemPasswordChar = true;
                btveresconder.Image = Properties.Resources.eye_20px;
            }
        }
    }
}
