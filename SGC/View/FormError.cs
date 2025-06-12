using MySqlX.XDevAPI;
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
    public partial class FormError : Form
    {
        public FormError()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormError_Load(object sender, EventArgs e)
        {
            lerror.Text = $"{Helppers.Session.Error}";
        }

        private void btfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
