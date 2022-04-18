using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Presentacion
{
    public partial class frmButaca : Form
    {
        int Pelicula;
        int Sala;
        string Hora;
        int numa;
        int count;
        

        decimal total;
        clsCineMgr objCineMgr = new clsCineMgr();
        DataTable tbl = new DataTable();

        List<string> butaca = new List<string>();

        public frmButaca()
        {
            InitializeComponent();
        }

        private void Seleccion(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (count<numa)
            {
                if (btn.BackColor == Color.Green)
                {
                    btn.BackColor = Color.Red;
                    butaca.Add(btn.Text);
                    count += 1;
                    lblNSeleccionadas.Text = count.ToString();
                }
            }
            else
            {
                if (btn.BackColor==Color.Red)
                {
                    btn.BackColor = Color.Green;
                    butaca.Remove(btn.Text);
                    count -= 1;
                    lblNSeleccionadas.Text = count.ToString();
                }
               
            }


            frmDetalleTicket frm = new frmDetalleTicket();
            frm.detalle(Pelicula, Hora, Sala, numa, total, butaca);
            Abrirpanel(frm);

        }
        public void detalle(int idpel,int sala, string hora, int num, decimal tot)
        {
            Pelicula = idpel;
            Sala = sala;
            Hora = hora;
            numa = num;
            total= tot;
        }

        void reservar()
        {
            tbl = objCineMgr.reservacion(Pelicula,Sala,DateTime.Now.ToString("yyyy-MM-dd"),Hora, true);
            foreach (Control ctr in Controls)
            {
                if (ctr is GroupBox)
                {
                    foreach (Control btn in ctr.Controls)
                    {
                        foreach (DataRow dr in tbl.Rows)
                        {
                            if (btn is Button)
                            {
                                if (dr["codbutaca"].ToString() == ((Button)btn).Text)
                                {
                                    btn.BackColor = Color.Yellow;
                                    btn.Enabled = false;
                                }
                            }
                        }
                    }
                }
            }
        }

        void Abrirpanel(object formhija)
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

        private void frmButaca_Load(object sender, EventArgs e)
        {
            reservar();
            Abrirpanel(new frmDetalleTicket());
            lblNButaca.Text = numa.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
