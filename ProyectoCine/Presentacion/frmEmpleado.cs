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
    public partial class frmEmpleado : Form
    {
        DBCINEEntities db = new DBCINEEntities();
        clsEmpMant objemp = new clsEmpMant();
        Empleado empleado = new Empleado();
        int op;


        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            listar();
        }
        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listar();
        }

        void listar()
        {
            var emp = from e in db.Empleado
                      join c in db.Cargo on e.idcargo equals c.idcargo
                      select new { e.id, e.nombre, e.apellido, e.dni, e.edad, c.cargo1, e.usu, e.cont, e.estado };

            dgvEmpleado.DataSource = emp.ToList();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            op = 1;
            objemp.operacion = op;
            frmEmpleadoDatos frm = new frmEmpleadoDatos(objemp);
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            op = 2;
            objemp.operacion = op;
            objemp.idEmp = Convert.ToInt32(dgvEmpleado.Rows[dgvEmpleado.CurrentRow.Index].Cells[0].Value);
            frmEmpleadoDatos frm = new frmEmpleadoDatos(objemp);
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvEmpleado.Rows[dgvEmpleado.CurrentRow.Index].Cells[0].Value);
            empleado = db.Empleado.Find(id);
            empleado.estado = false;
            db.Entry(empleado).State = EntityState.Modified;
            db.SaveChanges();
            listar();
        }
    }
}
