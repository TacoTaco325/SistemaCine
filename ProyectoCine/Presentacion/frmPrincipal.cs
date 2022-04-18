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
    public partial class frmPrincipal : Form
    {
        clsUsuarioMgr objUsuMgr = new clsUsuarioMgr();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "" + clsEmpleado.apellido + ", " + clsEmpleado.nombre + "";
            lblDNI.Text = clsEmpleado.DNI.ToString();
            cargo();
        }

        void alerta()
        {
            var alerta = objUsuMgr.AlertaStock();
            if (alerta == true)
            {
                MessageBox.Show("ALERTA ALGUNOS PRODUCTOS TIENEN UN STOCK MENOR A 10");
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

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Abrirpanel(new frmProducto());
            subpnlMant.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPelicula_Click(object sender, EventArgs e)
        {
            Abrirpanel(new frmPelicula());
            subpnlMant.Visible = false;
        }

        private void btnConfiteria_Click(object sender, EventArgs e)
        {
            switch (clsEmpleado.idCargo)
            {
                case 1:
                    Abrirpanel(new frmCajaConfiteria());
                    subpnlMant.Visible = false;
                    break;
                case 2:
                    MessageBox.Show("No eres Empleado Confiteria", "Sistema Cine");
                    break;
                case 3:
                    Abrirpanel(new frmCajaConfiteria());
                    subpnlMant.Visible = false;
                    break;
            }
        }

        private void btnCine_Click(object sender, EventArgs e)
        {
            switch (clsEmpleado.idCargo)
            {
                case 1:
                    Abrirpanel(new frmCartelera());
                    subpnlMant.Visible = false;
                    break;
                case 2:
                    Abrirpanel(new frmCartelera());
                    subpnlMant.Visible = false;
                    break;
                case 3:
                    MessageBox.Show("No eres Empleado Cine", "Sistema Cine");
                    break;
            }
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            if (clsEmpleado.idCargo==1)
            {
                if (subpnlMant.Visible == true)
                {
                    subpnlMant.Visible = false;
                }
                else
                {
                    subpnlMant.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("No eres Administrador", "Sistema Cine");
            }
            
        }
        void cargo()
        {
            switch (clsEmpleado.idCargo)
            {
                case 1:
                    lblCargo.Text = "ADMINISTRADOR";
                    ptbCargo.Image = Properties.Resources._2GU;
                    Abrirpanel(new frmInicia());
                    alerta();
                    break;
                case 2:
                    lblCargo.Text = "CINE";
                    ptbCargo.Image = Properties.Resources.Admin;
                    Abrirpanel(new frmCartelera());
                    break;
                case 3:
                    lblCargo.Text = "CONFITERIA";
                    ptbCargo.Image = Properties.Resources.Forsaken;
                    Abrirpanel(new frmCajaConfiteria());
                    break;
            }
        }

        //private void btnR_Click(object sender, EventArgs e)
        //{
        //    if (clsEmpleado.idCargo==1)
        //    {
        //        if (subpnlReport.Visible == true)
        //        {
        //            subpnlReport.Visible = false;
        //        }
        //        else
        //        {
        //            subpnlReport.Visible = true;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("No eres Administrador", "Sistema Cine");
        //    }
        //    subpnlMant.Visible = false;
            
        //}

        private void btnFuncion_Click(object sender, EventArgs e)
        {
            Abrirpanel(new frmFuncion());
            subpnlMant.Visible = false;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAcceso fra = new frmAcceso();
            fra.Show();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            if (clsEmpleado.idCargo == 1)
            {
                Abrirpanel(new frmInicia());
            }
            else
            {
                MessageBox.Show("No eres Administrador", "Sistema Cine");
            }
            subpnlMant.Visible = false;
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Abrirpanel(new frmEmpleado());
            subpnlMant.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
