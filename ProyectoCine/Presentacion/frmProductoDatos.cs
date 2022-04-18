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

namespace Presentacion
{
    public partial class frmProductoDatos : Form
    {
        DBCINEEntities db = new DBCINEEntities();
        clsProducto objpro = new clsProducto();
        Producto producto = new Producto();

        public frmProductoDatos(clsProducto pp)
        {
            InitializeComponent();
            objpro = pp;
            llenarcombo();
            tipooperacion();
        }

        private void frmProductoDatos_Load(object sender, EventArgs e)
        {

        }
        void actualizar()
        {
            producto.nombre = txtNombre.Text;
            producto.stock = Convert.ToInt32(txtStock.Text);
            producto.precio = Convert.ToDouble(txtPrecio.Text);
            producto.idcat = Convert.ToInt32(cboCategoria.SelectedValue.ToString());
            producto.estado = true;
            db.Entry(producto).State = EntityState.Modified;
            db.SaveChanges();
        }

        void llenarcombo()
        {
            var lst = from c in db.Categoria
                      where c.estado == true
                      select new { c.idcat, c.cat };
            cboCategoria.DataSource = lst.ToList();
            cboCategoria.DisplayMember = "cat";
            cboCategoria.ValueMember = "idcat";
        }

        void tipooperacion()
        {
            switch (objpro.operacion)
            {
                case 1:
                    btnAceptar.Text = "Guardar";
                    break;
                case 2:
                    llenarcampos();
                    chkEstado.Enabled = false;
                    btnAceptar.Text = "Actualizar";
                    break;
            }
        }

        void guardar()
        {
            producto.nombre = txtNombre.Text;
            producto.stock = Convert.ToInt32(txtStock.Text);
            producto.precio = Convert.ToDouble(txtStock.Text);
            producto.idcat = Convert.ToInt32(cboCategoria.SelectedValue.ToString());
            producto.estado = true;
            db.Producto.Add(producto);
            db.SaveChanges();
        }

        void operacion()
        {
            switch (objpro.operacion)
            {
                case 1:
                    guardar();
                    MessageBox.Show("El Producto se Grabó correctamente....", "Aviso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
                case 2:
                    actualizar();
                    MessageBox.Show("El Producto se Actualizo correctamente....", "Aviso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        void llenarcampos()
        {
            producto = db.Producto.Find(objpro.id);
            txtID.Text = producto.idpro.ToString();
            txtNombre.Text = producto.nombre;
            txtStock.Text = producto.stock.ToString();
            txtPrecio.Text = producto.precio.ToString();
            cboCategoria.SelectedValue = producto.idcat;
            chkEstado.Checked = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            operacion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
