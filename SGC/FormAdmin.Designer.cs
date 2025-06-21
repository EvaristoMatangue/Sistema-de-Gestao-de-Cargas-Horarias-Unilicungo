namespace SGC
{
    partial class FormAdmin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.luser = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btassociar = new System.Windows.Forms.Button();
            this.btchefedepartamento = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btgestorrh = new System.Windows.Forms.Button();
            this.btdisciplina = new System.Windows.Forms.Button();
            this.btdocente = new System.Windows.Forms.Button();
            this.btcurso = new System.Windows.Forms.Button();
            this.btgestorcurso = new System.Windows.Forms.Button();
            this.btdashboard = new System.Windows.Forms.Button();
            this.btsair = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btimprimir = new System.Windows.Forms.Button();
            this.btbackup = new System.Windows.Forms.Button();
            this.btrestaurar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.painelprincipal = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.luser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 93);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.label4.Location = new System.Drawing.Point(103, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 46);
            this.label4.TabIndex = 10;
            this.label4.Text = "UL";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.panel5.Location = new System.Drawing.Point(98, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 50);
            this.panel5.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SGC.Properties.Resources.ULLogoSb;
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // luser
            // 
            this.luser.AutoSize = true;
            this.luser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.luser.Location = new System.Drawing.Point(1, 70);
            this.luser.Name = "luser";
            this.luser.Size = new System.Drawing.Size(59, 20);
            this.luser.TabIndex = 9;
            this.luser.Text = "Admin";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btassociar);
            this.panel4.Controls.Add(this.btchefedepartamento);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.btgestorrh);
            this.panel4.Controls.Add(this.btdisciplina);
            this.panel4.Controls.Add(this.btdocente);
            this.panel4.Controls.Add(this.btcurso);
            this.panel4.Controls.Add(this.btgestorcurso);
            this.panel4.Controls.Add(this.btdashboard);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 417);
            this.panel4.TabIndex = 6;
            // 
            // btassociar
            // 
            this.btassociar.FlatAppearance.BorderSize = 0;
            this.btassociar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btassociar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btassociar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btassociar.Location = new System.Drawing.Point(5, 179);
            this.btassociar.Name = "btassociar";
            this.btassociar.Size = new System.Drawing.Size(194, 38);
            this.btassociar.TabIndex = 12;
            this.btassociar.Text = "  Associar Docentes";
            this.btassociar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btassociar.UseVisualStyleBackColor = true;
            this.btassociar.Click += new System.EventHandler(this.btassociar_Click);
            // 
            // btchefedepartamento
            // 
            this.btchefedepartamento.FlatAppearance.BorderSize = 0;
            this.btchefedepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btchefedepartamento.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btchefedepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btchefedepartamento.Location = new System.Drawing.Point(5, 311);
            this.btchefedepartamento.Name = "btchefedepartamento";
            this.btchefedepartamento.Size = new System.Drawing.Size(194, 38);
            this.btchefedepartamento.TabIndex = 11;
            this.btchefedepartamento.Text = "  C. Departamento";
            this.btchefedepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btchefedepartamento.UseVisualStyleBackColor = true;
            this.btchefedepartamento.Click += new System.EventHandler(this.btchefedepartamento_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Location = new System.Drawing.Point(5, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 38);
            this.button4.TabIndex = 10;
            this.button4.Text = "  Alterar Senha";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btgestorrh
            // 
            this.btgestorrh.FlatAppearance.BorderSize = 0;
            this.btgestorrh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btgestorrh.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgestorrh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btgestorrh.Location = new System.Drawing.Point(5, 267);
            this.btgestorrh.Name = "btgestorrh";
            this.btgestorrh.Size = new System.Drawing.Size(194, 38);
            this.btgestorrh.TabIndex = 9;
            this.btgestorrh.Text = "  Gestor de RH";
            this.btgestorrh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btgestorrh.UseVisualStyleBackColor = true;
            this.btgestorrh.Click += new System.EventHandler(this.btgestorrh_Click);
            // 
            // btdisciplina
            // 
            this.btdisciplina.FlatAppearance.BorderSize = 0;
            this.btdisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdisciplina.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdisciplina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btdisciplina.Location = new System.Drawing.Point(5, 47);
            this.btdisciplina.Name = "btdisciplina";
            this.btdisciplina.Size = new System.Drawing.Size(194, 38);
            this.btdisciplina.TabIndex = 8;
            this.btdisciplina.Text = "  Disciplinas";
            this.btdisciplina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdisciplina.UseVisualStyleBackColor = true;
            this.btdisciplina.Click += new System.EventHandler(this.btdisciplina_Click);
            // 
            // btdocente
            // 
            this.btdocente.FlatAppearance.BorderSize = 0;
            this.btdocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdocente.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdocente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btdocente.Location = new System.Drawing.Point(5, 135);
            this.btdocente.Name = "btdocente";
            this.btdocente.Size = new System.Drawing.Size(194, 38);
            this.btdocente.TabIndex = 7;
            this.btdocente.Text = "  Docentes";
            this.btdocente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdocente.UseVisualStyleBackColor = true;
            this.btdocente.Click += new System.EventHandler(this.btdocente_Click);
            // 
            // btcurso
            // 
            this.btcurso.FlatAppearance.BorderSize = 0;
            this.btcurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcurso.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btcurso.Location = new System.Drawing.Point(5, 91);
            this.btcurso.Name = "btcurso";
            this.btcurso.Size = new System.Drawing.Size(194, 38);
            this.btcurso.TabIndex = 6;
            this.btcurso.Text = "  Cursos";
            this.btcurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcurso.UseVisualStyleBackColor = true;
            this.btcurso.Click += new System.EventHandler(this.btcurso_Click);
            // 
            // btgestorcurso
            // 
            this.btgestorcurso.FlatAppearance.BorderSize = 0;
            this.btgestorcurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btgestorcurso.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgestorcurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btgestorcurso.Location = new System.Drawing.Point(5, 223);
            this.btgestorcurso.Name = "btgestorcurso";
            this.btgestorcurso.Size = new System.Drawing.Size(194, 38);
            this.btgestorcurso.TabIndex = 5;
            this.btgestorcurso.Text = "  Gestor do Curso";
            this.btgestorcurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btgestorcurso.UseVisualStyleBackColor = true;
            this.btgestorcurso.Click += new System.EventHandler(this.btgestorcurso_Click);
            // 
            // btdashboard
            // 
            this.btdashboard.BackColor = System.Drawing.Color.Silver;
            this.btdashboard.FlatAppearance.BorderSize = 0;
            this.btdashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btdashboard.Location = new System.Drawing.Point(4, 3);
            this.btdashboard.Name = "btdashboard";
            this.btdashboard.Size = new System.Drawing.Size(196, 38);
            this.btdashboard.TabIndex = 4;
            this.btdashboard.Text = "  Inicio";
            this.btdashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdashboard.UseVisualStyleBackColor = false;
            this.btdashboard.Click += new System.EventHandler(this.btdashboard_Click);
            // 
            // btsair
            // 
            this.btsair.BorderRadius = 3;
            this.btsair.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btsair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btsair.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btsair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btsair.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btsair.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair.ForeColor = System.Drawing.Color.White;
            this.btsair.Location = new System.Drawing.Point(3, 5);
            this.btsair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(194, 29);
            this.btsair.TabIndex = 68;
            this.btsair.Text = "Sair";
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 31);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(868, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 29);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(908, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 29);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(952, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 29);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(230, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 2);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.label2.Location = new System.Drawing.Point(15, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(612, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sistema de Gestão de Cargas Horarias";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.btimprimir);
            this.panel6.Controls.Add(this.btbackup);
            this.panel6.Controls.Add(this.btrestaurar);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(200, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1000, 65);
            this.panel6.TabIndex = 4;
            // 
            // btimprimir
            // 
            this.btimprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btimprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btimprimir.FlatAppearance.BorderSize = 0;
            this.btimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btimprimir.Image = global::SGC.Properties.Resources.print_24px;
            this.btimprimir.Location = new System.Drawing.Point(852, 11);
            this.btimprimir.Name = "btimprimir";
            this.btimprimir.Size = new System.Drawing.Size(38, 40);
            this.btimprimir.TabIndex = 9;
            this.btimprimir.UseVisualStyleBackColor = true;
            this.btimprimir.Click += new System.EventHandler(this.btimprimir_Click);
            // 
            // btbackup
            // 
            this.btbackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btbackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbackup.FlatAppearance.BorderSize = 0;
            this.btbackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbackup.Image = ((System.Drawing.Image)(resources.GetObject("btbackup.Image")));
            this.btbackup.Location = new System.Drawing.Point(940, 6);
            this.btbackup.Name = "btbackup";
            this.btbackup.Size = new System.Drawing.Size(48, 43);
            this.btbackup.TabIndex = 8;
            this.btbackup.UseVisualStyleBackColor = true;
            this.btbackup.Click += new System.EventHandler(this.btbackup_Click);
            // 
            // btrestaurar
            // 
            this.btrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrestaurar.FlatAppearance.BorderSize = 0;
            this.btrestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btrestaurar.Image")));
            this.btrestaurar.Location = new System.Drawing.Point(896, 9);
            this.btrestaurar.Name = "btrestaurar";
            this.btrestaurar.Size = new System.Drawing.Size(38, 40);
            this.btrestaurar.TabIndex = 7;
            this.btrestaurar.UseVisualStyleBackColor = true;
            this.btrestaurar.Click += new System.EventHandler(this.btrestaurar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(356, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "==Unilicungo-Beira==";
            // 
            // painelprincipal
            // 
            this.painelprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelprincipal.Location = new System.Drawing.Point(200, 96);
            this.painelprincipal.Name = "painelprincipal";
            this.painelprincipal.Size = new System.Drawing.Size(1000, 454);
            this.painelprincipal.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 550);
            this.panel7.TabIndex = 69;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btsair);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 510);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 40);
            this.panel8.TabIndex = 69;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.Controls.Add(this.painelprincipal);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btdashboard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btcurso;
        private System.Windows.Forms.Button btgestorcurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btgestorrh;
        private System.Windows.Forms.Panel painelprincipal;
        private System.Windows.Forms.Button btbackup;
        private System.Windows.Forms.Button btrestaurar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label luser;
        private System.Windows.Forms.Button btimprimir;
        private System.Windows.Forms.Button btdisciplina;
        private System.Windows.Forms.Button btdocente;
        private System.Windows.Forms.Button btchefedepartamento;
        private System.Windows.Forms.Timer timer1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btsair;
        private System.Windows.Forms.Button btassociar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
    }
}

