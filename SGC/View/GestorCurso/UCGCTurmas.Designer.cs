namespace SGC.View.GestorCurso
{
    partial class UCGCTurmas
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.txtcarga = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbano = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbcurso = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.cbdocente = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbdata = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbregime = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbdisciplina = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btapagar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btactualizar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btcadastrar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cbsemestre = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btvercarga = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label10 = new System.Windows.Forms.Label();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lquantcadeiras = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lquantrestante = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lquantmax = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lnivelacademico = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lnomedocente = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.label6.Location = new System.Drawing.Point(252, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(464, 33);
            this.label6.TabIndex = 29;
            this.label6.Text = "Associar Docente ás Disciplinas";
            // 
            // txtcarga
            // 
            this.txtcarga.BorderRadius = 3;
            this.txtcarga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcarga.DefaultText = "";
            this.txtcarga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcarga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcarga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcarga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcarga.Enabled = false;
            this.txtcarga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcarga.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcarga.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcarga.Location = new System.Drawing.Point(365, 71);
            this.txtcarga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcarga.Name = "txtcarga";
            this.txtcarga.PasswordChar = '\0';
            this.txtcarga.PlaceholderText = "Máx: 6";
            this.txtcarga.SelectedText = "";
            this.txtcarga.Size = new System.Drawing.Size(231, 35);
            this.txtcarga.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 21);
            this.label8.TabIndex = 96;
            this.label8.Text = "Selecione o Ano";
            // 
            // cbano
            // 
            this.cbano.BackColor = System.Drawing.Color.Transparent;
            this.cbano.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbano.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbano.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbano.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbano.ItemHeight = 30;
            this.cbano.Items.AddRange(new object[] {
            "1º Ano",
            "2º Ano",
            "3º Ano",
            "4º Ano",
            "5º Ano"});
            this.cbano.Location = new System.Drawing.Point(59, 141);
            this.cbano.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbano.Name = "cbano";
            this.cbano.Size = new System.Drawing.Size(231, 36);
            this.cbano.TabIndex = 95;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(361, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 21);
            this.label9.TabIndex = 94;
            this.label9.Text = "Carga Horária da Disciplina";
            // 
            // cbcurso
            // 
            this.cbcurso.BackColor = System.Drawing.Color.Transparent;
            this.cbcurso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbcurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcurso.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbcurso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbcurso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbcurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbcurso.ItemHeight = 30;
            this.cbcurso.Location = new System.Drawing.Point(59, 208);
            this.cbcurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbcurso.Name = "cbcurso";
            this.cbcurso.Size = new System.Drawing.Size(231, 36);
            this.cbcurso.TabIndex = 93;
            // 
            // cbdocente
            // 
            this.cbdocente.BackColor = System.Drawing.Color.Transparent;
            this.cbdocente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbdocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdocente.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbdocente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbdocente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbdocente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbdocente.ItemHeight = 30;
            this.cbdocente.Location = new System.Drawing.Point(365, 141);
            this.cbdocente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbdocente.Name = "cbdocente";
            this.cbdocente.Size = new System.Drawing.Size(231, 36);
            this.cbdocente.TabIndex = 92;
            this.cbdocente.SelectedIndexChanged += new System.EventHandler(this.cbdocente_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(362, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 90;
            this.label7.Text = "Docente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 89;
            this.label4.Text = "Selecione Curso";
            // 
            // cbdata
            // 
            this.cbdata.Checked = true;
            this.cbdata.FillColor = System.Drawing.Color.Transparent;
            this.cbdata.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cbdata.Location = new System.Drawing.Point(365, 208);
            this.cbdata.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.cbdata.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.cbdata.Name = "cbdata";
            this.cbdata.Size = new System.Drawing.Size(231, 32);
            this.cbdata.TabIndex = 99;
            this.cbdata.Value = new System.DateTime(2025, 6, 16, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 100;
            this.label1.Text = "Ano Letivo";
            // 
            // cbregime
            // 
            this.cbregime.BackColor = System.Drawing.Color.Transparent;
            this.cbregime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbregime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbregime.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbregime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbregime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbregime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbregime.ItemHeight = 30;
            this.cbregime.Items.AddRange(new object[] {
            "Laboral",
            "Pos-Laboral"});
            this.cbregime.Location = new System.Drawing.Point(669, 71);
            this.cbregime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbregime.Name = "cbregime";
            this.cbregime.Size = new System.Drawing.Size(231, 36);
            this.cbregime.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(666, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 102;
            this.label2.Text = "Regime";
            // 
            // cbdisciplina
            // 
            this.cbdisciplina.BackColor = System.Drawing.Color.Transparent;
            this.cbdisciplina.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbdisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdisciplina.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbdisciplina.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbdisciplina.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbdisciplina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbdisciplina.ItemHeight = 30;
            this.cbdisciplina.Location = new System.Drawing.Point(59, 70);
            this.cbdisciplina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbdisciplina.Name = "cbdisciplina";
            this.cbdisciplina.Size = new System.Drawing.Size(231, 36);
            this.cbdisciplina.TabIndex = 104;
            this.cbdisciplina.SelectedIndexChanged += new System.EventHandler(this.cbdisciplina_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 103;
            this.label3.Text = "Selecione a Disciplina";
            // 
            // btapagar
            // 
            this.btapagar.BorderRadius = 3;
            this.btapagar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btapagar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btapagar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btapagar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btapagar.FillColor = System.Drawing.Color.Firebrick;
            this.btapagar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btapagar.ForeColor = System.Drawing.Color.White;
            this.btapagar.Location = new System.Drawing.Point(670, 268);
            this.btapagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btapagar.Name = "btapagar";
            this.btapagar.Size = new System.Drawing.Size(228, 32);
            this.btapagar.TabIndex = 107;
            this.btapagar.Text = "Apagar";
            // 
            // btactualizar
            // 
            this.btactualizar.BorderRadius = 3;
            this.btactualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btactualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btactualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btactualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btactualizar.FillColor = System.Drawing.SystemColors.Highlight;
            this.btactualizar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btactualizar.ForeColor = System.Drawing.Color.White;
            this.btactualizar.Location = new System.Drawing.Point(365, 268);
            this.btactualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.Size = new System.Drawing.Size(231, 33);
            this.btactualizar.TabIndex = 106;
            this.btactualizar.Text = "Actualizar";
            // 
            // btcadastrar
            // 
            this.btcadastrar.BorderRadius = 3;
            this.btcadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btcadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btcadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btcadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btcadastrar.FillColor = System.Drawing.Color.Green;
            this.btcadastrar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrar.ForeColor = System.Drawing.Color.White;
            this.btcadastrar.Location = new System.Drawing.Point(60, 268);
            this.btcadastrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(230, 32);
            this.btcadastrar.TabIndex = 105;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // cbsemestre
            // 
            this.cbsemestre.BackColor = System.Drawing.Color.Transparent;
            this.cbsemestre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbsemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsemestre.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbsemestre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbsemestre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbsemestre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbsemestre.ItemHeight = 30;
            this.cbsemestre.Items.AddRange(new object[] {
            "1º Semestre",
            "2º Semestre"});
            this.cbsemestre.Location = new System.Drawing.Point(669, 141);
            this.cbsemestre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbsemestre.Name = "cbsemestre";
            this.cbsemestre.Size = new System.Drawing.Size(231, 36);
            this.cbsemestre.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(667, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 18);
            this.label5.TabIndex = 108;
            this.label5.Text = "Selecione o Semestre";
            // 
            // btvercarga
            // 
            this.btvercarga.BorderRadius = 3;
            this.btvercarga.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btvercarga.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btvercarga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btvercarga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btvercarga.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.btvercarga.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvercarga.ForeColor = System.Drawing.Color.White;
            this.btvercarga.Image = global::SGC.Properties.Resources.Eye;
            this.btvercarga.ImageSize = new System.Drawing.Size(40, 40);
            this.btvercarga.Location = new System.Drawing.Point(670, 208);
            this.btvercarga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btvercarga.Name = "btvercarga";
            this.btvercarga.Size = new System.Drawing.Size(228, 33);
            this.btvercarga.TabIndex = 110;
            this.btvercarga.Text = "Ver Cargas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(27, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 16);
            this.label10.TabIndex = 111;
            this.label10.Text = "Nome de docente:";
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(97)))));
            this.siticonePanel1.BorderRadius = 5;
            this.siticonePanel1.Controls.Add(this.lquantcadeiras);
            this.siticonePanel1.Controls.Add(this.label16);
            this.siticonePanel1.Controls.Add(this.lquantrestante);
            this.siticonePanel1.Controls.Add(this.label14);
            this.siticonePanel1.Controls.Add(this.lquantmax);
            this.siticonePanel1.Controls.Add(this.label15);
            this.siticonePanel1.Controls.Add(this.lnivelacademico);
            this.siticonePanel1.Controls.Add(this.label13);
            this.siticonePanel1.Controls.Add(this.lnomedocente);
            this.siticonePanel1.Controls.Add(this.label11);
            this.siticonePanel1.Controls.Add(this.label10);
            this.siticonePanel1.Location = new System.Drawing.Point(59, 318);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(839, 142);
            this.siticonePanel1.TabIndex = 114;
            // 
            // lquantcadeiras
            // 
            this.lquantcadeiras.AutoSize = true;
            this.lquantcadeiras.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lquantcadeiras.ForeColor = System.Drawing.Color.White;
            this.lquantcadeiras.Location = new System.Drawing.Point(725, 63);
            this.lquantcadeiras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lquantcadeiras.Name = "lquantcadeiras";
            this.lquantcadeiras.Size = new System.Drawing.Size(51, 16);
            this.lquantcadeiras.TabIndex = 121;
            this.lquantcadeiras.Text = "label12";
            this.lquantcadeiras.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(513, 63);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(205, 16);
            this.label16.TabIndex = 120;
            this.label16.Text = "Número Total de Cadeiras Atribuidas:";
            // 
            // lquantrestante
            // 
            this.lquantrestante.AutoSize = true;
            this.lquantrestante.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lquantrestante.ForeColor = System.Drawing.Color.White;
            this.lquantrestante.Location = new System.Drawing.Point(725, 40);
            this.lquantrestante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lquantrestante.Name = "lquantrestante";
            this.lquantrestante.Size = new System.Drawing.Size(51, 16);
            this.lquantrestante.TabIndex = 119;
            this.lquantrestante.Text = "label12";
            this.lquantrestante.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(513, 40);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 16);
            this.label14.TabIndex = 118;
            this.label14.Text = "Quantidade Restante de Cargas:";
            // 
            // lquantmax
            // 
            this.lquantmax.AutoSize = true;
            this.lquantmax.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lquantmax.ForeColor = System.Drawing.Color.White;
            this.lquantmax.Location = new System.Drawing.Point(200, 89);
            this.lquantmax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lquantmax.Name = "lquantmax";
            this.lquantmax.Size = new System.Drawing.Size(51, 16);
            this.lquantmax.TabIndex = 117;
            this.lquantmax.Text = "label12";
            this.lquantmax.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(27, 89);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(165, 16);
            this.label15.TabIndex = 116;
            this.label15.Text = "Quantidade máxima de carga:";
            // 
            // lnivelacademico
            // 
            this.lnivelacademico.AutoSize = true;
            this.lnivelacademico.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnivelacademico.ForeColor = System.Drawing.Color.White;
            this.lnivelacademico.Location = new System.Drawing.Point(200, 63);
            this.lnivelacademico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnivelacademico.Name = "lnivelacademico";
            this.lnivelacademico.Size = new System.Drawing.Size(108, 16);
            this.lnivelacademico.TabIndex = 115;
            this.lnivelacademico.Text = "lnivelacademico";
            this.lnivelacademico.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(27, 63);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 16);
            this.label13.TabIndex = 114;
            this.label13.Text = "Nivel Academico:";
            // 
            // lnomedocente
            // 
            this.lnomedocente.AutoSize = true;
            this.lnomedocente.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnomedocente.ForeColor = System.Drawing.Color.White;
            this.lnomedocente.Location = new System.Drawing.Point(200, 37);
            this.lnomedocente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnomedocente.Name = "lnomedocente";
            this.lnomedocente.Size = new System.Drawing.Size(51, 16);
            this.lnomedocente.TabIndex = 113;
            this.lnomedocente.Text = "label12";
            this.lnomedocente.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.label11.Location = new System.Drawing.Point(289, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(283, 21);
            this.label11.TabIndex = 112;
            this.label11.Text = "MAIS INFORMAÇÕES DE DOCENTE";
            // 
            // UCGCTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.btvercarga);
            this.Controls.Add(this.cbsemestre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btapagar);
            this.Controls.Add(this.btactualizar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.cbdisciplina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbregime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbdata);
            this.Controls.Add(this.txtcarga);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbano);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbcurso);
            this.Controls.Add(this.cbdocente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCGCTurmas";
            this.Size = new System.Drawing.Size(981, 478);
            this.Load += new System.EventHandler(this.UCGCTurmas_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtcarga;
        private System.Windows.Forms.Label label8;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbano;
        private System.Windows.Forms.Label label9;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbcurso;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbdocente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker cbdata;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbregime;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbdisciplina;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btapagar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btactualizar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btcadastrar;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbsemestre;
        private System.Windows.Forms.Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btvercarga;
        private System.Windows.Forms.Label label10;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label lnomedocente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lquantrestante;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lquantmax;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lnivelacademico;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lquantcadeiras;
        private System.Windows.Forms.Label label16;
    }
}
