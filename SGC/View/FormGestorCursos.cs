using MySql.Data.MySqlClient;
using SGC.View.GestorCurso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC.View
{
    public partial class FormGestorCursos : Form
    {
        string conn = $"{Helppers.conexao.connectionString}";
        int i = 1;
        public FormGestorCursos()
        {
            InitializeComponent();

            Carregarnum();
            luser.Text = $"{Helppers.Session.Sobrenomec}";
            lcurso.Text = $"{Helppers.Session.curso}";

            UCDashboard dashboard = new UCDashboard();

            painelprincipal.Controls.Clear();
            dashboard.Dock = DockStyle.Fill;
            painelprincipal.Controls.Add(dashboard);
            timer1.Start();
        }
        private void Carregarnum()
        {
            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                if (connection != null)
                {
                    connection.Close();
                }
                connection.Open();
                string query = "SELECT COUNT(*) as total FROM mensagens where nomedestinatario = @nome";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nome", $"{Helppers.Session.Nomec}");
                int n = Convert.ToInt32(command.ExecuteScalar());

                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        if (n > 0)
                        {
                            ltotal.Text = reader["total"].ToString();

                        }
                        else
                        {
                            ltotal.Visible = false;
                        }
                    }

                }

            }
        }

        private void btdisciplina_Click(object sender, EventArgs e)
        {
            btdisciplina.BackColor = Color.Silver;
            btdashboard.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;

            UCGCTurmas uCDisciplina = new UCGCTurmas();

            painelprincipal.Controls.Clear();
            uCDisciplina.Dock = DockStyle.Fill;
            painelprincipal.Controls.Add(uCDisciplina);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                button3.Image = Properties.Resources.clone_figure_20px;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                button3.Image = Properties.Resources.maximize_button_20px;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btdashboard_Click(object sender, EventArgs e)
        {
            btdisciplina.BackColor = Color.Transparent;
            btdashboard.BackColor = Color.Silver;
            button4.BackColor = Color.Transparent;

            UCDashboard dashboard = new UCDashboard();

            painelprincipal.Controls.Clear();
            dashboard.Dock = DockStyle.Fill;
            painelprincipal.Controls.Add(dashboard);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            btdisciplina.BackColor = Color.Transparent;
            btdashboard.BackColor = Color.Transparent;
            button4.BackColor = Color.Silver;

            AlterarSenha alterar = new AlterarSenha();
            alterar.ShowDialog();
        }

        private void btdocente_Click(object sender, EventArgs e)
        {
            btdisciplina.BackColor = Color.Transparent;
            btdashboard.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;

            UCDocente docente = new UCDocente();

            painelprincipal.Controls.Clear();
            painelprincipal.Controls.Add(docente);
        }

        private void btimprimir_Click(object sender, EventArgs e)
        {
            UCDashboard uc = new UCDashboard();
            var dt = uc.ObterDadosDoBancoDeDados();
            using (var frm = new FormRelatorio(dt))
            {
                frm.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UCMensagem mensagem = new UCMensagem();
            painelprincipal.Controls.Clear();
            painelprincipal.Controls.Add(mensagem);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 5)
            {
                timer1.Stop();
                if (BCrypt.Net.BCrypt.Verify($"{Helppers.Session.UserName}"+"1234", $"{Helppers.Session.s}"))
                {
                    SenhaPadrao senhapadrao = new SenhaPadrao();
                    senhapadrao.ShowDialog();

                }
            }
        }

        private void btapagar_Click(object sender, EventArgs e)
        {
            Helppers.Session.UserName = "";
            Helppers.Session.Nomec = "";
            Helppers.Session.Emailc = "";
            Helppers.Session.Sobrenomec = "";
            Helppers.Session.curso = "";

            Login login = new Login();
            login.FormClosed += (s, args) => this.Close();
            this.Hide();
            login.Show();
        }

        private void FormGestorCursos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
