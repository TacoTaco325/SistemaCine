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
    public partial class frmPelicula : Form
    {
        DBCINEEntities db = new DBCINEEntities();
        Pelicula pelicula = new Pelicula();
        clsPelicula objpelicula = new clsPelicula();
        int op;

        public frmPelicula()
        {
            InitializeComponent();
        }

        private void frmPelicula_Load(object sender, EventArgs e)
        {
            listar();
        }
        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listar();
        }

        void listar()
        {
            var lst = from p in db.Pelicula
                      join g in db.Genero on p.idgen equals g.idgen
                      join c in db.Clasificacion on p.idclasi equals c.idclasi
                      where p.estado == true
                      select new { p.id, p.nombre, g.genero1, c.clasificacion1, p.estreno, p.estado };

            dgvPelicula.DataSource = lst.ToList();
        }

        private void dgvPelicula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            op = 1;
            objpelicula.operacion = op;
            frmPeliculaDatos frm = new frmPeliculaDatos(objpelicula);
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            op = 2;
            objpelicula.operacion = op;
            objpelicula.idpel = Convert.ToInt32(dgvPelicula.Rows[dgvPelicula.CurrentRow.Index].Cells[0].Value);
            frmPeliculaDatos frm = new frmPeliculaDatos(objpelicula);
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvPelicula.Rows[dgvPelicula.CurrentRow.Index].Cells[0].Value);
            pelicula = db.Pelicula.Find(id);
            pelicula.estado = false;
            db.Entry(pelicula).State = EntityState.Modified;
            db.SaveChanges();
            listar();
        }
    }
}
