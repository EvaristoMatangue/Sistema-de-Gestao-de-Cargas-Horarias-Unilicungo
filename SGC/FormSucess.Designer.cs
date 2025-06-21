namespace SGC
{
    partial class FormSucess
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
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsucess = new System.Windows.Forms.Label();
            this.btfechar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.BorderRadius = 4;
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.siticonePictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 90);
            this.panel1.TabIndex = 0;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = global::SGC.Properties.Resources.ok_48px;
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(175, 12);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(101, 66);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 0;
            this.siticonePictureBox1.TabStop = false;
            this.siticonePictureBox1.Click += new System.EventHandler(this.siticonePictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsucess);
            this.panel2.Location = new System.Drawing.Point(12, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 31);
            this.panel2.TabIndex = 18;
            // 
            // lsucess
            // 
            this.lsucess.AutoSize = true;
            this.lsucess.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsucess.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsucess.Location = new System.Drawing.Point(0, 0);
            this.lsucess.Name = "lsucess";
            this.lsucess.Size = new System.Drawing.Size(417, 16);
            this.lsucess.TabIndex = 15;
            this.lsucess.Text = "---------------------------------------------------------------------------------" +
    "-";
            this.lsucess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btfechar
            // 
            this.btfechar.BorderRadius = 3;
            this.btfechar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btfechar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btfechar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btfechar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btfechar.FillColor = System.Drawing.Color.Green;
            this.btfechar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfechar.ForeColor = System.Drawing.Color.White;
            this.btfechar.Location = new System.Drawing.Point(135, 153);
            this.btfechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btfechar.Name = "btfechar";
            this.btfechar.Size = new System.Drawing.Size(183, 29);
            this.btfechar.TabIndex = 69;
            this.btfechar.Text = "Fechar";
            this.btfechar.Click += new System.EventHandler(this.btfechar_Click);
            // 
            // FormSucess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 187);
            this.Controls.Add(this.btfechar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSucess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSucess";
            this.Load += new System.EventHandler(this.FormSucess_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lsucess;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btfechar;
    }
}