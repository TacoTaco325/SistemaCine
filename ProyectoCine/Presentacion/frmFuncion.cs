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
    public partial class frmFuncion : Form
    {
        DBCINEEntities db = new DBCINEEntities();
        Funcion funcion = new Funcion();
        clsFuncion objfun = new clsFuncion();
        int op;

        public frmFuncion()
        {
            InitializeComponent();
            listar();
        }

        private void frmFuncion_Load(object sender, EventArgs e)
        {

        }

        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listar();
        }

        void listar()
        {
            var funcion = from f in db.Funcion
                          join s in db.Sala on f.idsala equals s.idsala
                          join p in db.Pelicula on f.idpelicula equals p.id
                          where f.estado == true && p.estado == true
                          select new { f.idfuncion, f.hora, f.fecha, s.Sala1, p.nombre };
            dgvFuncion.DataSource = funcion.ToList();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            op = 1;
            objfun.operacion = op;
            frmFuncionDatos frm = new frmFuncionDatos(objfun);
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            op = 2;
            objfun.operacion = op;
            objfun.idfun = Convert.ToInt32(dgvFuncion.Rows[dgvFuncion.CurrentRow.Index].Cells[0].Value);
            frmFuncionDatos frm = new frmFuncionDatos(objfun);
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvFuncion.Rows[dgvFuncion.CurrentRow.Index].Cells[0].Value);
            funcion = db.Funcion.Find(id);
            funcion.estado = false;
            db.Entry(funcion).State = EntityState.Modified;
            db.SaveChanges();
            listar();
        }
    }
}
