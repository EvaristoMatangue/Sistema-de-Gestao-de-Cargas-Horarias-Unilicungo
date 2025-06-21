namespace SGC
{
    partial class UCDisciplina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbsemestre = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.txtcarga = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnivel = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbcurso = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.txtnome = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.btactualizar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btcadastrar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btapagar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Curso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.label6.Location = new System.Drawing.Point(290, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 33);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cadastrar Disciplinas";
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
            this.cbsemestre.Location = new System.Drawing.Point(6, 375);
            this.cbsemestre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbsemestre.Name = "cbsemestre";
            this.cbsemestre.Size = new System.Drawing.Size(206, 36);
            this.cbsemestre.TabIndex = 98;
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
            this.txtcarga.Location = new System.Drawing.Point(8, 179);
            this.txtcarga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcarga.Name = "txtcarga";
            this.txtcarga.PasswordChar = '\0';
            this.txtcarga.PlaceholderText = "Máx: 6";
            this.txtcarga.SelectedText = "";
            this.txtcarga.Size = new System.Drawing.Size(205, 35);
            this.txtcarga.TabIndex = 97;
            this.txtcarga.Leave += new System.EventHandler(this.txtcarga_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 21);
            this.label8.TabIndex = 96;
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
            this.txtnivel.Location = new System.Drawing.Point(8, 244);
            this.txtnivel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(206, 36);
            this.txtnivel.TabIndex = 95;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 21);
            this.label9.TabIndex = 94;
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
            this.cbcurso.Location = new System.Drawing.Point(8, 306);
            this.cbcurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbcurso.Name = "cbcurso";
            this.cbcurso.Size = new System.Drawing.Size(206, 36);
            this.cbcurso.TabIndex = 93;
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
            this.txtnome.Location = new System.Drawing.Point(7, 117);
            this.txtnome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnome.Name = "txtnome";
            this.txtnome.PasswordChar = '\0';
            this.txtnome.PlaceholderText = "Digite o nome da Disciplina";
            this.txtnome.SelectedText = "";
            this.txtnome.Size = new System.Drawing.Size(205, 36);
            this.txtnome.TabIndex = 91;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 90;
            this.label10.Text = "Semestre";
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
            this.dataGridView1.Location = new System.Drawing.Point(229, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(667, 305);
            this.dataGridView1.TabIndex = 99;
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
            this.btactualizar.Location = new System.Drawing.Point(509, 66);
            this.btactualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.Size = new System.Drawing.Size(183, 36);
            this.btactualizar.TabIndex = 101;
            this.btactualizar.Text = "Actualizar";
            this.btactualizar.Click += new System.EventHandler(this.btactualizar_Click_1);
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
            this.btcadastrar.Location = new System.Drawing.Point(301, 66);
            this.btcadastrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(183, 36);
            this.btcadastrar.TabIndex = 100;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click_1);
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
            this.btapagar.Location = new System.Drawing.Point(713, 68);
            this.btapagar.Margin = new System.Windows.Forms.Padding(2);
            this.btapagar.Name = "btapagar";
            this.btapagar.Size = new System.Drawing.Size(183, 34);
            this.btapagar.TabIndex = 102;
            this.btapagar.Text = "Apagar";
            this.btapagar.Click += new System.EventHandler(this.btapagar_Click);
            // 
            // UCDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btapagar);
            this.Controls.Add(this.btactualizar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbsemestre);
            this.Controls.Add(this.txtcarga);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnivel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbcurso);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Name = "UCDisciplina";
            this.Size = new System.Drawing.Size(917, 447);
            this.Load += new System.EventHandler(this.UCDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbsemestre;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtcarga;
        private System.Windows.Forms.Label label8;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox txtnivel;
        private System.Windows.Forms.Label label9;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbcurso;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtnome;
        private System.Windows.Forms.Label label10;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dataGridView1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btactualizar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btcadastrar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btapagar;
    }
}
