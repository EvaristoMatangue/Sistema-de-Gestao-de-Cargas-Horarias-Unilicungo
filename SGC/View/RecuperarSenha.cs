using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC.View
{
    public partial class RecuperarSenha : Form
    {
        string conn = $"{Helppers.conexao.connectionString}";

        public RecuperarSenha()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsubmeter_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                ExibirErro("Por favor, insira um endereço de e-mail.");
                return;
            }

            try
            {
                using (MySqlConnection connectionMySQL = new MySqlConnection(conn))
                {
                    connectionMySQL.Open();

                    // Verificar se o e-mail existe na tabela de usuários e obter o nome do usuário
                    string queryObterUsuario = "SELECT nomeusuario FROM usuarios WHERE email = @Email";
                    MySqlCommand commandObterUsuario = new MySqlCommand(queryObterUsuario, connectionMySQL);
                    commandObterUsuario.Parameters.AddWithValue("@Email", email);

                    string nomeUsuario = commandObterUsuario.ExecuteScalar()?.ToString();

                    if (string.IsNullOrEmpty(nomeUsuario))
                    {
                        ExibirErro("O e-mail fornecido não está cadastrado no sistema.");
                        return;
                    }

                    // Gerar a nova senha como o nome do usuário + "1234"
                    string novaSenhaPadrao = BCrypt.Net.BCrypt.HashPassword(nomeUsuario + "1234");

                    // Atualizar a senha no banco de dados
                    string queryAtualizarSenha = "UPDATE usuarios SET senha = @Senha WHERE email = @Email";
                    MySqlCommand commandAtualizar = new MySqlCommand(queryAtualizarSenha, connectionMySQL);
                    commandAtualizar.Parameters.AddWithValue("@Senha", novaSenhaPadrao);
                    commandAtualizar.Parameters.AddWithValue("@Email", email);
                    commandAtualizar.ExecuteNonQuery();

                    // Enviar e-mail com a nova senha
                    EnviarEmailNovaSenha(email, nomeUsuario, nomeUsuario + "1234");

                    ExibirSucesso("Uma nova senha foi enviada para o seu e-mail.");
                }

                // Redirecionar para a tela de login
                Login login = new Login();
                login.FormClosed += (s, args) => this.Close();
                this.Hide();
                login.Show();
            }
            catch (Exception ex)
            {
                ExibirErro("Erro ao redefinir a senha: " + ex.Message);
            }
        }
        private void btnSubmeter_Click(object sender, EventArgs e)
        {
            
        }

        private void EnviarEmailNovaSenha(string emailDestino, string nomeUsuario, string novaSenha)
        {
            try
            {
                // Configuração da mensagem de e-mail
                MailMessage mensagem = new MailMessage();
                mensagem.From = new MailAddress("evristojoa99@gmail.com"); // mesmo e-mail da autenticação
                mensagem.To.Add(emailDestino);
                mensagem.Subject = "Recuperação de Senha - SiGCH";

                mensagem.IsBodyHtml = true;
                mensagem.Body = $@"
            <div style='font-family: Arial, sans-serif;'>
                <h2 style='color: #3498db;'>SiGCH - Unilicungo - Beira</h2>
                <h3 style='color: #2c3e50;'>Recuperação da Senha</h3>
                <p>Saudações <strong>{nomeUsuario}</strong>,</p>
                <p>Sua nova senha padrão é: <strong>{novaSenha}</strong></p>
                <p>Por favor, altere esta senha após o login.</p>
                <br />
                <p>Atenciosamente,<br /><strong>SiGCH</strong></p>
            </div>";

                SmtpClient client = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new System.Net.NetworkCredential("evristojoa99@gmail.com", "msof ifqx pfgw xlnw"),
                    EnableSsl = true
                };

                client.Send(mensagem);
            }
            catch (Exception ex)
            {
                ExibirErro("Erro ao enviar o e-mail: " + ex.Message);
            }
        }
        private void ExibirErro(string mensagem)
        {
            Helppers.Session.Error = mensagem;
            FormError erro = new FormError();
            erro.ShowDialog();
        }

        private void ExibirSucesso(string mensagem)
        {
            Helppers.Session.Sucess = mensagem;
            FormSucess sucesso = new FormSucess();
            sucesso.ShowDialog();
        }
        private bool ValidarEmail(string email)
        {
            // Expressão regular para formato de email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (!ValidarEmail(txtemail.Text))
            {
                Helppers.Session.Error = "O endereço de email inserido é inválido. Por favor, insira um email válido.";
                FormError erro = new FormError();
                erro.ShowDialog();

            }
        }

    }
}
