using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Controlador;

namespace Presentacion
{
    public partial class frmDetalleTicket : Form
    {
        int Pelicula;
        int Sala;
        string Hora;
        int numa;
        decimal total;
        string Pago;

        List<string> lst = new List<string>();
        DBCINEEntities db = new DBCINEEntities();
        Pelicula pelicula = new Pelicula();
        Sala SALA = new Sala();
        Reservacion reservacion = new Reservacion();
        clsCineMgr objCineMgr = new clsCineMgr();
        clsUsuarioMgr objUsuMgr = new clsUsuarioMgr();
        DataTable dt = new DataTable();

        public frmDetalleTicket()
        {
            InitializeComponent();
            Pago = "Efectivo";
        }

        private void frmDetalleTicket_Load(object sender, EventArgs e)
        {
            cargar();
        }
        void cargar()
        {
            if (numa>0)
            {
                pelicula = db.Pelicula.Find(Pelicula);
                lblPelicula.Text = pelicula.nombre;

                SALA = db.Sala.Find(Sala);
                lblSala.Text = SALA.Sala1;

                lblFuncion.Text = Hora;
                lblnumButaca.Text = numa.ToString();
                lstButaca.DataSource = lst;

                lblCostoApagar.Text = total.ToString();
            }
        }

        public void detalle(int idpelicula, string hora,int sala,int num, decimal tot, List<string> butaca)
        {
            Pelicula = idpelicula;
            Hora = hora;
            Sala = sala;
            numa = num;
            total = tot;
            lst = butaca;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Reportes.frmCineTicket frm = new Reportes.frmCineTicket();
            vender();
            MessageBox.Show("Venta Registrada Correctamente - Ticket Generado Correctamente...", "Sistema Caja");
            DataTable d = new DataTable();
            d = objUsuMgr.EjecutaQueryID("IDT");
            int id = int.Parse(d.Rows[0][0].ToString());
            frm.id = id;
            frm.Show();
        }

        void vender()
        {
            dt = objCineMgr.IDfuncion(DateTime.Now.ToString("yyyy-MM-dd"),lblFuncion.Text,lblSala.Text);
            clsTicket.idEmp = clsEmpleado.idEmp;
            clsTicket.fecha = DateTime.Now.ToString("yyyy-MM-dd");
            clsTicket.Hora = DateTime.Now.ToString("HH:mm:ss");
            clsTicket.Costo = float.Parse(lblCostoApagar.Text);
            clsTicket.cliente = txtCliente.Text;
            clsTicket.pago = Pago;
            clsTicket.Efectivo = float.Parse(txtEfectivo.Text);
            clsTicket.devolucion = float.Parse(lbldevolucion.Text);
            clsTicket.idfun = Convert.ToInt32(dt.Rows[0][0]);
            objUsuMgr.EjecutaQuery("RT");

            DataTable d = new DataTable();
            d = objUsuMgr.EjecutaQueryID("IDT");
            clsDetalleTicket.idticket = Convert.ToInt32(d.Rows[0][0]);

            for (int i = 0; i <lstButaca.Items.Count; i++)
            {
                clsDetalleTicket.codbutaca = lstButaca.Items[i].ToString();
                reservacion.codbutaca = lstButaca.Items[i].ToString();
                reservacion.idfuncion = Convert.ToInt32(dt.Rows[0][0]);
                db.Reservacion.Add(reservacion);
                db.SaveChanges();
                objUsuMgr.EjecutaQuery("RDT");
            }
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbldevolucion.Text = (float.Parse(txtEfectivo.Text) - float.Parse(lblCostoApagar.Text)).ToString();
            }
            catch
            {
                lbldevolucion.Text = "0";
            }
        }

        private void rbnEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            Pago = "Efectivo";
            txtEfectivo.Enabled = true;
        }

        private void rbnTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            Pago = "Tarjeta";
            txtEfectivo.Text = lblCostoApagar.Text;
            txtEfectivo.Enabled = false;
        }
    }
}
