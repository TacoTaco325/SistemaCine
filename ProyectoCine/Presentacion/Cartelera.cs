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

namespace Presentacion
{
    public partial class Cartelera : UserControl
    {
        frmCartelera fm;
        int id;
        public Cartelera(string nombre,byte[] img,frmCartelera form,int idpel,string sinopsis)
        {
            InitializeComponent();
            lblTitulo.Text = nombre;
            txtSinopsis.Text =sinopsis;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            fm = form;
            id = idpel;

        }

        private void Cartelera_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            frmTicket frm = new frmTicket();

            frm.detalle(id);
            fm.Abrirpanel(frm);
        }
    }
}
