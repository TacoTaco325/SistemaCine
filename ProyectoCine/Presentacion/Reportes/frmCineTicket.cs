using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Reportes
{
    public partial class frmCineTicket : Form
    {
        public frmCineTicket()
        {
            InitializeComponent();
        }

        public int id;

        private void frmCineTicket_Load(object sender, EventArgs e)
        {
            rptCineTicket rpt = new rptCineTicket();
            rpt.SetParameterValue("@id", id);
            crystalReportViewer1.ReportSource = rpt;

        }
    }
}
