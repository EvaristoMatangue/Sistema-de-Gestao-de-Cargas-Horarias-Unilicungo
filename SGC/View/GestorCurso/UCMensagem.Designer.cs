namespace SGC.View.GestorCurso
{
    partial class UCMensagem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lmensagem = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btactualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lmensagem);
            this.panel1.Location = new System.Drawing.Point(53, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 188);
            this.panel1.TabIndex = 45;
            // 
            // lmensagem
            // 
            this.lmensagem.AutoSize = true;
            this.lmensagem.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmensagem.ForeColor = System.Drawing.Color.Black;
            this.lmensagem.Location = new System.Drawing.Point(17, 18);
            this.lmensagem.Name = "lmensagem";
            this.lmensagem.Size = new System.Drawing.Size(0, 18);
            this.lmensagem.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.label6.Location = new System.Drawing.Point(361, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 33);
            this.label6.TabIndex = 44;
            this.label6.Text = "Mensagens";
            // 
            // btactualizar
            // 
            this.btactualizar.BackColor = System.Drawing.Color.Green;
            this.btactualizar.FlatAppearance.BorderSize = 0;
            this.btactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btactualizar.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btactualizar.ForeColor = System.Drawing.Color.White;
            this.btactualizar.Location = new System.Drawing.Point(658, 321);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.Size = new System.Drawing.Size(205, 25);
            this.btactualizar.TabIndex = 31;
            this.btactualizar.Text = "Macar como finalizado";
            this.btactualizar.UseVisualStyleBackColor = false;
            this.btactualizar.Click += new System.EventHandler(this.btactualizar_Click);
            // 
            // UCMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btactualizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Name = "UCMensagem";
            this.Size = new System.Drawing.Size(917, 447);
            this.Load += new System.EventHandler(this.UCMensagem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btactualizar;
        private System.Windows.Forms.Label lmensagem;
    }
}
