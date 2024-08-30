using Microsoft.Reporting.WinForms;
using SGC.Helppers;
using SGC.View;
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
    
    public partial class FormRelatorio : Form
    {
        DataTable dt = new DataTable();
        public FormRelatorio(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            string dataAtual = Helppers.Dados.horas;

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new 
                Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));

            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
        
    }
}
