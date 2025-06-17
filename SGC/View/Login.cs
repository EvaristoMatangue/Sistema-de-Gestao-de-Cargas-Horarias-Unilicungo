using MySql.Data.MySqlClient;
using SGC.Helppers;
using SGC.View.Chefe_de_Departamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SGC.View
{
    public partial class Login : Form
    {
        public static string path = $"{Helppers.conexao.path}";
        string connectionString = $"{Helppers.conexao.connectionString}";

        public Login()
        {
            InitializeComponent();
            //criarbanco();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            
            
        }
        public static void criarbanco()
        {
            try
            {
                if (!File.Exists(path))
                {
                    // Cria o arquivo do banco de dados SQLite
                    SQLiteConnection.CreateFile(path);
                }
                using (var connection = new SQLiteConnection($"Data Source={path};Version=3;"))
                {
                    connection.Open();

                    // Cria as tabelas caso não existam
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = @"
                                    CREATE TABLE IF NOT EXISTS usuarios (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        nomeusuario TEXT NOT NULL,
                                        Senha TEXT NOT NULL,
                                        TipoUsuario TEXT NOT NULL CHECK(TipoUsuario IN ('Docente', 'GestorCurso', 'GestorHR', 'ChefeDepartamento')),
                                        DataCriacao DATETIME DEFAULT CURRENT_TIMESTAMP
                                    );

                                    CREATE TABLE IF NOT EXISTS docentes (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Nome TEXT NOT NULL,
                                        Nomeusuario TEXT NOT NULL,
                                        Email TEXT NOT NULL UNIQUE,
                                        Curso TEXT NOT NULL,
                                        Telefone TEXT NOT NUL,
                                        observacao TEXT NOT NULL
                                    );

                                    CREATE TABLE IF NOT EXISTS Disciplinas (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Nome TEXT NOT NULL,
                                        CursoID INTEGER,
                                        Curso TEXT NOT NULL,
                                        CargaHoraria TEXT NOT NULL,
                                        docente TEXT NOT NULL,
                                        DocenteID TEXT NOT NULL,
                                        Nivel TEXT NOT NULL,
                                        Semestre TEXT NOT NULL,
                                        FOREIGN KEY(DocenteID) REFERENCES docentes(Id),
                                        FOREIGN KEY(CursoID) REFERENCES cursos(Id)
                                    );

                                    CREATE TABLE IF NOT EXISTS cursos (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Nome TEXT NOT NULL,
                                        Cordenador TEXT NOT NULL UNIQUE,
                                        CordenadorID INTEGER,
                                        Nivel TEXT NOT NULL,
                                        Periodo TEXT NOT NULL,
                                        FOREIGN KEY(CordenadorID) REFERENCES gestorescurso(Id)
                                    );

                                    CREATE TABLE IF NOT EXISTS gestorescurso (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Nome TEXT NOT NULL,
                                        Email TEXT NOT NULL,
                                        nomeusuario TEXT NOT NULL UNIQUE,
                                        CursoId INTEGER NOT NULL,
                                        curso TEXT NOT NULL,
                                        telefone TEXT NOT NULL,
                                        FOREIGN KEY(CursoId) REFERENCES cursos(Id)
                                    );

                                    CREATE TABLE IF NOT EXISTS gestoresrh (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Nome TEXT NOT NULL,
                                        Nomeusuario TEXT NOT NULL,
                                        Senha TEXT NOT NULL,
                                        Email TEXT NOT NULL UNIQUE,
                                        Telefone TEXT NOT NULL
                                    );

                                    CREATE TABLE IF NOT EXISTS chefedepartamento (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Nome TEXT NOT NULL,
                                        Email TEXT NOT NULL UNIQUE,
                                        nomeusuario TEXT NOT NULL,
                                        Telefone TEXT NOT NULL
                                    );

                                    CREATE TABLE IF NOT EXISTS mensagens (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        mensagem TEXT NOT NULL,
                                        nomedestinatario TEXT NOT NULL,
                                        nomeemissor TEXT NOT NULL,
                                        tipoproblema TEXT NOT NULL,
                                        Dataemissao DATETIME DEFAULT CURRENT_TIMESTAMP
                                    );

                                    CREATE TABLE IF NOT EXISTS sincronizacao (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Entidade TEXT NOT NULL,
                                        Operacao TEXT NOT NULL CHECK(Operacao IN ('INSERT', 'UPDATE', 'DELETE')),
                                        DataHora DATETIME DEFAULT CURRENT_TIMESTAMP,
                                        Status TEXT NOT NULL CHECK(Status IN ('PENDENTE', 'SINCRONIZADO'))
                                    );

                                    ";

                        cmd.ExecuteNonQuery(); // Executa o comando para criar as tabelas
                    }
                }
            }
            catch
            {
                throw;
            }

        }
        private bool ValidarUsuario(string username, string password, out string userType)
        {
            userType = string.Empty;

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
                string nome = "SELECT c.nome as nomech, c.email as emailch FROM chefedepartamento as c join usuarios as u on c.nomeusuario = @u WHERE u.tipousuario = 'chefedepartamento'";
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
                            // Supondo que 'reader["nome"]' contenha o nome completo da pessoa
                            string nomeCompleto = readerc["nome"].ToString();

                            // Divide o nome completo em partes, separando por espaços
                            string[] partesNome = nomeCompleto.Split(' ');

                            // O sobrenome geralmente é a última parte do array
                            string sobrenome = partesNome[partesNome.Length - 1];

                            // Armazena o sobrenome na sessão
                            Session.Sobrenomec = sobrenome;

                            Session.Nomec = readerc["nome"].ToString();
                            Session.Emailc = readerc["email"].ToString();
                            Session.curso = readerc["curso"].ToString();

                            return;
                        }
                    }
                }
                using (MySqlCommand command = new MySqlCommand(nome, connection))
                {
                    command.Parameters.AddWithValue("@u", txtuser.Text);

                    using (MySqlDataReader readerc = command.ExecuteReader())
                    {
                        if (readerc.Read())
                        {
                            // Supondo que 'reader["nome"]' contenha o nome completo da pessoa
                            string nomeCompleto = readerc["nomech"].ToString();

                            // Divide o nome completo em partes, separando por espaços
                            string[] partesNome = nomeCompleto.Split(' ');

                            // O sobrenome geralmente é a última parte do array
                            string sobrenome = partesNome[partesNome.Length - 1];

                            // Armazena o sobrenome na sessão
                            Session.Sobrenome = sobrenome;
                            Session.Nome = readerc["nomech"].ToString();
                            Session.Email = readerc["emailch"].ToString();
                            return;
                        }
                    }
                }
                using (MySqlCommand command = new MySqlCommand(nomerh, connection))
                {
                    command.Parameters.AddWithValue("@u", txtuser.Text);

                    using (MySqlDataReader readerc = command.ExecuteReader())
                    {
                        if (readerc.Read())
                        {
                            // Supondo que 'reader["nome"]' contenha o nome completo da pessoa
                            string nomeCompleto = readerc["nome"].ToString();

                            // Divide o nome completo em partes, separando por espaços
                            string[] partesNome = nomeCompleto.Split(' ');

                            // O sobrenome geralmente é a última parte do array
                            string sobrenome = partesNome[partesNome.Length - 1];

                            // Armazena o sobrenome na sessão
                            Session.Sobrenomerh = sobrenome;
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

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtsenha.Text;

            tedio();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {


                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();

                string query = @"
                                SELECT u.nomeusuario, u.senha, u.tipousuario, c.nome as curso FROM usuarios as u Join cursos as c WHERE u.nomeusuario = @username
                                ";
                string queryrh = @"
                                SELECT u.nomeusuario, u.senha, u.tipousuario FROM usuarios as u WHERE u.nomeusuario = @username
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
                        Session.s = storedHash;
                        Session.curso = reader["curso"].ToString();
                        if (reader["tipousuario"].ToString() == "gestorrh")
                        {
                            FormAdmin admin = new FormAdmin();
                            admin.FormClosed += (s, args) => this.Close();
                            this.Hide();
                            admin.Show();

                        }
                        if (reader["tipousuario"].ToString() == "docente")
                        {
                            FormDocente docente = new FormDocente();
                            docente.FormClosed += (s, args) => this.Close();
                            this.Hide();
                            docente.Show();

                        }
                        else if (reader["tipousuario"].ToString() == "gestorcurso")
                        {
                            FormGestorCursos gestorcurso = new FormGestorCursos();
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
                        
                    }
                    else
                    {
                        Session.Error = "Usuario ou senha Invalido!";
                        FormError erro = new FormError();
                        erro.ShowDialog();
                    }

                } else if(!reader.Read())
                {
                    reader.Close();  // IMPORTANTE: fechar antes de novo reader
                    MySqlCommand commandrh = new MySqlCommand(queryrh, connection);
                    commandrh.Parameters.AddWithValue("@username", txtuser.Text);

                    MySqlDataReader readerrh = commandrh.ExecuteReader();

                    if (readerrh.Read())
                    {
                        string storedHash = readerrh["senha"].ToString();
                        string userType = readerrh["tipousuario"].ToString();

                        if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                        {
                            Session.UserName = txtuser.Text;
                            Session.s = storedHash;
                            if (readerrh["tipousuario"].ToString() == "gestorrh")
                            {
                                FormAdmin admin = new FormAdmin();
                                admin.FormClosed += (s, args) => this.Close();
                                this.Hide();
                                admin.Show();

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
                else
                {
                    Session.Error = "Usuario ou senha Invalido!";
                    FormError erro = new FormError();
                    erro.ShowDialog();
                }

            }
        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            RecuperarSenha recuperar = new RecuperarSenha();
            recuperar.FormClosed += (s, args) => this.Close();
            this.Hide();
            recuperar.ShowDialog();
        }

        private void txtsenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btcadastrar.PerformClick(); // Simula o clique no botão Entrar
            }
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
