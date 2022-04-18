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
using Entidad;

namespace Presentacion
{
    public partial class frmCajaConfiteria : Form
    {
        DBCINEEntities db = new DBCINEEntities();
        Producto producto = new Producto();
        clsProducto objpro = new clsProducto();
        clsUsuarioMgr objUsuMgr = new clsUsuarioMgr();
        int filaactual;
        String Pago;
        String Tipo;

        public frmCajaConfiteria()
        {
            InitializeComponent();
            listar();
            Tipo = "Boleta";
            Pago = "Efectivo";
        }

        private void frmCajaConfiteria_Load(object sender, EventArgs e)
        {
            tmHora.Start();
        }

        void listar()
        {
            var lst = from p in db.Producto
                      where p.estado == true && p.stock > 0 
                      select new { ID = p.idpro, Nombre = p.nombre, Precio = p.precio };
            dgvProducto.DataSource = lst.ToList();
        }

        string[,] ListaVenta = new string[200, 6];
        int Fila = 0;

        void agregar()
        {
            try
            {
                if (lblID.Text != "" && txtCantidad.Text != "")
                {
                    ListaVenta[Fila, 0] = lblID.Text;
                    ListaVenta[Fila, 1] = lblNombre.Text;
                    ListaVenta[Fila, 2] = lblPrecio.Text;
                    ListaVenta[Fila, 3] = txtCantidad.Text;
                    ListaVenta[Fila, 4] = (float.Parse(lblPrecio.Text) * int.Parse(txtCantidad.Text)).ToString();

                    dgvNotaPedido.Rows.Add(ListaVenta[Fila, 0], ListaVenta[Fila, 1], ListaVenta[Fila, 2], ListaVenta[Fila, 3], ListaVenta[Fila, 4]);

                    Fila++;

                    lblNombre.Text = lblPrecio.Text = "...";
                    lblID.Text = "";
                    txtCantidad.Value = 0;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            costopagar();
        }

        void limpiarfila()
        {
            if (dgvNotaPedido.RowCount > 0)
            {
                dgvNotaPedido.Rows.RemoveAt(dgvNotaPedido.CurrentRow.Index);
                lblCostoApagar.Text = "0";
                costopagar();
            }
        }

        void costopagar()
        {
            decimal suma = 0;
            foreach (DataGridViewRow row in dgvNotaPedido.Rows)
            {
                suma += Convert.ToDecimal(row.Cells[4].Value);
            }
            lblCostoApagar.Text = suma.ToString();
        }

        void Limpiar_Detalles()
        {
            dgvNotaPedido.Rows.Clear();txtCliente.Text = "";
            txtEfectivo.Text = "0";
            lblCostoApagar.Text = "0";
            lbldevolucion.Text = "0";
            
            rbnBoleta.Checked = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Value==0)
            {
                label11.Visible = true;
                pictureBox2.Visible = true;
            }
            else
            {
                agregar();
                label11.Visible = false;
                pictureBox2.Visible = false;
            }
        }

        private void rbnBoleta_CheckedChanged(object sender, EventArgs e)
        {
            Tipo = "Boleta";
        }

        private void rbnFactura_CheckedChanged(object sender, EventArgs e)
        {
            Tipo = "Factura";
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            limpiarfila();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar_Detalles();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                label1.Visible = true;
                pictureBox1.Visible = true;
            }
            if (txtEfectivo.Text == "")
            {
                label14.Visible = true;
                pictureBox3.Visible = true;
            }
            else
            {
                TipoBoleta();
            }
            
        }

        void TipoBoleta()
        {
            if (Tipo == "Factura")
            {
                Reportes.frmFactura frm = new Reportes.frmFactura();
                vender();
                MessageBox.Show("Venta Registrada Correctamente - Facturada Generada Correctamente...", "Sistema Caja");
                DataTable d = new DataTable();
                d = objUsuMgr.EjecutaQueryID("IDB");
                int id = int.Parse(d.Rows[0][0].ToString());
                frm.id = id;
                frm.Show();
            }
            else
            {
                Reportes.frmTicket frm = new Reportes.frmTicket();
                vender();
                MessageBox.Show("Venta Registrada Correctamente - Ticket Generado Correctamente...", "Sistema Caja");
                DataTable d = new DataTable();
                d = objUsuMgr.EjecutaQueryID("IDB");
                int id = int.Parse(d.Rows[0][0].ToString());
                frm.id = id;
                frm.Show();
            }
        }

        void vender()
        {
            if (dgvNotaPedido.Rows.Count>0)
            {
                clsBoleta.idEmp =clsEmpleado.idEmp;
                clsBoleta.devolucion = float.Parse(lbldevolucion.Text);
                clsBoleta.Efectivo = float.Parse(txtEfectivo.Text);
                clsBoleta.pago = Pago;
                clsBoleta.tipo = Tipo;
                clsBoleta.cliente = txtCliente.Text;
                clsBoleta.fecha = DateTime.Now.ToString("yyyy-MM-dd");
                clsBoleta.Hora = DateTime.Now.ToString("HH:mm:ss");
                clsBoleta.Costo = float.Parse(lblCostoApagar.Text);
                objUsuMgr.EjecutaQuery("RV");

                DataTable d = new DataTable();
                d = objUsuMgr.EjecutaQueryID("IDB");
                clsDetalleBoleta.idBoleta = int.Parse(d.Rows[0][0].ToString());


                for (int i = 0; i < dgvNotaPedido.Rows.Count; i++)
                {
                    clsDetalleBoleta.idpro = int.Parse(dgvNotaPedido.Rows[i].Cells[0].Value.ToString()); ;
                    clsDetalleBoleta.precioUni = float.Parse(dgvNotaPedido.Rows[i].Cells[2].Value.ToString());
                    clsDetalleBoleta.Cantidad = int.Parse(dgvNotaPedido.Rows[i].Cells[3].Value.ToString());
                    clsDetalleBoleta.Costo = float.Parse(dgvNotaPedido.Rows[i].Cells[4].Value.ToString());
                    objUsuMgr.EjecutaQuery("ASV");
                    objUsuMgr.EjecutaQuery("RDV");
                }
                Limpiar_Detalles();
                listar();
            }
        }

        private void tmHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaactual = dgvProducto.CurrentCell.RowIndex;
            lblID.Text = dgvProducto.Rows[filaactual].Cells[0].Value.ToString();
            lblNombre.Text = dgvProducto.Rows[filaactual].Cells[1].Value.ToString();
            lblPrecio.Text = dgvProducto.Rows[filaactual].Cells[2].Value.ToString();
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
