namespace SGC.View.GestorCurso
{
    partial class UCTurmasGestor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtprocurar = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btprocurar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.dataGridView1 = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.cbsemestre = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btapagar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btactualizar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btcadastrar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cbdisciplina = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbregime = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbdata = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.txtcarga = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbano = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbcurso = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.cbdocente = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtprocurar
            // 
            this.txtprocurar.BorderRadius = 5;
            this.txtprocurar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprocurar.DefaultText = "";
            this.txtprocurar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprocurar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprocurar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprocurar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprocurar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprocurar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtprocurar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprocurar.IconLeft = global::SGC.Properties.Resources.Search11;
            this.txtprocurar.IconLeftOffset = new System.Drawing.Point(3, 1);
            this.txtprocurar.Location = new System.Drawing.Point(508, 179);
            this.txtprocurar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtprocurar.Name = "txtprocurar";
            this.txtprocurar.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.txtprocurar.PasswordChar = '\0';
            this.txtprocurar.PlaceholderText = "Procurar...";
            this.txtprocurar.SelectedText = "";
            this.txtprocurar.Size = new System.Drawing.Size(425, 34);
            this.txtprocurar.TabIndex = 139;
            this.txtprocurar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtprocurar_KeyDown);
            // 
            // btprocurar
            // 
            this.btprocurar.BorderRadius = 4;
            this.btprocurar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btprocurar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btprocurar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btprocurar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btprocurar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.btprocurar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btprocurar.ForeColor = System.Drawing.Color.White;
            this.btprocurar.Image = global::SGC.Properties.Resources.Search1;
            this.btprocurar.Location = new System.Drawing.Point(933, 179);
            this.btprocurar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btprocurar.Name = "btprocurar";
            this.btprocurar.Size = new System.Drawing.Size(35, 34);
            this.btprocurar.TabIndex = 140;
            this.btprocurar.Click += new System.EventHandler(this.btprocurar_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 18;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(19, 223);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(949, 311);
            this.dataGridView1.TabIndex = 138;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 18;
            this.dataGridView1.ThemeStyle.ReadOnly = false;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.cbsemestre.Location = new System.Drawing.Point(508, 57);
            this.cbsemestre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbsemestre.Name = "cbsemestre";
            this.cbsemestre.Size = new System.Drawing.Size(231, 36);
            this.cbsemestre.TabIndex = 137;
            this.cbsemestre.SelectedIndexChanged += new System.EventHandler(this.cbsemestre_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(506, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 18);
            this.label5.TabIndex = 136;
            this.label5.Text = "Selecione o Semestre";
            // 
            // btapagar
            // 
            this.btapagar.BorderRadius = 3;
            this.btapagar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btapagar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btapagar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btapagar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btapagar.Enabled = false;
            this.btapagar.FillColor = System.Drawing.Color.Firebrick;
            this.btapagar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btapagar.ForeColor = System.Drawing.Color.White;
            this.btapagar.Location = new System.Drawing.Point(755, 135);
            this.btapagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btapagar.Name = "btapagar";
            this.btapagar.Size = new System.Drawing.Size(213, 32);
            this.btapagar.TabIndex = 135;
            this.btapagar.Text = "Apagar";
            this.btapagar.Click += new System.EventHandler(this.btapagar_Click);
            // 
            // btactualizar
            // 
            this.btactualizar.BorderRadius = 3;
            this.btactualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btactualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btactualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btactualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btactualizar.Enabled = false;
            this.btactualizar.FillColor = System.Drawing.SystemColors.Highlight;
            this.btactualizar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btactualizar.ForeColor = System.Drawing.Color.White;
            this.btactualizar.Location = new System.Drawing.Point(755, 86);
            this.btactualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.Size = new System.Drawing.Size(213, 33);
            this.btactualizar.TabIndex = 134;
            this.btactualizar.Text = "Actualizar";
            this.btactualizar.Click += new System.EventHandler(this.btactualizar_Click);
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
            this.btcadastrar.Location = new System.Drawing.Point(755, 42);
            this.btcadastrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(213, 32);
            this.btcadastrar.TabIndex = 133;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
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
            this.cbdisciplina.Location = new System.Drawing.Point(16, 179);
            this.cbdisciplina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbdisciplina.Name = "cbdisciplina";
            this.cbdisciplina.Size = new System.Drawing.Size(231, 36);
            this.cbdisciplina.TabIndex = 132;
            this.cbdisciplina.SelectedIndexChanged += new System.EventHandler(this.cbdisciplina_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 131;
            this.label3.Text = "Selecione a Disciplina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 130;
            this.label2.Text = "Regime";
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
            this.cbregime.Location = new System.Drawing.Point(16, 120);
            this.cbregime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbregime.Name = "cbregime";
            this.cbregime.Size = new System.Drawing.Size(231, 36);
            this.cbregime.TabIndex = 129;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 128;
            this.label1.Text = "Ano Letivo";
            // 
            // cbdata
            // 
            this.cbdata.BorderRadius = 3;
            this.cbdata.Checked = true;
            this.cbdata.CustomFormat = "yyyy";
            this.cbdata.FillColor = System.Drawing.Color.White;
            this.cbdata.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbdata.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cbdata.Location = new System.Drawing.Point(265, 181);
            this.cbdata.MaxDate = new System.DateTime(2025, 6, 17, 22, 24, 36, 0);
            this.cbdata.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.cbdata.Name = "cbdata";
            this.cbdata.Size = new System.Drawing.Size(231, 32);
            this.cbdata.TabIndex = 127;
            this.cbdata.Value = new System.DateTime(2025, 6, 16, 0, 0, 0, 0);
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
            this.txtcarga.Location = new System.Drawing.Point(508, 122);
            this.txtcarga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcarga.Name = "txtcarga";
            this.txtcarga.PasswordChar = '\0';
            this.txtcarga.PlaceholderText = "Máx: 6";
            this.txtcarga.SelectedText = "";
            this.txtcarga.Size = new System.Drawing.Size(231, 35);
            this.txtcarga.TabIndex = 126;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(257, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 21);
            this.label8.TabIndex = 125;
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
            this.cbano.Location = new System.Drawing.Point(261, 57);
            this.cbano.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbano.Name = "cbano";
            this.cbano.Size = new System.Drawing.Size(231, 36);
            this.cbano.TabIndex = 124;
            this.cbano.SelectedIndexChanged += new System.EventHandler(this.cbano_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(504, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 21);
            this.label9.TabIndex = 123;
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
            this.cbcurso.Location = new System.Drawing.Point(16, 57);
            this.cbcurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbcurso.Name = "cbcurso";
            this.cbcurso.Size = new System.Drawing.Size(231, 36);
            this.cbcurso.TabIndex = 122;
            this.cbcurso.SelectedIndexChanged += new System.EventHandler(this.cbcurso_SelectedIndexChanged);
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
            this.cbdocente.Location = new System.Drawing.Point(265, 120);
            this.cbdocente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbdocente.Name = "cbdocente";
            this.cbdocente.Size = new System.Drawing.Size(231, 36);
            this.cbdocente.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(262, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 120;
            this.label7.Text = "Docente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 119;
            this.label4.Text = "Selecione Curso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.label6.Location = new System.Drawing.Point(255, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(464, 33);
            this.label6.TabIndex = 118;
            this.label6.Text = "Associar Docente ás Disciplinas";
            // 
            // UCTurmasGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtprocurar);
            this.Controls.Add(this.btprocurar);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "UCTurmasGestor";
            this.Size = new System.Drawing.Size(980, 543);
            this.Load += new System.EventHandler(this.UCTurmasGestor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtprocurar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btprocurar;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dataGridView1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbsemestre;
        private System.Windows.Forms.Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btapagar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btactualizar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btcadastrar;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbdisciplina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbregime;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker cbdata;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtcarga;
        private System.Windows.Forms.Label label8;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbano;
        private System.Windows.Forms.Label label9;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbcurso;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbdocente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}
