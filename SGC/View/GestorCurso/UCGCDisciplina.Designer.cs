namespace SGC
{
    partial class UCGCDisciplina
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btapagar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btactualizar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btcadastrar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnivel = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbcurso = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.txtnome = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtcarga = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.cbsemestre = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.dataGridView1 = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.label6.Location = new System.Drawing.Point(410, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(457, 52);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cadastrar Disciplinas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 525);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Semestre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 429);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Curso";
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
            this.btapagar.Location = new System.Drawing.Point(1076, 100);
            this.btapagar.Name = "btapagar";
            this.btapagar.Size = new System.Drawing.Size(274, 52);
            this.btapagar.TabIndex = 87;
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
            this.btactualizar.FillColor = System.Drawing.SystemColors.Highlight;
            this.btactualizar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btactualizar.ForeColor = System.Drawing.Color.White;
            this.btactualizar.Location = new System.Drawing.Point(766, 100);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.Size = new System.Drawing.Size(274, 52);
            this.btactualizar.TabIndex = 86;
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
            this.btcadastrar.Location = new System.Drawing.Point(458, 102);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(274, 52);
            this.btcadastrar.TabIndex = 85;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 324);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 32);
            this.label8.TabIndex = 84;
            this.label8.Text = "Selecione o Nivel";
            // 
            // txtnivel
            // 
            this.txtnivel.BackColor = System.Drawing.Color.Transparent;
            this.txtnivel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtnivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtnivel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnivel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnivel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtnivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtnivel.ItemHeight = 30;
            this.txtnivel.Items.AddRange(new object[] {
            "1º Ano",
            "2º Ano",
            "3º Ano",
            "4º Ano",
            "5º Ano"});
            this.txtnivel.Location = new System.Drawing.Point(22, 358);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(307, 36);
            this.txtnivel.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 223);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 32);
            this.label9.TabIndex = 82;
            this.label9.Text = "Carga Horária";
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
            this.cbcurso.Location = new System.Drawing.Point(22, 461);
            this.cbcurso.Name = "cbcurso";
            this.cbcurso.Size = new System.Drawing.Size(307, 36);
            this.cbcurso.TabIndex = 81;
            // 
            // txtnome
            // 
            this.txtnome.BorderRadius = 3;
            this.txtnome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnome.DefaultText = "";
            this.txtnome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnome.Location = new System.Drawing.Point(22, 166);
            this.txtnome.Name = "txtnome";
            this.txtnome.PasswordChar = '\0';
            this.txtnome.PlaceholderText = "Digite o nome da Disciplina";
            this.txtnome.SelectedText = "";
            this.txtnome.Size = new System.Drawing.Size(308, 54);
            this.txtnome.TabIndex = 79;
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
            this.txtcarga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcarga.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcarga.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcarga.Location = new System.Drawing.Point(22, 260);
            this.txtcarga.Name = "txtcarga";
            this.txtcarga.PasswordChar = '\0';
            this.txtcarga.PlaceholderText = "Máx: 6";
            this.txtcarga.SelectedText = "";
            this.txtcarga.Size = new System.Drawing.Size(308, 57);
            this.txtcarga.TabIndex = 88;
            this.txtcarga.TextChanged += new System.EventHandler(this.txtcarga_TextChanged);
            this.txtcarga.Leave += new System.EventHandler(this.txtcarga_Leave);
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
            this.cbsemestre.Location = new System.Drawing.Point(21, 562);
            this.cbsemestre.Name = "cbsemestre";
            this.cbsemestre.Size = new System.Drawing.Size(307, 36);
            this.cbsemestre.TabIndex = 89;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeight = 18;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(350, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 498);
            this.dataGridView1.TabIndex = 90;
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
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // UCGCDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbsemestre);
            this.Controls.Add(this.txtcarga);
            this.Controls.Add(this.btapagar);
            this.Controls.Add(this.btactualizar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnivel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbcurso);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCGCDisciplina";
            this.Size = new System.Drawing.Size(1376, 688);
            this.Load += new System.EventHandler(this.UCGCDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btapagar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btactualizar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btcadastrar;
        private System.Windows.Forms.Label label8;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox txtnivel;
        private System.Windows.Forms.Label label9;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbcurso;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtnome;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtcarga;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbsemestre;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dataGridView1;
    }
}
