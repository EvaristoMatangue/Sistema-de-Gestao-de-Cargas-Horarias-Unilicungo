namespace SGC.View
{
    partial class AlterarSenha
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txterror = new System.Windows.Forms.Label();
            this.txtemail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtnomeusuario = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtnovasenha = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtsenhaactual = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtconfirmar = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btsubmeter = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btveresconder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 48);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(327, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 41);
            this.label4.TabIndex = 13;
            this.label4.Text = "ALTERAR SENHA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txterror
            // 
            this.txterror.AutoSize = true;
            this.txterror.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txterror.ForeColor = System.Drawing.Color.Black;
            this.txterror.Location = new System.Drawing.Point(38, 377);
            this.txterror.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txterror.Name = "txterror";
            this.txterror.Size = new System.Drawing.Size(276, 28);
            this.txterror.TabIndex = 33;
            this.txterror.Text = "---------------------------------";
            this.txterror.Visible = false;
            // 
            // txtemail
            // 
            this.txtemail.BorderRadius = 3;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.Enabled = false;
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Location = new System.Drawing.Point(495, 105);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderText = "Digite seu email";
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(344, 47);
            this.txtemail.TabIndex = 34;
            // 
            // txtnomeusuario
            // 
            this.txtnomeusuario.BorderRadius = 3;
            this.txtnomeusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnomeusuario.DefaultText = "";
            this.txtnomeusuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnomeusuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnomeusuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnomeusuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnomeusuario.Enabled = false;
            this.txtnomeusuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnomeusuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeusuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnomeusuario.Location = new System.Drawing.Point(43, 105);
            this.txtnomeusuario.Name = "txtnomeusuario";
            this.txtnomeusuario.PasswordChar = '\0';
            this.txtnomeusuario.PlaceholderText = "Digite seu nome do usuario";
            this.txtnomeusuario.SelectedText = "";
            this.txtnomeusuario.Size = new System.Drawing.Size(344, 47);
            this.txtnomeusuario.TabIndex = 35;
            // 
            // txtnovasenha
            // 
            this.txtnovasenha.BorderRadius = 3;
            this.txtnovasenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnovasenha.DefaultText = "";
            this.txtnovasenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnovasenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnovasenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnovasenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnovasenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnovasenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnovasenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnovasenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnovasenha.Location = new System.Drawing.Point(495, 214);
            this.txtnovasenha.Name = "txtnovasenha";
            this.txtnovasenha.PasswordChar = '\0';
            this.txtnovasenha.PlaceholderText = "Digite sua nova Senha";
            this.txtnovasenha.SelectedText = "";
            this.txtnovasenha.Size = new System.Drawing.Size(344, 47);
            this.txtnovasenha.TabIndex = 36;
            this.txtnovasenha.TextChanged += new System.EventHandler(this.txtnovasenha_TextChanged);
            // 
            // txtsenhaactual
            // 
            this.txtsenhaactual.BorderRadius = 3;
            this.txtsenhaactual.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsenhaactual.DefaultText = "";
            this.txtsenhaactual.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsenhaactual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsenhaactual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsenhaactual.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsenhaactual.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsenhaactual.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenhaactual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsenhaactual.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsenhaactual.Location = new System.Drawing.Point(43, 214);
            this.txtsenhaactual.Name = "txtsenhaactual";
            this.txtsenhaactual.PasswordChar = '\0';
            this.txtsenhaactual.PlaceholderText = "Digite sua senha actual";
            this.txtsenhaactual.SelectedText = "";
            this.txtsenhaactual.Size = new System.Drawing.Size(344, 47);
            this.txtsenhaactual.TabIndex = 37;
            // 
            // txtconfirmar
            // 
            this.txtconfirmar.BorderRadius = 3;
            this.txtconfirmar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtconfirmar.DefaultText = "";
            this.txtconfirmar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtconfirmar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtconfirmar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtconfirmar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtconfirmar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtconfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtconfirmar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtconfirmar.Location = new System.Drawing.Point(43, 316);
            this.txtconfirmar.Name = "txtconfirmar";
            this.txtconfirmar.PasswordChar = '\0';
            this.txtconfirmar.PlaceholderText = "Confirme sua senha nova";
            this.txtconfirmar.SelectedText = "";
            this.txtconfirmar.Size = new System.Drawing.Size(344, 47);
            this.txtconfirmar.TabIndex = 38;
            // 
            // btsubmeter
            // 
            this.btsubmeter.BorderRadius = 3;
            this.btsubmeter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btsubmeter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btsubmeter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btsubmeter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btsubmeter.FillColor = System.Drawing.Color.DodgerBlue;
            this.btsubmeter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsubmeter.ForeColor = System.Drawing.Color.White;
            this.btsubmeter.Location = new System.Drawing.Point(495, 316);
            this.btsubmeter.Name = "btsubmeter";
            this.btsubmeter.Size = new System.Drawing.Size(344, 45);
            this.btsubmeter.TabIndex = 39;
            this.btsubmeter.Text = "Alterar Senha";
            this.btsubmeter.Click += new System.EventHandler(this.btsubmeter_Click);
            // 
            // btveresconder
            // 
            this.btveresconder.FlatAppearance.BorderSize = 0;
            this.btveresconder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btveresconder.Image = global::SGC.Properties.Resources.eye_20px;
            this.btveresconder.Location = new System.Drawing.Point(394, 219);
            this.btveresconder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btveresconder.Name = "btveresconder";
            this.btveresconder.Size = new System.Drawing.Size(42, 38);
            this.btveresconder.TabIndex = 32;
            this.btveresconder.UseVisualStyleBackColor = true;
            this.btveresconder.Click += new System.EventHandler(this.btveresconder_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::SGC.Properties.Resources.close_24px;
            this.button1.Location = new System.Drawing.Point(828, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 45);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(898, 426);
            this.Controls.Add(this.btsubmeter);
            this.Controls.Add(this.txtconfirmar);
            this.Controls.Add(this.txtsenhaactual);
            this.Controls.Add(this.txtnovasenha);
            this.Controls.Add(this.txtnomeusuario);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txterror);
            this.Controls.Add(this.btveresconder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterarSenha";
            this.Load += new System.EventHandler(this.AlterarSenha_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btveresconder;
        private System.Windows.Forms.Label txterror;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtemail;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtnomeusuario;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtnovasenha;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtsenhaactual;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtconfirmar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btsubmeter;
    }
}