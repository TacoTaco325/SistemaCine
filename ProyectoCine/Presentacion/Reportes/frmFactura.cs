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
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        public int id;

        private void frmFactura_Load(object sender, EventArgs e)
        {
            rptFactura rpt = new rptFactura();
            rpt.SetParameterValue("@id", id);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
