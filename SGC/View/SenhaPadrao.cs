using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC.View
{
    public partial class SenhaPadrao : Form
    {
        public SenhaPadrao()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            AlterarSenha alterar = new AlterarSenha();
            alterar.FormClosed += (s, args) => this.Close();
            this.Hide();
            alterar.ShowDialog();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
