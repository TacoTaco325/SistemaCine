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

namespace Presentacion
{
    public partial class frmAcceso : Form
    {
        clsUsuarioMgr oUsermgr = new clsUsuarioMgr();
        int count;
        int timecount;

        public frmAcceso()
        {
            InitializeComponent();
        }

        void limpiar()
        {
            txtusu.Clear();
            txtcon.Clear();
        }

        void validar()
        {
            var validar = oUsermgr.Validar(txtusu.Text, txtcon.Text);
            if (validar!=false)
            {
                this.Hide();
                frmSplash f = new frmSplash();
                f.Show();
            }
            else
            {
                lblError.Visible = true;
                ptbError.Visible = true;
                lblError.Text = "Usuario y/o Contraseña Incorrecta";
                ptbError.Image = Properties.Resources.WarningLabel;
                limpiar();
                count += 1;
            }
            if (count >= 3)
            {
                lblError.Visible = true;
                ptbError.Visible = true;
                lblError.Text = "Maximo de intentos alcanzado (3)";
                ptbError.Image = Properties.Resources.Errorlabel;
                txtusu.Enabled = false;
                txtcon.Enabled = false;
                timer1.Start();
            }
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           validar();
        }

        private void btnNoVer_Click(object sender, EventArgs e)
        {
            btnNoVer.Visible = false;
            btnVer.Visible = true;
            txtcon.UseSystemPasswordChar = false;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            btnVer.Visible = false;
            btnNoVer.Visible = true;
            txtcon.UseSystemPasswordChar = true;
        }

        private void txtusu_Enter(object sender, EventArgs e)
        {
            if (txtusu.Text == "USUARIO")
            {
                txtusu.Text = "";
                txtusu.ForeColor = Color.LightGray;
            }
        }

        private void txtusu_Leave(object sender, EventArgs e)
        {
            if (txtusu.Text == "")
            {
                txtusu.Text = "USUARIO";
                txtusu.ForeColor = Color.DimGray;
            }
        }

        private void txtcon_Enter(object sender, EventArgs e)
        {
            if (txtcon.Text == "CONTRASEÑA")
            {
                txtcon.Text = "";
                txtcon.ForeColor = Color.LightGray;
                txtcon.UseSystemPasswordChar = true;
            }
        }

        private void txtcon_Leave(object sender, EventArgs e)
        {
            if (txtcon.Text == "")
            {
                txtcon.Text = "CONTRASEÑA";
                txtcon.ForeColor = Color.DimGray;
                txtcon.UseSystemPasswordChar = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timecount += 1;
            if (timecount == 100)
            {
                this.Close();
            }
        }

        private void txtcon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnAceptar.PerformClick();
        }
    }
}
