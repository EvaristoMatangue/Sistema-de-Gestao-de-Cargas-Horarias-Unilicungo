﻿using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using SGC.View;
using SGC.View.GestorCurso;
using SGC.View.GestorHR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace SGC
{
    public partial class FormAdmin : Form
    {
        int i = 1;
        private UCDashboard ucDashboard;
        MySqlConnection con = new MySqlConnection($"{Helppers.conexao.connectionString}");
        public FormAdmin()
        {
            InitializeComponent();

            luser.Text = $"{Helppers.Session.Sobrenomerh}";
            UCDashboard dashboard = new UCDashboard();

            painelprincipal.Controls.Clear();
            painelprincipal.Controls.Add(dashboard);

            
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

        private void btdisciplina_Click(object sender, EventArgs e)
        {
            btdocente.BackColor = Color.Transparent;
            btdisciplina.BackColor = Color.Silver;
            btdashboard.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            btcurso.BackColor = Color.Transparent;
            btgestorcurso.BackColor = Color.Transparent;
            btgestorrh.BackColor = Color.Transparent;
            btchefedepartamento.BackColor = Color.Transparent;

            UCDisciplina uCDisciplina = new UCDisciplina();

            painelprincipal.Controls.Clear();
            painelprincipal.Controls.Add(uCDisciplina);
        }

        private void painelprincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btgestorrh_Click(object sender, EventArgs e)
        {
            btdocente.BackColor = Color.Transparent;
            btdisciplina.BackColor = Color.Transparent;
            btdashboard.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            btcurso.BackColor = Color.Transparent;
            btgestorcurso.BackColor = Color.Transparent;
            btgestorrh.BackColor = Color.Silver;
            btchefedepartamento.BackColor = Color.Transparent;

            UCGRHCadastro uCGRH = new UCGRHCadastro();

            painelprincipal.Controls.Clear();
            painelprincipal.Controls.Add(uCGRH);
        }

        private void btdocente_Click(object sender, EventArgs e)
        {
            btdocente.BackColor = Color.Silver;
            btdisciplina.BackColor = Color.Transparent;
            btdashboard.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            btcurso.BackColor = Color.Transparent;
            btgestorcurso.BackColor = Color.Transparent;
            btgestorrh.BackColor = Color.Transparent;
            btchefedepartamento.BackColor = Color.Transparent;

            UCDocenteAdmin docente = new UCDocenteAdmin();

            painelprincipal.Controls.Clear();
            painelprincipal.Controls.Add(docente);
        }

        private void btcurso_Click(object sender, EventArgs e)
        {
            btdocente.BackColor = Color.Transparent;
            btdisciplina.BackColor = Color.Transparent;
            btdashboard.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            btcurso.BackColor = Color.Silver;
            btgestorcurso.BackColor = Color.Transparent;
            btgestorrh.BackColor = Color.Transparent;
            btchefedepartamento.BackColor = Color.Transparent;

            UCGCCursos cursos = new UCGCCursos();

            painelprincipal.Controls.Clear();
            painelprincipal.Controls.Add(cursos);
        }

        private void btgestorcurso_Click(object sender, EventArgs e)
        {
            btdocente.BackColor = Color.Transparent;
            btdisciplina.BackColor = Color.Transparent;
            btdashboard.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            btcurso.BackColor = Color.Transparent;
            btgestorcurso.BackColor = Color.Silver;
            btgestorrh.BackColor = Color.Transparent;
            btchefedepartamento.BackColor = Color.Transparent;

            UCGCCadastro cadastro = new UCGCCadastro();
            painelprincipal.Controls.Clear();
            painelprincipal.Controls.Add(cadastro);
        }

        private void btdashboard_Click(object sender, EventArgs e)
        {
            btdocente.BackColor = Color.Transparent;
            btdisciplina.BackColor = Color.Transparent;
            btdashboard.BackColor = Color.Silver;
            button4.BackColor = Color.Transparent;
            btcurso.BackColor = Color.Transparent;
            btgestorcurso.BackColor = Color.Transparent;
            btgestorrh.BackColor = Color.Transparent;
            btchefedepartamento.BackColor = Color.Transparent;

            UCDashboard dashboard = new UCDashboard();

            painelprincipal.Controls.Clear();
            painelprincipal.Controls.Add(dashboard);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btapagar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.FormClosed += (s, args) => this.Close();
            this.Hide();
            login.Show();
        }

        private void btrestaurar_Click(object sender, EventArgs e)
        {
            string path = @"C:\\Users\\EVARISTO\\Documents\backup-SGContratos.sql";
            MySqlCommand cmd = new MySqlCommand();
            MySqlBackup bkp = new MySqlBackup(cmd);

            cmd.Connection = con;
            con.Open();
            bkp.ImportFromFile(path);
            con.Close();

            PopupNotifier popup = new PopupNotifier();
            //popup.TitleText= new Font("Lucida Fax", 11.5F, FontStyle.Bold, );
            popup.BodyColor = Color.White;
            popup.Image = Properties.Resources.ok_48px;
            popup.TitleText = "Sucesso";
            popup.ContentText = "Restauro Feito com sucesso!";
            popup.Popup();
        }

        private void btbackup_Click(object sender, EventArgs e)
        {
            string path = @"C:\\Users\\EVARISTO\\Documents\backup-SGContratos.sql";
            MySqlCommand cmd = new MySqlCommand();
            MySqlBackup bkp = new MySqlBackup(cmd);

            cmd.Connection = con;
            con.Open();
            bkp.ExportToFile(path);
            con.Close();
            PopupNotifier popup = new PopupNotifier();
            popup.BodyColor = Color.White;
            popup.Image = Properties.Resources.ok_48px;
            popup.TitleText = "Sucesso";
            popup.ContentText = "Backup Feito com sucesso!";
            popup.Popup();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btdocente.BackColor = Color.Transparent;
            btdisciplina.BackColor = Color.Transparent;
            btdashboard.BackColor = Color.Transparent;
            button4.BackColor = Color.Silver;
            btcurso.BackColor = Color.Transparent;
            btgestorcurso.BackColor = Color.Transparent;
            btgestorrh.BackColor = Color.Transparent;
            btchefedepartamento.BackColor = Color.Transparent;

            AlterarSenha alterar = new AlterarSenha();
            alterar.ShowDialog();
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

        private void btchefedepartamento_Click(object sender, EventArgs e)
        {
            btdocente.BackColor = Color.Transparent;
            btdisciplina.BackColor = Color.Transparent;
            btdashboard.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            btcurso.BackColor = Color.Transparent;
            btgestorcurso.BackColor = Color.Transparent;
            btgestorrh.BackColor = Color.Transparent;
            btchefedepartamento.BackColor = Color.Silver;

            UCChefedepartamento departamento = new UCChefedepartamento();

            painelprincipal.Controls.Clear();
            painelprincipal.Controls.Add(departamento);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 5)
            {
                timer1.Stop();
                if (BCrypt.Net.BCrypt.Verify("1234", $"{Helppers.Session.s}"))
                {
                    SenhaPadrao senhapadrao = new SenhaPadrao();
                    senhapadrao.ShowDialog();

                }
            }
        }
    }
}
