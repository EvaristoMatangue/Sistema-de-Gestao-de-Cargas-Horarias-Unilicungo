﻿namespace SGC.View
{
    partial class UCGCCursos
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbperiodo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbcordenador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.cbnivel = new System.Windows.Forms.ComboBox();
            this.btactualizar = new System.Windows.Forms.Button();
            this.btapagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.label6.Location = new System.Drawing.Point(297, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 33);
            this.label6.TabIndex = 41;
            this.label6.Text = "Cadastrar Cursos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Periodo";
            // 
            // cbperiodo
            // 
            this.cbperiodo.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbperiodo.FormattingEnabled = true;
            this.cbperiodo.Items.AddRange(new object[] {
            "Laboral",
            "Pos-Laboral"});
            this.cbperiodo.Location = new System.Drawing.Point(13, 185);
            this.cbperiodo.Name = "cbperiodo";
            this.cbperiodo.Size = new System.Drawing.Size(206, 25);
            this.cbperiodo.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(244, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 328);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btcadastrar
            // 
            this.btcadastrar.BackColor = System.Drawing.Color.Green;
            this.btcadastrar.FlatAppearance.BorderSize = 0;
            this.btcadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcadastrar.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrar.ForeColor = System.Drawing.Color.White;
            this.btcadastrar.Location = new System.Drawing.Point(13, 285);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(206, 25);
            this.btcadastrar.TabIndex = 37;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = false;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Cordenador";
            // 
            // cbcordenador
            // 
            this.cbcordenador.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcordenador.FormattingEnabled = true;
            this.cbcordenador.Location = new System.Drawing.Point(13, 127);
            this.cbcordenador.Name = "cbcordenador";
            this.cbcordenador.Size = new System.Drawing.Size(206, 25);
            this.cbcordenador.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nivel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nome";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(13, 74);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(206, 25);
            this.txtnome.TabIndex = 29;
            // 
            // cbnivel
            // 
            this.cbnivel.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnivel.FormattingEnabled = true;
            this.cbnivel.Items.AddRange(new object[] {
            "1º Ano",
            "2º Ano",
            "3º Ano",
            "4º Ano"});
            this.cbnivel.Location = new System.Drawing.Point(13, 236);
            this.cbnivel.Name = "cbnivel";
            this.cbnivel.Size = new System.Drawing.Size(206, 25);
            this.cbnivel.TabIndex = 42;
            // 
            // btactualizar
            // 
            this.btactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.btactualizar.FlatAppearance.BorderSize = 0;
            this.btactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btactualizar.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btactualizar.ForeColor = System.Drawing.Color.White;
            this.btactualizar.Location = new System.Drawing.Point(13, 331);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.Size = new System.Drawing.Size(206, 25);
            this.btactualizar.TabIndex = 43;
            this.btactualizar.Text = "Actualizar";
            this.btactualizar.UseVisualStyleBackColor = false;
            this.btactualizar.Click += new System.EventHandler(this.btactualizar_Click);
            // 
            // btapagar
            // 
            this.btapagar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btapagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btapagar.FlatAppearance.BorderSize = 0;
            this.btapagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btapagar.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btapagar.ForeColor = System.Drawing.Color.White;
            this.btapagar.Location = new System.Drawing.Point(13, 377);
            this.btapagar.Name = "btapagar";
            this.btapagar.Size = new System.Drawing.Size(206, 25);
            this.btapagar.TabIndex = 64;
            this.btapagar.Text = "Apagar";
            this.btapagar.UseVisualStyleBackColor = false;
            this.btapagar.Click += new System.EventHandler(this.btapagar_Click);
            // 
            // UCGCCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btapagar);
            this.Controls.Add(this.btactualizar);
            this.Controls.Add(this.cbnivel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbperiodo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbcordenador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnome);
            this.Name = "UCGCCursos";
            this.Size = new System.Drawing.Size(917, 447);
            this.Load += new System.EventHandler(this.UCGCCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbperiodo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbcordenador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.ComboBox cbnivel;
        private System.Windows.Forms.Button btactualizar;
        private System.Windows.Forms.Button btapagar;
    }
}
