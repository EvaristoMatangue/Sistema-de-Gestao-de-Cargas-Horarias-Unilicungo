using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC
{
    public partial class FormSucess : Form
    {
        public FormSucess()
        {
            InitializeComponent();
        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSucess_Load(object sender, EventArgs e)
        {
            lsucess.Text = $"{Helppers.Session.Sucess}";

        }
    }
}
