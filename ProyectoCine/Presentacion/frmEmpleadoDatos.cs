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
    public partial class frmEmpleadoDatos : Form
    {
        DBCINEEntities db = new DBCINEEntities();
        clsEmpMant objEmp = new clsEmpMant();
        Empleado empleado = new Empleado();

        public frmEmpleadoDatos(clsEmpMant pp)
        {
            InitializeComponent();
            objEmp = pp;
            llenarcombo();
            tipooperacion();
        }

        private void frmEmpleadoDatos_Load(object sender, EventArgs e)
        {

        }

        void llenarcombo()
        {
            var cargo = from c in db.Cargo
                        where c.estado == true
                        select new { c.idcargo, c.cargo1 };
            cboCargo.DataSource = cargo.ToList();
            cboCargo.DisplayMember = "cargo1";
            cboCargo.ValueMember = "idcargo";
        }

        void llenarcampos()
        {
            empleado = db.Empleado.Find(objEmp.idEmp);
            txtID.Text = empleado.id.ToString();
            txtNombre.Text = empleado.nombre;
            txtApellido.Text = empleado.apellido;
            txtDNI.Text = empleado.dni.ToString();
            txtEdad.Text = empleado.edad.ToString();
            cboCargo.SelectedValue = empleado.idcargo;
            txtUsu.Text = empleado.usu;
            txtCont.Text = empleado.cont;
            chkEstado.Checked = true;
        }

        void tipooperacion()
        {
            switch (objEmp.operacion)
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

        void operacion()
        {
            switch (objEmp.operacion)
            {
                case 1:
                    guardar();
                    MessageBox.Show("La Pelicula se Grabó correctamente....", "Aviso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
                case 2:
                    actualizar();
                    MessageBox.Show("La Pelicula se Actualizo correctamente....", "Aviso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        void guardar()
        {
            empleado.nombre = txtNombre.Text;
            empleado.apellido = txtApellido.Text;
            empleado.dni = Convert.ToInt32(txtDNI.Text);
            empleado.edad = Convert.ToInt32(txtEdad.Text);
            empleado.idcargo = Convert.ToInt32(cboCargo.SelectedValue);
            empleado.usu = txtUsu.Text;
            empleado.cont = txtCont.Text;
            empleado.estado = true;
            db.Empleado.Add(empleado);
            db.SaveChanges();
        }

        void actualizar()
        {
            empleado.nombre = txtNombre.Text;
            empleado.apellido = txtApellido.Text;
            empleado.dni = Convert.ToInt32(txtDNI.Text);
            empleado.edad = Convert.ToInt32(txtEdad.Text);
            empleado.idcargo = Convert.ToInt32(cboCargo.SelectedValue);
            empleado.usu = txtUsu.Text;
            empleado.cont = txtCont.Text;
            empleado.estado = true;
            db.Entry(empleado).State = EntityState.Modified;
            db.SaveChanges();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            operacion();
        }
    }
}
