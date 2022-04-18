using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;


namespace Presentacion
{
    public partial class frmPeliculaDatos : Form
    {
        DBCINEEntities db = new DBCINEEntities();
        clsPelicula objpelicula = new clsPelicula();
        Pelicula pelicula = new Pelicula();
        MemoryStream ms = new MemoryStream();
        public frmPeliculaDatos(clsPelicula pp)
        {
            InitializeComponent();
            objpelicula = pp;
            llenarCombo();
            tipooperacion();
        }

        private void frmPeliculaDatos_Load(object sender, EventArgs e)
        {

        }

        private void PBPerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Todas las imagenes soportadas |*.jpeg;*.png;*.bmp;*.ico;*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PBPerfil.Load(openFileDialog.FileName);
            }
        }
        void tipooperacion()
        {
            switch (objpelicula.operacion)
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
            switch (objpelicula.operacion)
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
            PBPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            pelicula.img = ms.GetBuffer();
            pelicula.nombre = txtNombre.Text;
            pelicula.idgen = Convert.ToInt32(cboGenero.SelectedValue.ToString());
            pelicula.idclasi = Convert.ToInt32(cboClasificacion.SelectedValue.ToString());
            pelicula.estreno = dtpFecha.Value.Date;
            pelicula.sinopsis = txtSinopsis.Text;
            pelicula.estado = true;
            db.Pelicula.Add(pelicula);
            db.SaveChanges();
        }

        void actualizar()
        {
            PBPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            pelicula.img = ms.GetBuffer();
            pelicula.nombre = txtNombre.Text;
            pelicula.idgen = Convert.ToInt32(cboGenero.SelectedValue.ToString());
            pelicula.idclasi = Convert.ToInt32(cboClasificacion.SelectedValue.ToString());
            pelicula.estreno = dtpFecha.Value.Date;
            pelicula.sinopsis = txtSinopsis.Text;
            pelicula.estado = true;
            db.Entry(pelicula).State = EntityState.Modified;
            db.SaveChanges();
        }

        void llenarcampos()
        {
            pelicula = db.Pelicula.Find(objpelicula.idpel);
            if (pelicula.img != null)
            {
                MemoryStream ms = new MemoryStream(pelicula.img);
                PBPerfil.Image = Image.FromStream(ms);
            }
            txtNombre.Text = pelicula.nombre;
            cboGenero.SelectedValue = pelicula.idgen;
            cboClasificacion.SelectedValue = pelicula.idclasi;
            dtpFecha.Text = pelicula.estreno.ToString();
            txtSinopsis.Text = pelicula.sinopsis;
            chkEstado.Checked=true;
        }

        void llenarCombo()
        {
            var genero = from g in db.Genero
                         where g.estado == true
                         select new { g.idgen, g.genero1 };
            cboGenero.DataSource = genero.ToList();
            cboGenero.DisplayMember = "genero1";
            cboGenero.ValueMember = "idgen";

            var clasificacion = from c in db.Clasificacion
                                where c.estado == true
                                select new { c.idclasi, c.clasificacion1 };
            cboClasificacion.DataSource = clasificacion.ToList();
            cboClasificacion.DisplayMember = "clasificacion1";
            cboClasificacion.ValueMember = "idclasi";

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
