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
    public partial class frmFuncionDatos : Form
    {
        DBCINEEntities db = new DBCINEEntities();
        Funcion funcion = new Funcion();
        clsFuncion objfun = new clsFuncion();

        public frmFuncionDatos(clsFuncion pp)
        {
            InitializeComponent();
            objfun = pp;
            llenarcombo();
            tipooperacion();
        }

        private void frmFuncionDatos_Load(object sender, EventArgs e)
        {
            
        }

        void llenarcombo()
        {
            cboHora.Items.Add("6:00");
            cboHora.Items.Add("8:00");
            cboHora.Items.Add("10:00");

            var sala = from s in db.Sala
                       where s.estado == true
                       select new { s.idsala, s.Sala1 };
            cboSala.DataSource = sala.ToList();
            cboSala.DisplayMember = "Sala1";
            cboSala.ValueMember = "idsala";

            var pelicula = from p in db.Pelicula
                       where p.estado == true
                       select new { p.id, p.nombre };
            cboPelicula.DataSource = pelicula.ToList();
            cboPelicula.DisplayMember = "nombre";
            cboPelicula.ValueMember = "id";
        }

        void llenarcampos()
        {
            funcion = db.Funcion.Find(objfun.idfun);
            txtID.Text = funcion.idfuncion.ToString();
            cboHora.Text = funcion.hora;
            cboSala.SelectedValue = funcion.idsala;
            cboPelicula.SelectedValue = funcion.idpelicula;
            dtpFecha.Text = funcion.fecha.ToString();
            chkEstado.Checked = true;
        }

        void tipooperacion()
        {
            switch (objfun.operacion)
            {
                case 1:
                    cboHora.Text = "6:00";
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
            switch (objfun.operacion)
            {
                case 1:
                    guardar();
                    MessageBox.Show("La Funcion se Grabó correctamente....", "Aviso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
                case 2:
                    actualizar();
                    MessageBox.Show("La Funcion se Actualizo correctamente....", "Aviso",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        void guardar()
        {
            funcion.hora = cboHora.Text;
            funcion.idsala = Convert.ToInt32(cboSala.SelectedValue.ToString());
            funcion.idpelicula = Convert.ToInt32(cboPelicula.SelectedValue.ToString());
            funcion.fecha = dtpFecha.Value.Date;
            funcion.estado = true;
            db.Funcion.Add(funcion);
            db.SaveChanges();
        }

        void actualizar()
        {
            funcion.hora = cboHora.Text;
            funcion.idsala = Convert.ToInt32(cboSala.SelectedValue.ToString());
            funcion.idpelicula = Convert.ToInt32(cboPelicula.SelectedValue.ToString());
            funcion.fecha = dtpFecha.Value.Date;
            funcion.estado = true;
            db.Entry(funcion).State = EntityState.Modified;
            db.SaveChanges();
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
