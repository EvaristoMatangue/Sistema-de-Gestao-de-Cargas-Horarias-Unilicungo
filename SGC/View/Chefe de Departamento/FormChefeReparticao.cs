using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC.View.Chefe_de_Departamento
{
    public partial class FormChefeReparticao : Form
    {
        int i = 1;
        public FormChefeReparticao()
        {
            InitializeComponent();
            luser.Text = $"{Helppers.Session.Sobrenome}";
            UCDashboard dashboard = new UCDashboard();

            painelprincipal.Controls.Clear();
            painelprincipal.Controls.Add(dashboard);

        }

        private void btdisciplina_Click(object sender, EventArgs e)
        {
            btdocente.BackColor = Color.Transparent;
            btdisciplina.BackColor = Color.Silver;
            btdashboard.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;

            UCChefeDiscplina uCDisciplina = new UCChefeDiscplina();

            painelprincipal.Controls.Clear();
            painelprincipal.Controls.Add(uCDisciplina);
        }

        private void btdashboard_Click(object sender, EventArgs e)
        {
            btdocente.BackColor = Color.Transparent;
            btdisciplina.BackColor = Color.Transparent;
            btdashboard.BackColor = Color.Silver;
            button4.BackColor = Color.Transparent;

            UCDashboard dashboard = new UCDashboard();

            painelprincipal.Controls.Clear();
            painelprincipal.Controls.Add(dashboard);
        }

        private void btdocente_Click(object sender, EventArgs e)
        {
            btdocente.BackColor = Color.Silver;

            btdisciplina.BackColor = Color.Transparent;
            btdashboard.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;

            UCChefeDocentes docente = new UCChefeDocentes();

            painelprincipal.Controls.Clear();
            painelprincipal.Controls.Add(docente);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btdocente.BackColor = Color.Transparent;
            btdisciplina.BackColor = Color.Transparent;
            btdashboard.BackColor = Color.Transparent;
            button4.BackColor = Color.Silver;
            
            AlterarSenha alterar = new AlterarSenha();
            alterar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button5_Click(object sender, EventArgs e)
        {
            FormReportar reportar = new FormReportar();
            reportar.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 5)
            {
                timer1.Stop();
                if (BCrypt.Net.BCrypt.Verify($"{Helppers.Session.UserName}" + "1234", $"{Helppers.Session.s}"))
                {
                    SenhaPadrao senhapadrao = new SenhaPadrao();
                    senhapadrao.ShowDialog();

                }
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.FormClosed += (s, args) => this.Close();
            this.Hide();
            login.Show();
        }
    }
}
