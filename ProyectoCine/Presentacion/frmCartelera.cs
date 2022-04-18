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
    public partial class frmCartelera : Form
    {
        DBCINEEntities db = new DBCINEEntities();
        clsPelicula objpelicula = new clsPelicula();
        clsCineMgr objCineMgr = new clsCineMgr();
        DataTable tbl = new DataTable();
        int op;
        int count=1;

        public frmCartelera()
        {
            InitializeComponent();
        }

        private void frmCartelera_Load(object sender, EventArgs e)
        {
            generar();
            Abrirpanel(new frmTicket());
        }

        public void Abrirpanel(object formhija)
        {
            if (this.pnlPadre.Controls.Count > 0)
            {
                this.pnlPadre.Controls.RemoveAt(0);
            }

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlPadre.Controls.Add(fh);
            this.pnlPadre.Tag = fh;
            fh.Show();
        }

        void generar()
        {
            tbl = objCineMgr.cartelera();
            for (int i = 0; i <tbl.Rows.Count; i++)
            {
                Cartelera grp = new Cartelera(tbl.Rows[i][1].ToString(),(byte[])tbl.Rows[i][5],this,(Convert.ToInt32(tbl.Rows[i][0])),tbl.Rows[i][7].ToString());
                flowLayoutPanel1.Controls.Add(grp);
                count++;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
        }
    }
}
