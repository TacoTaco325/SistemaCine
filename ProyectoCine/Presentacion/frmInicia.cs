using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Presentacion
{
    public partial class frmInicia : Form
    {
        DBCINEEntities db = new DBCINEEntities();
        clsUsuarioMgr objUsuMgr = new clsUsuarioMgr();

        public frmInicia()
        {
            InitializeComponent();
            listar();
        }

        private void frmInicia_Load(object sender, EventArgs e)
        {
            tmHora.Start();
            TotalVentasHoy();
            TotalVentasMes();
            CineVentasHoy();
            CineVentasMes();
        }

        void TotalVentasHoy()
        {
            DataTable dt = new DataTable();
            dt = objUsuMgr.TotalVentasHoy(DateTime.Now.ToString("yyyy-MM-dd"));
            lblSumaVenta.Text = dt.Rows[0][0].ToString();
            lblNVenta.Text = dt.Rows[0][1].ToString();
        }

        void TotalVentasMes()
        {
            DataTable dt = new DataTable();
            dt = objUsuMgr.TotalVentasMes(DateTime.Now.ToString("MM"));
            lblSumaVentaMes.Text = dt.Rows[0][0].ToString();
            lblNVentaMes.Text = dt.Rows[0][1].ToString();
        }

        void CineVentasHoy()
        {
            DataTable dt = new DataTable();
            dt = objUsuMgr.CineVentasHoy(DateTime.Now.ToString("yyyy-MM-dd"));
            lblSumaCineHoy.Text = dt.Rows[0][0].ToString();
            lblNCineHoy.Text = dt.Rows[0][1].ToString();
        }

        void CineVentasMes()
        {
            DataTable dt = new DataTable();
            dt = objUsuMgr.CineVentasMes(DateTime.Now.ToString("MM"));
            lblSumaCineMes.Text = dt.Rows[0][0].ToString();
            lblNCineMes.Text = dt.Rows[0][1].ToString();
        }

        void listar()
        {
            var lst = from p in db.Producto
                      where p.stock <= 10
                      select new { p.idpro, p.nombre, p.stock };
            dgvProducto.DataSource = lst.ToList();
        }

        private void tmHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
