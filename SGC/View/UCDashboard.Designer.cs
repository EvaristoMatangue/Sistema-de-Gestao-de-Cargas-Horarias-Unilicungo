namespace SGC.View
{
    partial class UCDashboard
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
            this.label4 = new System.Windows.Forms.Label();
            this.btlaboral = new System.Windows.Forms.Button();
            this.btposlaboral = new System.Windows.Forms.Button();
            this.lsemestreum = new System.Windows.Forms.Label();
            this.lsementredois = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.label4.Location = new System.Drawing.Point(258, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "CARGA HORARIA DOS DOCENTES INTERNOS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btlaboral
            // 
            this.btlaboral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.btlaboral.FlatAppearance.BorderSize = 0;
            this.btlaboral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlaboral.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlaboral.ForeColor = System.Drawing.Color.White;
            this.btlaboral.Location = new System.Drawing.Point(650, 131);
            this.btlaboral.Name = "btlaboral";
            this.btlaboral.Size = new System.Drawing.Size(113, 27);
            this.btlaboral.TabIndex = 23;
            this.btlaboral.Text = "Laboral";
            this.btlaboral.UseVisualStyleBackColor = false;
            this.btlaboral.Click += new System.EventHandler(this.btlaboral_Click);
            // 
            // btposlaboral
            // 
            this.btposlaboral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.btposlaboral.FlatAppearance.BorderSize = 0;
            this.btposlaboral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btposlaboral.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btposlaboral.ForeColor = System.Drawing.Color.White;
            this.btposlaboral.Location = new System.Drawing.Point(769, 131);
            this.btposlaboral.Name = "btposlaboral";
            this.btposlaboral.Size = new System.Drawing.Size(113, 27);
            this.btposlaboral.TabIndex = 22;
            this.btposlaboral.Text = "Pôs-Laboral";
            this.btposlaboral.UseVisualStyleBackColor = false;
            this.btposlaboral.Click += new System.EventHandler(this.btposlaboral_Click);
            // 
            // lsemestreum
            // 
            this.lsemestreum.AutoSize = true;
            this.lsemestreum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.lsemestreum.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsemestreum.ForeColor = System.Drawing.Color.White;
            this.lsemestreum.Location = new System.Drawing.Point(656, 85);
            this.lsemestreum.Name = "lsemestreum";
            this.lsemestreum.Size = new System.Drawing.Size(112, 18);
            this.lsemestreum.TabIndex = 19;
            this.lsemestreum.Text = "1º Semestre";
            this.lsemestreum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lsemestreum.Click += new System.EventHandler(this.lsemestreum_Click);
            // 
            // lsementredois
            // 
            this.lsementredois.AutoSize = true;
            this.lsementredois.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsementredois.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.lsementredois.Location = new System.Drawing.Point(776, 85);
            this.lsementredois.Name = "lsementredois";
            this.lsementredois.Size = new System.Drawing.Size(112, 18);
            this.lsementredois.TabIndex = 20;
            this.lsementredois.Text = "2º Semestre";
            this.lsementredois.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lsementredois.Click += new System.EventHandler(this.lsementredois_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.label3.Location = new System.Drawing.Point(763, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "|";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(283, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "DEPARTAMENTO DOS RECURSOS HUMANOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(358, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "EXTENSÃO DA BEIRA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 276);
            this.dataGridView1.TabIndex = 13;
            // 
            // UCDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btlaboral);
            this.Controls.Add(this.btposlaboral);
            this.Controls.Add(this.lsemestreum);
            this.Controls.Add(this.lsementredois);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UCDashboard";
            this.Size = new System.Drawing.Size(917, 447);
            this.Load += new System.EventHandler(this.UCDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btlaboral;
        private System.Windows.Forms.Button btposlaboral;
        private System.Windows.Forms.Label lsemestreum;
        private System.Windows.Forms.Label lsementredois;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
