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
    public partial class FormAlertaContinuar : Form
    {
        public FormAlertaContinuar(string mensagem)
        {
            InitializeComponent();
            lalerta.Text = mensagem;
        }

        private void btcontinuar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
