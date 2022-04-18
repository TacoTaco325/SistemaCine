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
    public partial class frmProducto : Form
    {
        DBCINEEntities db = new DBCINEEntities();
        clsProducto objpro = new clsProducto();
        Producto producto = new Producto();
        int op;
        
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listar();
        }

        void listar()
        {
            var lst = from p in db.Producto
                      join c in db.Categoria on p.idcat equals c.idcat
                      where p.estado == true
                      select new {p.idpro,p.nombre,p.stock,c.cat,p.precio };
            dgvProducto.DataSource = lst.ToList();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            op = 1;
            objpro.operacion = op;
            frmProductoDatos frm = new frmProductoDatos(objpro);
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            op = 2;
            objpro.operacion = op;
            objpro.id = Convert.ToInt32(dgvProducto.Rows[dgvProducto.CurrentRow.Index].Cells[0].Value);
            frmProductoDatos frm = new frmProductoDatos(objpro);
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvProducto.Rows[dgvProducto.CurrentRow.Index].Cells[0].Value);
            producto = db.Producto.Find(id);
            producto.estado = false;
            db.Entry(producto).State = EntityState.Modified;
            db.SaveChanges();
            listar();
        }

        private void dgvProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvProducto.Columns[e.ColumnIndex].Name == "Stock")
            {
                if (Convert.ToInt32(e.Value) <= 10)
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
