namespace SGC.View
{
    partial class FormAlertaContinuar
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
            this.components = new System.ComponentModel.Container();
            Siticone.Desktop.UI.WinForms.SiticoneButton btcancelar;
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.btcontinuar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lalerta = new System.Windows.Forms.Label();
            btcancelar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btcancelar
            // 
            btcancelar.BorderRadius = 3;
            btcancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btcancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btcancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btcancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btcancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            btcancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btcancelar.ForeColor = System.Drawing.Color.White;
            btcancelar.Location = new System.Drawing.Point(424, 257);
            btcancelar.Name = "btcancelar";
            btcancelar.Size = new System.Drawing.Size(180, 45);
            btcancelar.TabIndex = 1;
            btcancelar.Text = "Cancelar";
            btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.BorderRadius = 4;
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.siticonePictureBox1);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(677, 100);
            this.siticonePanel1.TabIndex = 0;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.Image = global::SGC.Properties.Resources.alerta;
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(268, 0);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(144, 97);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 0;
            this.siticonePictureBox1.TabStop = false;
            // 
            // btcontinuar
            // 
            this.btcontinuar.BorderRadius = 3;
            this.btcontinuar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btcontinuar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btcontinuar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btcontinuar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btcontinuar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btcontinuar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcontinuar.ForeColor = System.Drawing.Color.White;
            this.btcontinuar.Location = new System.Drawing.Point(83, 257);
            this.btcontinuar.Name = "btcontinuar";
            this.btcontinuar.Size = new System.Drawing.Size(180, 45);
            this.btcontinuar.TabIndex = 2;
            this.btcontinuar.Text = "Continuar";
            this.btcontinuar.Click += new System.EventHandler(this.btcontinuar_Click);
            // 
            // lalerta
            // 
            this.lalerta.AutoSize = true;
            this.lalerta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalerta.Location = new System.Drawing.Point(83, 132);
            this.lalerta.Name = "lalerta";
            this.lalerta.Size = new System.Drawing.Size(59, 25);
            this.lalerta.TabIndex = 3;
            this.lalerta.Text = "label1";
            // 
            // FormAlertaContinuar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 323);
            this.Controls.Add(this.lalerta);
            this.Controls.Add(this.btcontinuar);
            this.Controls.Add(btcancelar);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlertaContinuar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlertaContinuar";
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btcontinuar;
        private System.Windows.Forms.Label lalerta;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
    }
}